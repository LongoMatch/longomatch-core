// TreeWidgetPopup.cs
//
//  Copyright (C) 2007-2009 Andoni Morales Alastruey
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA 02110-1301, USA.
//
//

using System;
using System.Collections.Generic;
using Gdk;
using Gtk;
using Mono.Unix;
using LongoMatch.Handlers;
using LongoMatch.TimeNodes;

namespace LongoMatch.Gui.Component
{


	[System.ComponentModel.Category("LongoMatch")]
	[System.ComponentModel.ToolboxItem(true)]
	public class PlaysTreeView : Gtk.TreeView
	{

		public event TimeNodeChangedHandler TimeNodeChanged;
		public event TimeNodeSelectedHandler TimeNodeSelected;
		public event TimeNodeDeletedHandler TimeNodeDeleted;
		public event PlayListNodeAddedHandler PlayListNodeAdded;
		public event SnapshotSeriesHandler SnapshotSeriesEvent;
		public event PlayersTaggedHandler PlayersTagged;

		private Menu menu;
		private MenuItem local;
		private	MenuItem visitor;
		private MenuItem noTeam;
		private MenuItem addPLN;
		private MenuItem deleteKeyFrame;
		private MenuItem snapshot;
		private MenuItem name;
		private MenuItem players;
		
		private Gtk.CellRendererText nameCell;
		private Gtk.TreeViewColumn nameColumn;
		private Color[] colors;
		private bool editing;


		public PlaysTreeView() {
			Selection.Mode = SelectionMode.Multiple;
			Selection.SelectFunction = SelectFunction;
			this.RowActivated += new RowActivatedHandler(OnTreeviewRowActivated);

			SetMenu();

			colors = new Color[20];

			nameColumn = new Gtk.TreeViewColumn();
			nameColumn.Title = "Name";
			nameCell = new Gtk.CellRendererText();
			nameCell.Edited += OnNameCellEdited;
			Gtk.CellRendererPixbuf miniatureCell = new Gtk.CellRendererPixbuf();
			nameColumn.PackStart(miniatureCell, true);
			nameColumn.PackEnd(nameCell, true);

			nameColumn.SetCellDataFunc(miniatureCell, new Gtk.TreeCellDataFunc(RenderMiniature));
			nameColumn.SetCellDataFunc(nameCell, new Gtk.TreeCellDataFunc(RenderName));

			this.AppendColumn(nameColumn);
		}

		public Color[]  Colors {
			set {
				this.colors = value;
			}
		}

		public bool PlayListLoaded {
			set {
				addPLN.Sensitive=value;
			}
		}

		private void SetMenu() {
			Menu teamMenu = new Menu();
			local = new MenuItem(Catalog.GetString("Local Team"));
			visitor = new MenuItem(Catalog.GetString("Visitor Team"));
			noTeam = new MenuItem(Catalog.GetString("No Team"));
			teamMenu .Append(local);
			teamMenu .Append(visitor);
			teamMenu .Append(noTeam);

			Menu playersMenu = new Menu();
			MenuItem localPlayers = new MenuItem(Catalog.GetString("Local team"));
			MenuItem visitorPlayers = new MenuItem(Catalog.GetString("Visitor team"));
			playersMenu.Append(localPlayers);
			playersMenu.Append(visitorPlayers);

			menu = new Menu();

			name = new MenuItem(Catalog.GetString("Edit"));
			MenuItem team = new MenuItem(Catalog.GetString("Team Selection"));
			team.Submenu = teamMenu;
			players = new MenuItem(Catalog.GetString("Tag player"));
			players.Submenu = playersMenu;
			MenuItem quit = new MenuItem(Catalog.GetString("Delete"));
			deleteKeyFrame = new MenuItem(Catalog.GetString("Delete key frame"));
			addPLN = new MenuItem(Catalog.GetString("Add to playlist"));
			addPLN.Sensitive=false;
			snapshot = new MenuItem(Catalog.GetString("Export to PGN images"));

			menu.Append(name);
			menu.Append(team);
			menu.Append(players);
			menu.Append(addPLN);
			menu.Append(quit);
			menu.Append(deleteKeyFrame);
			menu.Append(snapshot);

			name.Activated += OnEdit;
			local.Activated += OnTeamSelection;
			visitor.Activated += OnTeamSelection;
			noTeam.Activated += OnTeamSelection;
			localPlayers.Activated += OnLocalPlayers;
			visitorPlayers.Activated += OnVisitorPlayers;
			addPLN.Activated += OnAdded;
			quit.Activated += OnDeleted;
			deleteKeyFrame.Activated += OnDeleteKeyFrame;
			snapshot.Activated += OnSnapshot;
			menu.ShowAll();
		}

