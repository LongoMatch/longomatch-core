// PlayListTreeView.cs
//
//  Copyright (C) 2007 Andoni Morales Alastruey
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
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
//
//
using System;
using Gtk;
using Gdk;
using Mono.Unix;

namespace LongoMatch
{
	
	
public class PlayListTreeView : Gtk.TreeView
	{
		

		private TreeIter selectedIter;
		private Menu menu;
		private PlayListTimeNode selectedPlayListNode;
		private ListStore ls;

		
		public PlayListTreeView(){
			

			this.HeadersVisible = false;

			ls = new ListStore(typeof(PlayListTimeNode));
			this.Model = ls;
			
		
			
			menu = new Menu();
			MenuItem quit = new MenuItem(Catalog.GetString("Delete"));
			quit.Activated += new EventHandler(OnMenuFilePopup);
			quit.Show();
			menu.Append(quit);		
			

			Gtk.TreeViewColumn nameColumn = new Gtk.TreeViewColumn ();
			
			nameColumn.Title = Catalog.GetString("Name");
		
			Gtk.CellRendererText nameCell = new Gtk.CellRendererText ();
			nameColumn.PackStart (nameCell, true);
			nameColumn.SetCellDataFunc (nameCell, new Gtk.TreeCellDataFunc (RenderName));
 
			/*Gtk.TreeViewColumn startTimeColumn = new Gtk.TreeViewColumn ();
			startTimeColumn.Title = "Start";
			Gtk.CellRendererText startTimeCell = new Gtk.CellRendererText ();
			startTimeColumn.PackStart (startTimeCell, true);
			
			Gtk.TreeViewColumn stopTimeColumn = new Gtk.TreeViewColumn ();
			stopTimeColumn.Title = "Stop";
			Gtk.CellRendererText stopTimeCell = new Gtk.CellRendererText ();
			stopTimeColumn.PackStart (stopTimeCell, true);

            startTimeColumn.SetCellDataFunc (startTimeCell, new Gtk.TreeCellDataFunc (RenderStartTime));
			stopTimeColumn.SetCellDataFunc (stopTimeCell, new Gtk.TreeCellDataFunc (RenderStopTime));*/
			
			
			
			
			
			this.AppendColumn (nameColumn);
			/*this.AppendColumn (startTimeColumn);
			this.AppendColumn (stopTimeColumn);*/

		
		}
		
		
		~PlayListTreeView()
		{

		}
		
		
		protected override bool OnButtonPressEvent (EventButton evnt)
		{
			//Call base class, to allow normal handling,
			//such as allowing the row to be selected by the right-click:
			bool returnValue = base.OnButtonPressEvent(evnt);
			
			//Then do our custom stuff:
			if( (evnt.Type == EventType.ButtonPress) && (evnt.Button == 3) )
			{
				TreePath path;
				this.GetPathAtPos((int)evnt.X,(int)evnt.Y,out path);
				if (path!=null){
					this.Model.GetIter (out selectedIter,path); 
					selectedPlayListNode = (PlayListTimeNode)this.Model.GetValue (selectedIter, 0);
				    menu.Popup();
				}
			}
			return returnValue;
								
		}
		
		protected void OnMenuFilePopup(object obj, EventArgs args){
			((ListStore)this.Model).Remove(ref selectedIter);
			
		}
		
		private void RenderName (Gtk.TreeViewColumn column, Gtk.CellRenderer cell, Gtk.TreeModel model, Gtk.TreeIter iter)
		{
			PlayListTimeNode tNode = (PlayListTimeNode) model.GetValue (iter, 0);
			
 
			/*if (song.Artist.StartsWith ("X") == true) {
				(cell as Gtk.CellRendererText).Foreground = "red";
			} else {
				(cell as Gtk.CellRendererText).Foreground = "darkgreen";
			}*/
 
			(cell as Gtk.CellRendererText).Text = Catalog.GetString("Name: ")+tNode.Name +"\n"+Catalog.GetString("Start: ")+tNode.Start.ToMSecondsString()
				+Catalog.GetString(" sec")+"\n"+Catalog.GetString("Duration: ")+tNode.Duration.ToMSecondsString()+Catalog.GetString(" sec");
			if (tNode.NonValid)
				(cell as Gtk.CellRendererText).Sensitive = false;
		}
 
		
		private void RenderStartTime (Gtk.TreeViewColumn column, Gtk.CellRenderer cell, Gtk.TreeModel model, Gtk.TreeIter iter)
		{
			PlayListTimeNode tNode = (PlayListTimeNode) model.GetValue (iter, 0);
			(cell as Gtk.CellRendererText).Text = tNode.Start.ToMSecondsString();
				
			
		}
		
		private void RenderStopTime (Gtk.TreeViewColumn column, Gtk.CellRenderer cell, Gtk.TreeModel model, Gtk.TreeIter iter)
		{
			PlayListTimeNode tNode = (PlayListTimeNode) model.GetValue (iter, 0);
			(cell as Gtk.CellRendererText).Text = tNode.Stop.ToMSecondsString();
		}
		
			



	}
}
