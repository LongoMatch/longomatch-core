
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Component
{
	public partial class PlaysSelectionWidget
	{
		private global::Gtk.Notebook notebook;
		
		private global::LongoMatch.Gui.Component.EventsListWidget eventslistwidget;
		
		private global::Gtk.Label label1;
		
		private global::LongoMatch.Gui.Component.PlayListWidget playlistwidget;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.VBox filtersvbox;
		
		private global::Gtk.VBox vbox3;
		
		private global::Gtk.EventBox eventbox;
		
		private global::Gtk.Alignment alignment1;
		
		private global::Gtk.HBox hbox3;
		
		private global::Gtk.Button allButton;
		
		private global::Gtk.Button noneButton;
		
		private global::Gtk.HSeparator hseparator1;
		
		private global::Gtk.Notebook filtersnotebook;
		
		private global::Gtk.Label label2;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Component.PlaysSelectionWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.Component.PlaysSelectionWidget";
			// Container child LongoMatch.Gui.Component.PlaysSelectionWidget.Gtk.Container+ContainerChild
			this.notebook = new global::Gtk.Notebook ();
			this.notebook.CanFocus = true;
			this.notebook.Name = "notebook";
			this.notebook.CurrentPage = 2;
			this.notebook.TabPos = ((global::Gtk.PositionType)(0));
			// Container child notebook.Gtk.Notebook+NotebookChild
			this.eventslistwidget = new global::LongoMatch.Gui.Component.EventsListWidget ();
			this.eventslistwidget.Events = ((global::Gdk.EventMask)(256));
			this.eventslistwidget.Name = "eventslistwidget";
			this.notebook.Add (this.eventslistwidget);
			// Notebook tab
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::VAS.Core.Catalog.GetString ("  Events   ");
			this.label1.Justify = ((global::Gtk.Justification)(2));
			this.label1.Angle = 90;
			this.notebook.SetTabLabel (this.eventslistwidget, this.label1);
			this.label1.ShowAll ();
			// Container child notebook.Gtk.Notebook+NotebookChild
			this.playlistwidget = new global::LongoMatch.Gui.Component.PlayListWidget ();
			this.playlistwidget.WidthRequest = 100;
			this.playlistwidget.Events = ((global::Gdk.EventMask)(256));
			this.playlistwidget.Name = "playlistwidget";
			this.notebook.Add (this.playlistwidget);
			global::Gtk.Notebook.NotebookChild w2 = ((global::Gtk.Notebook.NotebookChild)(this.notebook [this.playlistwidget]));
			w2.Position = 1;
			// Notebook tab
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::VAS.Core.Catalog.GetString ("Playlists");
			this.label3.Angle = 90;
			this.notebook.SetTabLabel (this.playlistwidget, this.label3);
			this.label3.ShowAll ();
			// Container child notebook.Gtk.Notebook+NotebookChild
			this.filtersvbox = new global::Gtk.VBox ();
			this.filtersvbox.Name = "filtersvbox";
			this.filtersvbox.Spacing = 6;
			// Container child filtersvbox.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			// Container child vbox3.Gtk.Box+BoxChild
			this.eventbox = new global::Gtk.EventBox ();
			this.eventbox.Name = "eventbox";
			// Container child eventbox.Gtk.Container+ContainerChild
			this.alignment1 = new global::Gtk.Alignment (0F, 0.5F, 0F, 1F);
			this.alignment1.HeightRequest = 40;
			this.alignment1.Name = "alignment1";
			this.alignment1.LeftPadding = ((uint)(25));
			this.alignment1.TopPadding = ((uint)(10));
			this.alignment1.BottomPadding = ((uint)(5));
			// Container child alignment1.Gtk.Container+ContainerChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Homogeneous = true;
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.allButton = new global::Gtk.Button ();
			this.allButton.CanFocus = true;
			this.allButton.Name = "allButton";
			this.allButton.UseUnderline = true;
			this.allButton.Label = global::VAS.Core.Catalog.GetString ("All");
			this.hbox3.Add (this.allButton);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.allButton]));
			w3.Position = 0;
			// Container child hbox3.Gtk.Box+BoxChild
			this.noneButton = new global::Gtk.Button ();
			this.noneButton.CanFocus = true;
			this.noneButton.Name = "noneButton";
			this.noneButton.UseUnderline = true;
			this.noneButton.Label = global::VAS.Core.Catalog.GetString ("None");
			this.hbox3.Add (this.noneButton);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.noneButton]));
			w4.Position = 1;
			this.alignment1.Add (this.hbox3);
			this.eventbox.Add (this.alignment1);
			this.vbox3.Add (this.eventbox);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.eventbox]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.vbox3.Add (this.hseparator1);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hseparator1]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.filtersnotebook = new global::Gtk.Notebook ();
			this.filtersnotebook.CanFocus = true;
			this.filtersnotebook.Name = "filtersnotebook";
			this.filtersnotebook.CurrentPage = 0;
			this.filtersnotebook.TabPos = ((global::Gtk.PositionType)(3));
			this.vbox3.Add (this.filtersnotebook);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.filtersnotebook]));
			w9.Position = 2;
			this.filtersvbox.Add (this.vbox3);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.filtersvbox [this.vbox3]));
			w10.Position = 0;
			this.notebook.Add (this.filtersvbox);
			global::Gtk.Notebook.NotebookChild w11 = ((global::Gtk.Notebook.NotebookChild)(this.notebook [this.filtersvbox]));
			w11.Position = 2;
			// Notebook tab
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::VAS.Core.Catalog.GetString ("  Filters  ");
			this.label2.Angle = 90;
			this.notebook.SetTabLabel (this.filtersvbox, this.label2);
			this.label2.ShowAll ();
			this.Add (this.notebook);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
