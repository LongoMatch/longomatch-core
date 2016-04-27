
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Component
{
	public partial class ProjectListWidget
	{
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Image focusimage;
		
		private global::Gtk.Entry filterEntry;
		
		private global::Gtk.ComboBox sortcombobox;
		
		private global::Gtk.ScrolledWindow icoscrolledwindow;
		
		private global::Gtk.IconView iconview;
		
		private global::Gtk.ScrolledWindow treeviewscrolledwindow;
		
		private global::Gtk.TreeView treeview;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Component.ProjectListWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.Component.ProjectListWidget";
			// Container child LongoMatch.Gui.Component.ProjectListWidget.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.focusimage = new global::Gtk.Image ();
			this.focusimage.Name = "focusimage";
			this.hbox1.Add (this.focusimage);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.focusimage]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.filterEntry = new global::Gtk.Entry ();
			this.filterEntry.WidthRequest = 100;
			this.filterEntry.CanFocus = true;
			this.filterEntry.Name = "filterEntry";
			this.filterEntry.IsEditable = true;
			this.filterEntry.InvisibleChar = '●';
			this.hbox1.Add (this.filterEntry);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.filterEntry]));
			w2.Position = 1;
			// Container child hbox1.Gtk.Box+BoxChild
			this.sortcombobox = global::Gtk.ComboBox.NewText ();
			this.sortcombobox.AppendText (global::VAS.Core.Catalog.GetString ("Sort by name"));
			this.sortcombobox.AppendText (global::VAS.Core.Catalog.GetString ("Sort by date"));
			this.sortcombobox.AppendText (global::VAS.Core.Catalog.GetString ("Sort by modification date"));
			this.sortcombobox.AppendText (global::VAS.Core.Catalog.GetString ("Sort by season"));
			this.sortcombobox.AppendText (global::VAS.Core.Catalog.GetString ("Sort by competition"));
			this.sortcombobox.WidthRequest = 150;
			this.sortcombobox.Name = "sortcombobox";
			this.sortcombobox.Active = 0;
			this.hbox1.Add (this.sortcombobox);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.sortcombobox]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.icoscrolledwindow = new global::Gtk.ScrolledWindow ();
			this.icoscrolledwindow.CanFocus = true;
			this.icoscrolledwindow.Name = "icoscrolledwindow";
			// Container child icoscrolledwindow.Gtk.Container+ContainerChild
			this.iconview = new global::Gtk.IconView ();
			this.iconview.CanFocus = true;
			this.iconview.Name = "iconview";
			this.icoscrolledwindow.Add (this.iconview);
			this.vbox2.Add (this.icoscrolledwindow);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.icoscrolledwindow]));
			w6.Position = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.treeviewscrolledwindow = new global::Gtk.ScrolledWindow ();
			this.treeviewscrolledwindow.Name = "treeviewscrolledwindow";
			// Container child treeviewscrolledwindow.Gtk.Container+ContainerChild
			this.treeview = new global::Gtk.TreeView ();
			this.treeview.CanFocus = true;
			this.treeview.Name = "treeview";
			this.treeview.HeadersVisible = false;
			this.treeviewscrolledwindow.Add (this.treeview);
			this.vbox2.Add (this.treeviewscrolledwindow);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.treeviewscrolledwindow]));
			w8.Position = 2;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.icoscrolledwindow.Hide ();
			this.treeviewscrolledwindow.Hide ();
			this.Show ();
			this.filterEntry.Changed += new global::System.EventHandler (this.OnFilterentryChanged);
		}
	}
}