		private int GetSectionFromIter(TreeIter iter) {
			TreePath path = this.Model.GetPath(iter);
			return int.Parse(path.ToString().Split(':')[0]);
		}

		private TimeNode GetValueFromPath(TreePath path){
			Gtk.TreeIter iter;
			Model.GetIter(out iter, path);
			return (TimeNode)this.Model.GetValue(iter,0);					
		}	
		
		private void MultiSelectMenu (bool enabled){
			name.Sensitive = !enabled;
			snapshot.Sensitive = !enabled;
			players.Sensitive = !enabled;
		}
		
		private void RenderMiniature(Gtk.TreeViewColumn column, Gtk.CellRenderer cell, Gtk.TreeModel model, Gtk.TreeIter iter)
		{
			TimeNode tNode = (TimeNode) model.GetValue(iter, 0);
			if (tNode is MediaTimeNode) {
				(cell as Gtk.CellRendererPixbuf).Pixbuf = ((MediaTimeNode)tNode).Miniature;
				(cell as Gtk.CellRendererPixbuf).CellBackgroundGdk = colors[GetSectionFromIter(iter)];
			}
			else {
				(cell as Gtk.CellRendererPixbuf).Pixbuf = null;
				(cell as Gtk.CellRendererPixbuf).CellBackground = "white";
			}
		}

		private void RenderName(Gtk.TreeViewColumn column, Gtk.CellRenderer cell, Gtk.TreeModel model, Gtk.TreeIter iter)
		{
			TimeNode tNode = (TimeNode) model.GetValue(iter, 0);

			//Handle special case in which we replace the text in the cell by the name of the TimeNode
			//We need to check if we are editing and only change it for the path that's currently beeing edited

			if (editing && Selection.IterIsSelected(iter))
				(cell as Gtk.CellRendererText).Markup = tNode.Name;
			else if (tNode is MediaTimeNode) {
				(cell as Gtk.CellRendererText).BackgroundGdk = colors[GetSectionFromIter(iter)];
				(cell as Gtk.CellRendererText).CellBackgroundGdk = colors[GetSectionFromIter(iter)];
				(cell as Gtk.CellRendererText).Markup = "<b>"+Catalog.GetString("Name")+": </b>"+tNode.Name+"\n"+
				                                        "<b>"+Catalog.GetString("Team")+": </b>"+(tNode as MediaTimeNode).Team.ToString().ToLower()+"\n"+
				                                        "<b>"+Catalog.GetString("Start")+": </b>"+tNode.Start.ToMSecondsString()+"\n"+
				                                        "<b>"+Catalog.GetString("Stop")+": </b>"+tNode.Stop.ToMSecondsString();
			}
			else {
				(cell as Gtk.CellRendererText).Background = "white";
				(cell as Gtk.CellRendererText).CellBackground = "white";
				(cell as Gtk.CellRendererText).Markup =tNode.Name;
			}
		}

		private void OnNameCellEdited(object o, Gtk.EditedArgs args)
		{
			Gtk.TreeIter iter;
			this.Model.GetIter(out iter, new Gtk.TreePath(args.Path));
			TimeNode tNode = (TimeNode)this.Model.GetValue(iter,0);
			tNode.Name = args.NewText;
			editing = false;
			nameCell.Editable=false;
			if (TimeNodeChanged != null)
				TimeNodeChanged(tNode,args.NewText);
		}
		
		private bool SelectFunction(TreeSelection selection, TreeModel model, TreePath path, bool selected){
			// Don't allow multiselect for categories
			if (!selected &&  selection.GetSelectedRows().Length > 0){
				if (selection.GetSelectedRows().Length == 1){
					return !(GetValueFromPath(selection.GetSelectedRows()[0]) is SectionsTimeNode);
				}
				else{
					return !(GetValueFromPath(path) is SectionsTimeNode);			
				}					
			}
			// Always unselect
			else
				return true;
		}

		protected virtual void OnTreeviewRowActivated(object o, Gtk.RowActivatedArgs args)
		{
			Gtk.TreeIter iter;
			this.Model.GetIter(out iter, args.Path);
			TimeNode tNode = (TimeNode)this.Model.GetValue(iter, 0);

			if (tNode is MediaTimeNode && TimeNodeSelected != null)
				this.TimeNodeSelected((MediaTimeNode)tNode);
		}

