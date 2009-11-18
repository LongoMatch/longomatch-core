// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LongoMatch.Gui.Dialog {


	public partial class EntryDialog {

		private Gtk.HBox hbox2;

		private Gtk.Label label2;

		private Gtk.Entry entry1;

		private Gtk.HBox hbox1;

		private Gtk.Label label1;

		private Gtk.SpinButton spinbutton1;

		private Gtk.Button buttonCancel;

		private Gtk.Button buttonOk;

		protected virtual void Build() {
			Stetic.Gui.Initialize(this);
			// Widget LongoMatch.Gui.Dialog.EntryDialog
			this.Name = "LongoMatch.Gui.Dialog.EntryDialog";
			this.Title = Mono.Unix.Catalog.GetString("Select template name");
			this.Icon = Stetic.IconLoader.LoadIcon(this, "longomatch", Gtk.IconSize.Dialog, 48);
			this.WindowPosition = ((Gtk.WindowPosition)(4));
			this.Modal = true;
			this.Gravity = ((Gdk.Gravity)(5));
			this.SkipPagerHint = true;
			this.SkipTaskbarHint = true;
			this.HasSeparator = false;
			// Internal child LongoMatch.Gui.Dialog.EntryDialog.VBox
			Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox2 = new Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label2 = new Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = Mono.Unix.Catalog.GetString("Name:");
			this.hbox2.Add(this.label2);
			Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox2[this.label2]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.entry1 = new Gtk.Entry();
			this.entry1.CanFocus = true;
			this.entry1.Name = "entry1";
			this.entry1.IsEditable = true;
			this.entry1.InvisibleChar = '●';
			this.hbox2.Add(this.entry1);
			Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox2[this.entry1]));
			w3.Position = 1;
			w1.Add(this.hbox2);
			Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(w1[this.hbox2]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox1 = new Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label1 = new Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = Mono.Unix.Catalog.GetString("Players:");
			this.hbox1.Add(this.label1);
			Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.hbox1[this.label1]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.spinbutton1 = new Gtk.SpinButton(1, 30, 1);
			this.spinbutton1.CanFocus = true;
			this.spinbutton1.Name = "spinbutton1";
			this.spinbutton1.Adjustment.PageIncrement = 10;
			this.spinbutton1.ClimbRate = 1;
			this.spinbutton1.Numeric = true;
			this.spinbutton1.Value = 15;
			this.hbox1.Add(this.spinbutton1);
			Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.hbox1[this.spinbutton1]));
			w6.Position = 1;
			w6.Fill = false;
			w1.Add(this.hbox1);
			Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(w1[this.hbox1]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Internal child LongoMatch.Gui.Dialog.EntryDialog.ActionArea
			Gtk.HButtonBox w8 = this.ActionArea;
			w8.Name = "dialog1_ActionArea";
			w8.Spacing = 6;
			w8.BorderWidth = ((uint)(5));
			w8.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new Gtk.Button();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget(this.buttonCancel, -6);
			Gtk.ButtonBox.ButtonBoxChild w9 = ((Gtk.ButtonBox.ButtonBoxChild)(w8[this.buttonCancel]));
			w9.Expand = false;
			w9.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new Gtk.Button();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget(this.buttonOk, -5);
			Gtk.ButtonBox.ButtonBoxChild w10 = ((Gtk.ButtonBox.ButtonBoxChild)(w8[this.buttonOk]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll();
			}
			this.DefaultWidth = 346;
			this.DefaultHeight = 114;
			this.hbox1.Hide();
			this.Show();
		}
	}
}
