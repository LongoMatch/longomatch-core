
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Component
{
	public partial class AnalysisComponent
	{
		private global::Gtk.UIManager UIManager;

		private global::Gtk.HBox hbox1;

		private global::Gtk.EventBox lightbackgroundeventbox;

		private global::Gtk.VPaned centralpane;

		private global::Gtk.HPaned uppane;

		private global::LongoMatch.Gui.Component.PlaysSelectionWidget playsSelection;

		private global::Gtk.HBox videowidgetsbox;

		private global::VAS.UI.PlayerCapturerBin playercapturer;

		private global::LongoMatch.Gui.Component.CodingWidget codingwidget;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Component.AnalysisComponent
			Stetic.BinContainer w1 = global::Stetic.BinContainer.Attach (this);
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w2 = new global::Gtk.ActionGroup ("Default");
			this.UIManager.InsertActionGroup (w2, 0);
			this.Name = "LongoMatch.Gui.Component.AnalysisComponent";
			// Container child LongoMatch.Gui.Component.AnalysisComponent.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.lightbackgroundeventbox = new global::Gtk.EventBox ();
			this.lightbackgroundeventbox.Name = "lightbackgroundeventbox";
			// Container child lightbackgroundeventbox.Gtk.Container+ContainerChild
			this.centralpane = new global::Gtk.VPaned ();
			this.centralpane.CanFocus = true;
			this.centralpane.Name = "centralpane";
			this.centralpane.Position = 422;
			// Container child centralpane.Gtk.Paned+PanedChild
			this.uppane = new global::Gtk.HPaned ();
			this.uppane.CanFocus = true;
			this.uppane.Name = "uppane";
			this.uppane.Position = 400;
			// Container child uppane.Gtk.Paned+PanedChild
			this.playsSelection = new global::LongoMatch.Gui.Component.PlaysSelectionWidget ();
			this.playsSelection.WidthRequest = 400;
			this.playsSelection.Events = ((global::Gdk.EventMask)(256));
			this.playsSelection.Name = "playsSelection";
			this.uppane.Add (this.playsSelection);
			global::Gtk.Paned.PanedChild w3 = ((global::Gtk.Paned.PanedChild)(this.uppane [this.playsSelection]));
			w3.Resize = false;
			// Container child uppane.Gtk.Paned+PanedChild
			this.videowidgetsbox = new global::Gtk.HBox ();
			this.videowidgetsbox.Name = "videowidgetsbox";
			this.videowidgetsbox.Spacing = 6;
			// Container child videowidgetsbox.Gtk.Box+BoxChild
			this.playercapturer = new global::VAS.UI.PlayerCapturerBin ();
			this.playercapturer.Events = ((global::Gdk.EventMask)(256));
			this.playercapturer.Name = "playercapturer";
			this.videowidgetsbox.Add (this.playercapturer);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.videowidgetsbox [this.playercapturer]));
			w4.Position = 0;
			this.uppane.Add (this.videowidgetsbox);
			this.centralpane.Add (this.uppane);
			global::Gtk.Paned.PanedChild w6 = ((global::Gtk.Paned.PanedChild)(this.centralpane [this.uppane]));
			w6.Resize = false;
			// Container child centralpane.Gtk.Paned+PanedChild
			this.codingwidget = new global::LongoMatch.Gui.Component.CodingWidget ();
			this.codingwidget.Events = ((global::Gdk.EventMask)(256));
			this.codingwidget.Name = "codingwidget";
			this.codingwidget.TagPositions = false;
			this.centralpane.Add (this.codingwidget);
			global::Gtk.Paned.PanedChild w7 = ((global::Gtk.Paned.PanedChild)(this.centralpane [this.codingwidget]));
			w7.Resize = false;
			this.lightbackgroundeventbox.Add (this.centralpane);
			this.hbox1.Add (this.lightbackgroundeventbox);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.lightbackgroundeventbox]));
			w9.Position = 0;
			this.Add (this.hbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			w1.SetUiManager (UIManager);
			this.Hide ();
		}
	}
}
