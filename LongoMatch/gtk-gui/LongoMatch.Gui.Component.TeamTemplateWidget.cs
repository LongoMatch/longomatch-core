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


	public partial class TeamTemplateWidget {

		private Gtk.HBox hbox1;

		private Gtk.ScrolledWindow scrolledwindow2;

		private LongoMatch.Gui.Component.PlayerPropertiesTreeView playerpropertiestreeview1;

		protected virtual void Build() {
			Stetic.Gui.Initialize(this);
			// Widget LongoMatch.Gui.Component.TeamTemplateWidget
			Stetic.BinContainer.Attach(this);
			this.Name = "LongoMatch.Gui.Component.TeamTemplateWidget";
			// Container child LongoMatch.Gui.Component.TeamTemplateWidget.Gtk.Container+ContainerChild
			this.hbox1 = new Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.scrolledwindow2 = new Gtk.ScrolledWindow();
			this.scrolledwindow2.CanFocus = true;
			this.scrolledwindow2.Name = "scrolledwindow2";
			this.scrolledwindow2.ShadowType = ((Gtk.ShadowType)(1));
			// Container child scrolledwindow2.Gtk.Container+ContainerChild
			this.playerpropertiestreeview1 = new LongoMatch.Gui.Component.PlayerPropertiesTreeView();
			this.playerpropertiestreeview1.CanFocus = true;
			this.playerpropertiestreeview1.Name = "playerpropertiestreeview1";
			this.scrolledwindow2.Add(this.playerpropertiestreeview1);
			this.hbox1.Add(this.scrolledwindow2);
			Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox1[this.scrolledwindow2]));
			w2.Position = 0;
			this.Add(this.hbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll();
			}
			this.Hide();
			this.playerpropertiestreeview1.PlayerClicked += new LongoMatch.Gui.Component.PlayerPropertiesHandler(this.OnPlayerpropertiestreeview1PlayerClicked);
			this.playerpropertiestreeview1.PlayerSelected += new LongoMatch.Gui.Component.PlayerPropertiesHandler(this.OnPlayerpropertiestreeview1PlayerSelected);
		}
	}
}
