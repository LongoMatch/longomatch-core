
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Component
{
	public partial class ProjectListWidget
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Label filterlabel;
		private global::Gtk.Entry filterEntry;
		private global::Gtk.ScrolledWindow scrolledwindow2;
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
			this.filterlabel = new global::Gtk.Label ();
			this.filterlabel.Name = "filterlabel";
			this.filterlabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Projects Search:");
			this.hbox1.Add (this.filterlabel);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.filterlabel]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.filterEntry = new global::Gtk.Entry ();
			this.filterEntry.CanFocus = true;
			this.filterEntry.Name = "filterEntry";
			this.filterEntry.IsEditable = true;
			this.filterEntry.InvisibleChar = '●';
			this.hbox1.Add (this.filterEntry);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.filterEntry]));
			w2.Position = 1;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.scrolledwindow2 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow2.CanFocus = true;
			this.scrolledwindow2.Name = "scrolledwindow2";
			// Container child scrolledwindow2.Gtk.Container+ContainerChild
			this.treeview = new global::Gtk.TreeView ();
			this.treeview.CanFocus = true;
			this.treeview.Name = "treeview";
			this.scrolledwindow2.Add (this.treeview);
			this.vbox2.Add (this.scrolledwindow2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.scrolledwindow2]));
			w5.Position = 1;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.filterEntry.Changed += new global::System.EventHandler (this.OnFilterentryChanged);
		}
	}
}
