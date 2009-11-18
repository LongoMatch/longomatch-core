// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LongoMatch.Gui.Component {


	public partial class PlaysListTreeWidget {

		private Gtk.ScrolledWindow scrolledwindow1;

		private LongoMatch.Gui.Component.PlaysTreeView treeview;

		protected virtual void Build() {
			Stetic.Gui.Initialize(this);
			// Widget LongoMatch.Gui.Component.PlaysListTreeWidget
			Stetic.BinContainer.Attach(this);
			this.Name = "LongoMatch.Gui.Component.PlaysListTreeWidget";
			// Container child LongoMatch.Gui.Component.PlaysListTreeWidget.Gtk.Container+ContainerChild
			this.scrolledwindow1 = new Gtk.ScrolledWindow();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			Gtk.Viewport w1 = new Gtk.Viewport();
			w1.ShadowType = ((Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.treeview = new LongoMatch.Gui.Component.PlaysTreeView();
			this.treeview.CanFocus = true;
			this.treeview.Name = "treeview";
			w1.Add(this.treeview);
			this.scrolledwindow1.Add(w1);
			this.Add(this.scrolledwindow1);
			if ((this.Child != null)) {
				this.Child.ShowAll();
			}
			this.Show();
			this.treeview.TimeNodeChanged += new LongoMatch.Handlers.TimeNodeChangedHandler(this.OnTimeNodeChanged);
			this.treeview.TimeNodeSelected += new LongoMatch.Handlers.TimeNodeSelectedHandler(this.OnTimeNodeSelected);
			this.treeview.TimeNodeDeleted += new LongoMatch.Handlers.TimeNodeDeletedHandler(this.OnTimeNodeDeleted);
			this.treeview.PlayListNodeAdded += new LongoMatch.Handlers.PlayListNodeAddedHandler(this.OnPlayListNodeAdded);
			this.treeview.SnapshotSeriesEvent += new LongoMatch.Handlers.SnapshotSeriesHandler(this.OnTreeviewSnapshotSeriesEvent);
			this.treeview.PlayersTagged += new LongoMatch.Handlers.PlayersTaggedHandler(this.OnTreeviewPlayersTagged);
		}
	}
}
