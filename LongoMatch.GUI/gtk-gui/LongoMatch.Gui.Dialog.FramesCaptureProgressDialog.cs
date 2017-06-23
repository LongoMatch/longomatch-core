
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Dialog
{
	public partial class FramesCaptureProgressDialog
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.ProgressBar progressbar;

		private global::Gtk.Image image;

		private global::Gtk.Button okbutton;

		private global::Gtk.Button cancelbutton;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Dialog.FramesCaptureProgressDialog
			this.Name = "LongoMatch.Gui.Dialog.FramesCaptureProgressDialog";
			this.Title = global::VAS.Core.Catalog.GetString ("Capture Progress");
			this.Icon = global::Stetic.IconLoader.LoadIcon (this, "lm-longomatch", global::Gtk.IconSize.Dialog);
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.BorderWidth = ((uint)(3));
			this.Resizable = false;
			this.AllowGrow = false;
			this.Gravity = ((global::Gdk.Gravity)(5));
			this.SkipPagerHint = true;
			this.SkipTaskbarHint = true;
			// Internal child LongoMatch.Gui.Dialog.FramesCaptureProgressDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.progressbar = new global::Gtk.ProgressBar ();
			this.progressbar.Name = "progressbar";
			this.vbox2.Add (this.progressbar);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.progressbar]));
			w2.Position = 0;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.image = new global::Gtk.Image ();
			this.image.Name = "image";
			this.vbox2.Add (this.image);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.image]));
			w3.PackType = ((global::Gtk.PackType)(1));
			w3.Position = 1;
			w1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(w1 [this.vbox2]));
			w4.Position = 0;
			// Internal child LongoMatch.Gui.Dialog.FramesCaptureProgressDialog.ActionArea
			global::Gtk.HButtonBox w5 = this.ActionArea;
			w5.Name = "dialog1_ActionArea";
			w5.Spacing = 6;
			w5.BorderWidth = ((uint)(5));
			w5.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.okbutton = new global::Gtk.Button ();
			this.okbutton.CanFocus = true;
			this.okbutton.Name = "okbutton";
			this.okbutton.UseStock = true;
			this.okbutton.UseUnderline = true;
			this.okbutton.Label = "gtk-ok";
			this.AddActionWidget (this.okbutton, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w6 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w5 [this.okbutton]));
			w6.Expand = false;
			w6.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.cancelbutton = new global::Gtk.Button ();
			this.cancelbutton.CanDefault = true;
			this.cancelbutton.CanFocus = true;
			this.cancelbutton.Name = "cancelbutton";
			this.cancelbutton.UseStock = true;
			this.cancelbutton.UseUnderline = true;
			this.cancelbutton.Label = "gtk-cancel";
			this.AddActionWidget (this.cancelbutton, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w7 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w5 [this.cancelbutton]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 149;
			this.okbutton.Hide ();
			this.Show ();
			this.cancelbutton.Clicked += new global::System.EventHandler (this.OnButtonCancelClicked);
		}
	}
}