		protected override bool OnButtonPressEvent(EventButton evnt)
		{			
			TreePath[] paths = Selection.GetSelectedRows();
			
			if ((evnt.Type == EventType.ButtonPress) && (evnt.Button == 3))
			{
				// We don't want to unselect the play when several
				// plays are selected and we clik the right button
				// For multiedition
				if (paths.Length <= 1){
					base.OnButtonPressEvent(evnt);
					paths = Selection.GetSelectedRows();
				}
				
				Console.WriteLine(paths.Length);
				if (paths.Length == 1) {
					TimeNode selectedTimeNode = GetValueFromPath(paths[0]);
					if (selectedTimeNode is MediaTimeNode) {
						deleteKeyFrame.Sensitive = (selectedTimeNode as MediaTimeNode).KeyFrameDrawing != null;
						MultiSelectMenu(false);
						menu.Popup();
					}
					else {
						nameCell.Editable = true;
						this.SetCursor(paths[0],  nameColumn, true);
					}
				}
				else if (paths.Length > 1){
					MultiSelectMenu(true);
					menu.Popup();								
				}
			}
			else 
				base.OnButtonPressEvent(evnt);
			return true;
		}

		protected void OnDeleted(object obj, EventArgs args) {
			if (TimeNodeDeleted == null)
				return;
			List<MediaTimeNode> list = new List<MediaTimeNode>();
			TreePath[] paths = Selection.GetSelectedRows();
			for (int i=0; i<paths.Length; i++){	
				list.Add((MediaTimeNode)GetValueFromPath(paths[i]));
			}
			// When a TimeNode is deleted from the tree the path changes.
			// We need first to retrieve all the TimeNodes to delete using the 
			// current path of each one and then send the TimeNodeDeleted event
			for (int i=0; i<paths.Length; i++){	
				TimeNodeDeleted(list[i], int.Parse(paths[i].ToString().Split(':')[0]));
			}			
		}
		
		protected void OnDeleteKeyFrame(object obj, EventArgs args) {
			MessageDialog md = new MessageDialog((Gtk.Window)Toplevel,
			                                     DialogFlags.Modal,
			                                     MessageType.Question,
			                                     ButtonsType.YesNo,
			                                     false,
			                                     Catalog.GetString("Do you want to delete the key frame for this play?")
			                                    );
			if (md.Run() == (int)ResponseType.Yes){
				TreePath[] paths = Selection.GetSelectedRows();
				for (int i=0; i<paths.Length; i++){	
					MediaTimeNode tNode = (MediaTimeNode)GetValueFromPath(paths[i]);
					tNode.KeyFrameDrawing = null;
				}
				// Refresh the thumbnails
				QueueDraw();
			}
			md.Destroy();
		}

		protected virtual void OnEdit(object obj, EventArgs args) {
			TreePath[] paths = Selection.GetSelectedRows();
			editing = true;
			nameCell.Editable = true;
			nameCell.Markup = GetValueFromPath(paths[0]).Name;
			SetCursor(paths[0],  nameColumn, true);
		}

		protected void OnTeamSelection(object obj, EventArgs args) {
			MenuItem sender = (MenuItem)obj;
			Team team = Team.NONE;
			if (sender == local)
				team = Team.LOCAL;
			else if (sender == visitor)
				team = Team.VISITOR;
			else if (sender == noTeam)
				team = Team.NONE;
			
			TreePath[] paths = Selection.GetSelectedRows();
			for (int i=0; i<paths.Length; i++){	
					MediaTimeNode tNode = (MediaTimeNode)GetValueFromPath(paths[i]);
					tNode.Team = team;
			}
		}

		protected void OnAdded(object obj, EventArgs args) {
			if (PlayListNodeAdded != null){
				TreePath[] paths = Selection.GetSelectedRows();
				for (int i=0; i<paths.Length; i++){	
					MediaTimeNode tNode = (MediaTimeNode)GetValueFromPath(paths[i]);
					PlayListNodeAdded(tNode);
				}
			}
		}

		protected void OnSnapshot(object obj, EventArgs args) {
			if (SnapshotSeriesEvent != null)
				SnapshotSeriesEvent((MediaTimeNode)GetValueFromPath(Selection.GetSelectedRows()[0]));
		}

		protected virtual void OnLocalPlayers(object o, EventArgs args) {
			if (PlayersTagged != null)
				PlayersTagged((MediaTimeNode)GetValueFromPath(Selection.GetSelectedRows()[0]), Team.LOCAL);
		}

		protected virtual void OnVisitorPlayers(object o, EventArgs args) {
			if (PlayersTagged != null)
				PlayersTagged((MediaTimeNode)GetValueFromPath(Selection.GetSelectedRows()[0]), Team.VISITOR);
		}
		
	}
}