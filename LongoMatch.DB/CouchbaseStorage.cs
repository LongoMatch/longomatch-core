﻿//
//  Copyright (C) 2015 Andoni Morales Alastruey
//
//  This program is free software; you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation; either version 2 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program; if not, write to the Free Software
//  Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA 02110-1301, USA.
//
using System;
using System.Collections.Generic;
using Couchbase.Lite;
using LongoMatch.Core.Common;
using LongoMatch.Core.Interfaces;
using LongoMatch.Core.Serialization;
using LongoMatch.Core.Store.Templates;
using LongoMatch.DB.Views;
using LongoMatch.Core.Store;

namespace LongoMatch.DB
{
	public class CouchbaseStorage: IStorage
	{
		Database db;
		Dictionary<Type, object> views;

		public CouchbaseStorage (string databaseDir, string databaseName)
		{
			Manager manager = new Manager (new System.IO.DirectoryInfo (databaseDir),
				                  ManagerOptions.Default);
			db = manager.GetDatabase (databaseName);
			InitializeViews ();
		}

		internal Database Database {
			get {
				return db;
			}
		}

		void InitializeViews ()
		{
			views = new Dictionary <Type, object> ();
			views.Add (typeof(Dashboard), new DashboardsView (this));
			views.Add (typeof(Team), new TeamsView (this));
			views.Add (typeof(Project), new ProjectsView (this));
			views.Add (typeof(Player), new PlayersView (this));
		}

		public object Retrieve (Type type, Guid id)
		{
			return DocumentsSerializer.LoadObject (type, id, db);
		}

		#region IStorage implementation

		public StorageInfo Info {
			get;
			set;
		}

		public void Fill (IStorable storable)
		{
			DocumentsSerializer.FillObject (storable, db);
		}

		public List<T> RetrieveAll<T> () where T : IStorable
		{
			IQueryView<T> qview = views [typeof(T)] as IQueryView <T>;
			return qview.Query (null);
		}

		public T Retrieve<T> (Guid id) where T : IStorable
		{
			return (T)Retrieve (typeof(T), id);
		}

		public List<T> Retrieve<T> (QueryFilter filter) where T : IStorable
		{
			IQueryView<T> qview = views [typeof(T)] as IQueryView <T>;
			return qview.Query (filter);
		}

		public void Store<T> (T t) where T : IStorable
		{
			db.RunInTransaction (() => {
				StorableNode node;
				ObjectChangedParser parser = new ObjectChangedParser ();
				parser.Parse (out node, t, Serializer.JsonSettings);
				Update (node);
				return true;
			});
		}

		public void Delete<T> (T t) where T : IStorable
		{
			db.RunInTransaction (() => {
				StorableNode node;
				if (t.DeleteChildren) {
					ObjectChangedParser parser = new ObjectChangedParser ();
					parser.Parse (out node, t, Serializer.JsonSettings);
				} else {
					node = new StorableNode (t);
				}
				Delete (node);
				return true;
			});
		}

		public void Reset ()
		{
			db.Manager.ForgetDatabase (db);
		}

		void Delete (StorableNode node = null)
		{
			db.GetDocument (node.Storable.ID.ToString ()).Delete ();
			foreach (StorableNode child in node.Children) {
				Delete (child);
			}
		}

		void Update (StorableNode node) {
			if (node.Deleted) {
				Delete (node);
			} else if (node.IsChanged) {
				DocumentsSerializer.SaveObject (node.Storable, db, saveChildren:false);
			}
			foreach (StorableNode child in node.Children) {
				Update (child);
			}
		}

		#endregion
	}
}

