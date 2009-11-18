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
using Gdk;
using Gtk;
using Mono.Unix;
using LongoMatch.Handlers;
using LongoMatch.TimeNodes;

namespace LongoMatch.Gui.Component
{

	public delegate void PlayerPropertiesHandler(Player player);

	[System.ComponentModel.Category("LongoMatch")]
	[System.ComponentModel.ToolboxItem(true)]
	public class PlayerPropertiesTreeView : Gtk.TreeView
	{
		public event PlayerPropertiesHandler PlayerClicked;
		public event PlayerPropertiesHandler PlayerSelected;

		public PlayerPropertiesTreeView() {

			RowActivated += OnTreeviewRowActivated;

			Gtk.TreeViewColumn photoColumn = new Gtk.TreeViewColumn();
			photoColumn.Title = Catalog.GetString("Photo");
			Gtk.CellRendererPixbuf photoCell = new Gtk.CellRendererPixbuf();
			photoColumn.PackStart(photoCell, true);

			Gtk.TreeViewColumn nameColumn = new Gtk.TreeViewColumn();
			nameColumn.Title = Catalog.GetString("Name");
			Gtk.CellRendererText nameCell = new Gtk.CellRendererText();
			nameColumn.PackStart(nameCell, true);


			Gtk.TreeViewColumn positionColumn = new Gtk.TreeViewColumn();
			positionColumn.Title = "Lag Time";
			Gtk.CellRendererText positionCell = new Gtk.CellRendererText();
			positionColumn.PackStart(positionCell, true);

			Gtk.TreeViewColumn numberColumn = new Gtk.TreeViewColumn();
			numberColumn.Title = Catalog.GetString("Number");
			Gtk.CellRendererText numberCell = new Gtk.CellRendererText();
			numberColumn.PackStart(numberCell, true);

			photoColumn.SetCellDataFunc(photoCell, new Gtk.TreeCellDataFunc(RenderPhoto));
			nameColumn.SetCellDataFunc(nameCell, new Gtk.TreeCellDataFunc(RenderName));
			positionColumn.SetCellDataFunc(positionCell, new Gtk.TreeCellDataFunc(RenderPosition));
			numberColumn.SetCellDataFunc(numberCell, new Gtk.TreeCellDataFunc(RenderNumber));

			AppendColumn(photoColumn);
			AppendColumn(nameColumn);
			AppendColumn(positionColumn);
			AppendColumn(numberColumn);
		}

		private void RenderPhoto(Gtk.TreeViewColumn column, Gtk.CellRenderer cell, Gtk.TreeModel model, Gtk.TreeIter iter)
		{
			Player player = (Player) model.GetValue(iter, 0);

			(cell as Gtk.CellRendererPixbuf).Pixbuf = player.Photo;
		}

		private void RenderName(Gtk.TreeViewColumn column, Gtk.CellRenderer cell, Gtk.TreeModel model, Gtk.TreeIter iter)
		{
			Player player = (Player) model.GetValue(iter, 0);

			(cell as Gtk.CellRendererText).Text = player.Name;
		}

		private void RenderPosition(Gtk.TreeViewColumn column, Gtk.CellRenderer cell, Gtk.TreeModel model, Gtk.TreeIter iter)
		{
			Player player = (Player) model.GetValue(iter, 0);

			(cell as Gtk.CellRendererText).Text = player.Position;
		}

		private void RenderNumber(Gtk.TreeViewColumn column, Gtk.CellRenderer cell, Gtk.TreeModel model, Gtk.TreeIter iter)
		{
			Player player = (Player) model.GetValue(iter, 0);

			(cell as Gtk.CellRendererText).Text = player.Number.ToString();
		}

		protected virtual void OnTreeviewRowActivated(object o, Gtk.RowActivatedArgs args)
		{
			Gtk.TreeIter iter;
			Model.GetIter(out iter, args.Path);
			Player player = (Player) Model.GetValue(iter, 0);
			if (PlayerClicked != null)
				PlayerClicked(player);
		}
	}
}