
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Component
{
	public partial class CategoryProperties
	{
		private global::Gtk.VBox vbox3;

		private global::Gtk.HBox hbox4;

		private global::Gtk.Label label1;

		private global::Gtk.Entry nameentry;

		private global::LongoMatch.Gui.Component.TimeAdjustWidget timeadjustwidget1;

		private global::Gtk.HBox hbox2;

		private global::Gtk.Label label4;

		private global::Gtk.ColorButton colorbutton1;

		private global::Gtk.Button changebuton;

		private global::Gtk.Label hotKeyLabel;

		private global::Gtk.Label label6;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Label label5;

		private global::Gtk.ComboBox sortmethodcombobox;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Component.CategoryProperties
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.Component.CategoryProperties";
			// Container child LongoMatch.Gui.Component.CategoryProperties.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Name:");
			this.hbox4.Add (this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.nameentry = new global::Gtk.Entry ();
			this.nameentry.CanFocus = true;
			this.nameentry.Name = "nameentry";
			this.nameentry.IsEditable = true;
			this.nameentry.InvisibleChar = '●';
			this.hbox4.Add (this.nameentry);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.nameentry]));
			w2.Position = 1;
			this.vbox3.Add (this.hbox4);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox4]));
			w3.Position = 0;
			w3.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.timeadjustwidget1 = new global::LongoMatch.Gui.Component.TimeAdjustWidget ();
			this.timeadjustwidget1.Events = ((global::Gdk.EventMask)(256));
			this.timeadjustwidget1.Name = "timeadjustwidget1";
			this.vbox3.Add (this.timeadjustwidget1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.timeadjustwidget1]));
			w4.Position = 1;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Color:        ");
			this.hbox2.Add (this.label4);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label4]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.colorbutton1 = new global::Gtk.ColorButton ();
			this.colorbutton1.CanFocus = true;
			this.colorbutton1.Events = ((global::Gdk.EventMask)(784));
			this.colorbutton1.Name = "colorbutton1";
			this.hbox2.Add (this.colorbutton1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.colorbutton1]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.changebuton = new global::Gtk.Button ();
			this.changebuton.CanFocus = true;
			this.changebuton.Name = "changebuton";
			this.changebuton.UseUnderline = true;
			this.changebuton.Label = global::Mono.Unix.Catalog.GetString ("Change");
			this.hbox2.Add (this.changebuton);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.changebuton]));
			w7.PackType = ((global::Gtk.PackType)(1));
			w7.Position = 2;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.hotKeyLabel = new global::Gtk.Label ();
			this.hotKeyLabel.Name = "hotKeyLabel";
			this.hotKeyLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("none");
			this.hbox2.Add (this.hotKeyLabel);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.hotKeyLabel]));
			w8.PackType = ((global::Gtk.PackType)(1));
			w8.Position = 3;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("HotKey:");
			this.hbox2.Add (this.label6);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.label6]));
			w9.PackType = ((global::Gtk.PackType)(1));
			w9.Position = 4;
			w9.Expand = false;
			w9.Fill = false;
			this.vbox3.Add (this.hbox2);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox2]));
			w10.Position = 2;
			w10.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Sort Method");
			this.hbox1.Add (this.label5);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.label5]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.sortmethodcombobox = global::Gtk.ComboBox.NewText ();
			this.sortmethodcombobox.AppendText (global::Mono.Unix.Catalog.GetString ("Sort by name"));
			this.sortmethodcombobox.AppendText (global::Mono.Unix.Catalog.GetString ("Sort by start time"));
			this.sortmethodcombobox.AppendText (global::Mono.Unix.Catalog.GetString ("Sort by stop time"));
			this.sortmethodcombobox.AppendText (global::Mono.Unix.Catalog.GetString ("Sort by duration"));
			this.sortmethodcombobox.Name = "sortmethodcombobox";
			this.sortmethodcombobox.Active = 0;
			this.hbox1.Add (this.sortmethodcombobox);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.sortmethodcombobox]));
			w12.Position = 1;
			this.vbox3.Add (this.hbox1);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.hbox1]));
			w13.Position = 3;
			w13.Expand = false;
			w13.Fill = false;
			this.Add (this.vbox3);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.nameentry.Changed += new global::System.EventHandler (this.OnNameentryChanged);
			this.colorbutton1.ColorSet += new global::System.EventHandler (this.OnColorbutton1ColorSet);
			this.changebuton.Clicked += new global::System.EventHandler (this.OnChangebutonClicked);
			this.sortmethodcombobox.Changed += new global::System.EventHandler (this.OnSortmethodcomboboxChanged);
		}
	}
}
