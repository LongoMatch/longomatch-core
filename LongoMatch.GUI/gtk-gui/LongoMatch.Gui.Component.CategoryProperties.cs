
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Component
{
	public partial class CategoryProperties
	{
		private global::Gtk.VBox vbox2;
		private global::Gtk.Frame frame4;
		private global::Gtk.Alignment GtkAlignment1;
		private global::Gtk.VBox vbox3;
		private global::Gtk.Table table2;
		private global::Gtk.ColorButton colorbutton1;
		private global::Gtk.HBox hbox5;
		private global::Gtk.Label hotKeyLabel;
		private global::Gtk.Button changebuton;
		private global::Gtk.Label label1;
		private global::Gtk.Label label4;
		private global::Gtk.Label label6;
		private global::Gtk.Label label7;
		private global::Gtk.Label label8;
		private global::Gtk.Label label9;
		private global::Gtk.SpinButton lagtimebutton;
		private global::Gtk.SpinButton leadtimebutton;
		private global::Gtk.Entry nameentry;
		private global::Gtk.ComboBox sortmethodcombobox;
		private global::Gtk.VBox vbox5;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Frame frame5;
		private global::Gtk.Alignment GtkAlignment7;
		private global::Gtk.VBox vbox4;
		private global::Gtk.CheckButton tagfieldcheckbutton;
		private global::Gtk.CheckButton trajectorycheckbutton;
		private global::Gtk.Label GtkLabel9;
		private global::Gtk.Frame frame6;
		private global::Gtk.Alignment GtkAlignment8;
		private global::Gtk.VBox vbox6;
		private global::Gtk.CheckButton taghalffieldcheckbutton;
		private global::Gtk.CheckButton trajectoryhalfcheckbutton;
		private global::Gtk.Label GtkLabel12;
		private global::Gtk.Frame frame7;
		private global::Gtk.Alignment GtkAlignment9;
		private global::Gtk.CheckButton taggoalcheckbutton;
		private global::Gtk.Label GtkLabel13;
		private global::Gtk.Table table3;
		private global::LongoMatch.Gui.Component.CoordinatesTagger fieldcoordinatestagger;
		private global::LongoMatch.Gui.Component.CoordinatesTagger goalcoordinatestagger;
		private global::LongoMatch.Gui.Component.CoordinatesTagger halffieldcoordinatestagger;
		private global::Gtk.Label GtkLabel6;
		private global::Gtk.Frame frame3;
		private global::Gtk.Alignment GtkAlignment3;
		private global::Gtk.VBox vbox1;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::LongoMatch.Gui.SubCategoriesTreeView subcategoriestreeview1;
		private global::Gtk.HBox hbox3;
		private global::Gtk.Frame frame1;
		private global::Gtk.Alignment GtkAlignment4;
		private global::Gtk.Entry subcatnameentry;
		private global::Gtk.Label GtkLabel7;
		private global::Gtk.Frame frame2;
		private global::Gtk.Alignment GtkAlignment5;
		private global::Gtk.ComboBox subcatcombobox;
		private global::Gtk.Label GtkLabel8;
		private global::Gtk.Button addbutton;
		private global::Gtk.Label GtkLabel11;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Component.CategoryProperties
			global::Stetic.BinContainer.Attach (this);
			this.Name = "LongoMatch.Gui.Component.CategoryProperties";
			// Container child LongoMatch.Gui.Component.CategoryProperties.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.frame4 = new global::Gtk.Frame ();
			this.frame4.Name = "frame4";
			this.frame4.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child frame4.Gtk.Container+ContainerChild
			this.GtkAlignment1 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment1.Name = "GtkAlignment1";
			this.GtkAlignment1.LeftPadding = ((uint)(12));
			// Container child GtkAlignment1.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table (((uint)(3)), ((uint)(4)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.colorbutton1 = new global::Gtk.ColorButton ();
			this.colorbutton1.CanFocus = true;
			this.colorbutton1.Events = ((global::Gdk.EventMask)(784));
			this.colorbutton1.Name = "colorbutton1";
			this.table2.Add (this.colorbutton1);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table2 [this.colorbutton1]));
			w1.LeftAttach = ((uint)(3));
			w1.RightAttach = ((uint)(4));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child table2.Gtk.Table+TableChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.hotKeyLabel = new global::Gtk.Label ();
			this.hotKeyLabel.Name = "hotKeyLabel";
			this.hotKeyLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("none");
			this.hbox5.Add (this.hotKeyLabel);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.hotKeyLabel]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.changebuton = new global::Gtk.Button ();
			this.changebuton.Sensitive = false;
			this.changebuton.CanFocus = true;
			this.changebuton.Name = "changebuton";
			this.changebuton.UseUnderline = true;
			this.changebuton.Label = global::Mono.Unix.Catalog.GetString ("Change");
			this.hbox5.Add (this.changebuton);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.changebuton]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			this.table2.Add (this.hbox5);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table2 [this.hbox5]));
			w4.TopAttach = ((uint)(2));
			w4.BottomAttach = ((uint)(3));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child table2.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Name:</b>");
			this.label1.UseMarkup = true;
			this.table2.Add (this.label1);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table2 [this.label1]));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 0F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Color:</b>    ");
			this.label4.UseMarkup = true;
			this.table2.Add (this.label4);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table2 [this.label4]));
			w6.LeftAttach = ((uint)(2));
			w6.RightAttach = ((uint)(3));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 0F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>HotKey:</b>");
			this.label6.UseMarkup = true;
			this.table2.Add (this.label6);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table2 [this.label6]));
			w7.TopAttach = ((uint)(2));
			w7.BottomAttach = ((uint)(3));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.Xalign = 0F;
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Lead time:</b>");
			this.label7.UseMarkup = true;
			this.table2.Add (this.label7);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table2 [this.label7]));
			w8.TopAttach = ((uint)(1));
			w8.BottomAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.Xalign = 0F;
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Lag time:</b>");
			this.label8.UseMarkup = true;
			this.table2.Add (this.label8);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table2 [this.label8]));
			w9.TopAttach = ((uint)(1));
			w9.BottomAttach = ((uint)(2));
			w9.LeftAttach = ((uint)(2));
			w9.RightAttach = ((uint)(3));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.Xalign = 0F;
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Sort Method</b>");
			this.label9.UseMarkup = true;
			this.table2.Add (this.label9);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table2 [this.label9]));
			w10.TopAttach = ((uint)(2));
			w10.BottomAttach = ((uint)(3));
			w10.LeftAttach = ((uint)(2));
			w10.RightAttach = ((uint)(3));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.lagtimebutton = new global::Gtk.SpinButton (0, 1000, 1);
			this.lagtimebutton.CanFocus = true;
			this.lagtimebutton.Name = "lagtimebutton";
			this.lagtimebutton.Adjustment.PageIncrement = 1;
			this.lagtimebutton.ClimbRate = 1;
			this.lagtimebutton.Numeric = true;
			this.table2.Add (this.lagtimebutton);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table2 [this.lagtimebutton]));
			w11.TopAttach = ((uint)(1));
			w11.BottomAttach = ((uint)(2));
			w11.LeftAttach = ((uint)(3));
			w11.RightAttach = ((uint)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.leadtimebutton = new global::Gtk.SpinButton (0, 1000, 1);
			this.leadtimebutton.CanFocus = true;
			this.leadtimebutton.Name = "leadtimebutton";
			this.leadtimebutton.Adjustment.PageIncrement = 1;
			this.leadtimebutton.ClimbRate = 1;
			this.leadtimebutton.Numeric = true;
			this.table2.Add (this.leadtimebutton);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table2 [this.leadtimebutton]));
			w12.TopAttach = ((uint)(1));
			w12.BottomAttach = ((uint)(2));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.nameentry = new global::Gtk.Entry ();
			this.nameentry.CanFocus = true;
			this.nameentry.Name = "nameentry";
			this.nameentry.IsEditable = true;
			this.nameentry.InvisibleChar = '●';
			this.table2.Add (this.nameentry);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table2 [this.nameentry]));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.sortmethodcombobox = global::Gtk.ComboBox.NewText ();
			this.sortmethodcombobox.AppendText (global::Mono.Unix.Catalog.GetString ("Sort by name"));
			this.sortmethodcombobox.AppendText (global::Mono.Unix.Catalog.GetString ("Sort by start time"));
			this.sortmethodcombobox.AppendText (global::Mono.Unix.Catalog.GetString ("Sort by stop time"));
			this.sortmethodcombobox.AppendText (global::Mono.Unix.Catalog.GetString ("Sort by duration"));
			this.sortmethodcombobox.Name = "sortmethodcombobox";
			this.sortmethodcombobox.Active = 3;
			this.table2.Add (this.sortmethodcombobox);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table2 [this.sortmethodcombobox]));
			w14.TopAttach = ((uint)(2));
			w14.BottomAttach = ((uint)(3));
			w14.LeftAttach = ((uint)(3));
			w14.RightAttach = ((uint)(4));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(0));
			this.vbox3.Add (this.table2);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.table2]));
			w15.Position = 0;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.vbox5 = new global::Gtk.VBox ();
			this.vbox5.Name = "vbox5";
			this.vbox5.Spacing = 6;
			// Container child vbox5.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.frame5 = new global::Gtk.Frame ();
			this.frame5.Name = "frame5";
			this.frame5.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame5.Gtk.Container+ContainerChild
			this.GtkAlignment7 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment7.Name = "GtkAlignment7";
			this.GtkAlignment7.LeftPadding = ((uint)(12));
			// Container child GtkAlignment7.Gtk.Container+ContainerChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.tagfieldcheckbutton = new global::Gtk.CheckButton ();
			this.tagfieldcheckbutton.CanFocus = true;
			this.tagfieldcheckbutton.Name = "tagfieldcheckbutton";
			this.tagfieldcheckbutton.Label = global::Mono.Unix.Catalog.GetString ("Enable");
			this.tagfieldcheckbutton.Active = true;
			this.tagfieldcheckbutton.DrawIndicator = true;
			this.tagfieldcheckbutton.UseUnderline = true;
			this.vbox4.Add (this.tagfieldcheckbutton);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.tagfieldcheckbutton]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.trajectorycheckbutton = new global::Gtk.CheckButton ();
			this.trajectorycheckbutton.CanFocus = true;
			this.trajectorycheckbutton.Name = "trajectorycheckbutton";
			this.trajectorycheckbutton.Label = global::Mono.Unix.Catalog.GetString ("Trajectory");
			this.trajectorycheckbutton.DrawIndicator = true;
			this.trajectorycheckbutton.UseUnderline = true;
			this.vbox4.Add (this.trajectorycheckbutton);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.trajectorycheckbutton]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			this.GtkAlignment7.Add (this.vbox4);
			this.frame5.Add (this.GtkAlignment7);
			this.GtkLabel9 = new global::Gtk.Label ();
			this.GtkLabel9.Name = "GtkLabel9";
			this.GtkLabel9.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Field position</b>");
			this.GtkLabel9.UseMarkup = true;
			this.frame5.LabelWidget = this.GtkLabel9;
			this.hbox1.Add (this.frame5);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.frame5]));
			w20.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.frame6 = new global::Gtk.Frame ();
			this.frame6.Name = "frame6";
			this.frame6.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame6.Gtk.Container+ContainerChild
			this.GtkAlignment8 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment8.Name = "GtkAlignment8";
			this.GtkAlignment8.LeftPadding = ((uint)(12));
			// Container child GtkAlignment8.Gtk.Container+ContainerChild
			this.vbox6 = new global::Gtk.VBox ();
			this.vbox6.Name = "vbox6";
			this.vbox6.Spacing = 6;
			// Container child vbox6.Gtk.Box+BoxChild
			this.taghalffieldcheckbutton = new global::Gtk.CheckButton ();
			this.taghalffieldcheckbutton.CanFocus = true;
			this.taghalffieldcheckbutton.Name = "taghalffieldcheckbutton";
			this.taghalffieldcheckbutton.Label = global::Mono.Unix.Catalog.GetString ("Enable");
			this.taghalffieldcheckbutton.DrawIndicator = true;
			this.taghalffieldcheckbutton.UseUnderline = true;
			this.vbox6.Add (this.taghalffieldcheckbutton);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.taghalffieldcheckbutton]));
			w21.Position = 0;
			w21.Expand = false;
			w21.Fill = false;
			// Container child vbox6.Gtk.Box+BoxChild
			this.trajectoryhalfcheckbutton = new global::Gtk.CheckButton ();
			this.trajectoryhalfcheckbutton.CanFocus = true;
			this.trajectoryhalfcheckbutton.Name = "trajectoryhalfcheckbutton";
			this.trajectoryhalfcheckbutton.Label = global::Mono.Unix.Catalog.GetString ("Trajectory");
			this.trajectoryhalfcheckbutton.DrawIndicator = true;
			this.trajectoryhalfcheckbutton.UseUnderline = true;
			this.vbox6.Add (this.trajectoryhalfcheckbutton);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.trajectoryhalfcheckbutton]));
			w22.Position = 1;
			w22.Expand = false;
			w22.Fill = false;
			this.GtkAlignment8.Add (this.vbox6);
			this.frame6.Add (this.GtkAlignment8);
			this.GtkLabel12 = new global::Gtk.Label ();
			this.GtkLabel12.Name = "GtkLabel12";
			this.GtkLabel12.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Half field position</b>");
			this.GtkLabel12.UseMarkup = true;
			this.frame6.LabelWidget = this.GtkLabel12;
			this.hbox1.Add (this.frame6);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.frame6]));
			w25.Position = 1;
			// Container child hbox1.Gtk.Box+BoxChild
			this.frame7 = new global::Gtk.Frame ();
			this.frame7.Name = "frame7";
			this.frame7.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame7.Gtk.Container+ContainerChild
			this.GtkAlignment9 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment9.Name = "GtkAlignment9";
			this.GtkAlignment9.LeftPadding = ((uint)(12));
			// Container child GtkAlignment9.Gtk.Container+ContainerChild
			this.taggoalcheckbutton = new global::Gtk.CheckButton ();
			this.taggoalcheckbutton.CanFocus = true;
			this.taggoalcheckbutton.Name = "taggoalcheckbutton";
			this.taggoalcheckbutton.Label = global::Mono.Unix.Catalog.GetString ("Enable");
			this.taggoalcheckbutton.Active = true;
			this.taggoalcheckbutton.DrawIndicator = true;
			this.taggoalcheckbutton.UseUnderline = true;
			this.GtkAlignment9.Add (this.taggoalcheckbutton);
			this.frame7.Add (this.GtkAlignment9);
			this.GtkLabel13 = new global::Gtk.Label ();
			this.GtkLabel13.Name = "GtkLabel13";
			this.GtkLabel13.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Goal Position</b>");
			this.GtkLabel13.UseMarkup = true;
			this.frame7.LabelWidget = this.GtkLabel13;
			this.hbox1.Add (this.frame7);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.frame7]));
			w28.Position = 2;
			this.vbox5.Add (this.hbox1);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hbox1]));
			w29.Position = 0;
			w29.Expand = false;
			w29.Fill = false;
			// Container child vbox5.Gtk.Box+BoxChild
			this.table3 = new global::Gtk.Table (((uint)(1)), ((uint)(3)), true);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.fieldcoordinatestagger = new global::LongoMatch.Gui.Component.CoordinatesTagger ();
			this.fieldcoordinatestagger.Sensitive = false;
			this.fieldcoordinatestagger.Events = ((global::Gdk.EventMask)(256));
			this.fieldcoordinatestagger.Name = "fieldcoordinatestagger";
			this.fieldcoordinatestagger.Sensitive = false;
			this.table3.Add (this.fieldcoordinatestagger);
			// Container child table3.Gtk.Table+TableChild
			this.goalcoordinatestagger = new global::LongoMatch.Gui.Component.CoordinatesTagger ();
			this.goalcoordinatestagger.Sensitive = false;
			this.goalcoordinatestagger.Events = ((global::Gdk.EventMask)(256));
			this.goalcoordinatestagger.Name = "goalcoordinatestagger";
			this.goalcoordinatestagger.Sensitive = false;
			this.table3.Add (this.goalcoordinatestagger);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table3 [this.goalcoordinatestagger]));
			w31.LeftAttach = ((uint)(2));
			w31.RightAttach = ((uint)(3));
			// Container child table3.Gtk.Table+TableChild
			this.halffieldcoordinatestagger = new global::LongoMatch.Gui.Component.CoordinatesTagger ();
			this.halffieldcoordinatestagger.Sensitive = false;
			this.halffieldcoordinatestagger.Events = ((global::Gdk.EventMask)(256));
			this.halffieldcoordinatestagger.Name = "halffieldcoordinatestagger";
			this.halffieldcoordinatestagger.Sensitive = false;
			this.table3.Add (this.halffieldcoordinatestagger);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table3 [this.halffieldcoordinatestagger]));
			w32.LeftAttach = ((uint)(1));
			w32.RightAttach = ((uint)(2));
			this.vbox5.Add (this.table3);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.table3]));
			w33.Position = 1;
			this.vbox3.Add (this.vbox5);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.vbox5]));
			w34.Position = 1;
			this.GtkAlignment1.Add (this.vbox3);
			this.frame4.Add (this.GtkAlignment1);
			this.GtkLabel6 = new global::Gtk.Label ();
			this.GtkLabel6.Name = "GtkLabel6";
			this.GtkLabel6.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Properties</b>");
			this.GtkLabel6.UseMarkup = true;
			this.frame4.LabelWidget = this.GtkLabel6;
			this.vbox2.Add (this.frame4);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.frame4]));
			w37.Position = 0;
			w37.Expand = false;
			w37.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.frame3 = new global::Gtk.Frame ();
			this.frame3.Name = "frame3";
			this.frame3.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child frame3.Gtk.Container+ContainerChild
			this.GtkAlignment3 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment3.Name = "GtkAlignment3";
			this.GtkAlignment3.LeftPadding = ((uint)(12));
			// Container child GtkAlignment3.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.subcategoriestreeview1 = new global::LongoMatch.Gui.SubCategoriesTreeView ();
			this.subcategoriestreeview1.CanFocus = true;
			this.subcategoriestreeview1.Name = "subcategoriestreeview1";
			this.GtkScrolledWindow.Add (this.subcategoriestreeview1);
			this.vbox1.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.GtkScrolledWindow]));
			w39.Position = 0;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment4 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment4.Name = "GtkAlignment4";
			this.GtkAlignment4.LeftPadding = ((uint)(12));
			// Container child GtkAlignment4.Gtk.Container+ContainerChild
			this.subcatnameentry = new global::Gtk.Entry ();
			this.subcatnameentry.CanFocus = true;
			this.subcatnameentry.Name = "subcatnameentry";
			this.subcatnameentry.IsEditable = true;
			this.subcatnameentry.InvisibleChar = '•';
			this.GtkAlignment4.Add (this.subcatnameentry);
			this.frame1.Add (this.GtkAlignment4);
			this.GtkLabel7 = new global::Gtk.Label ();
			this.GtkLabel7.Name = "GtkLabel7";
			this.GtkLabel7.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Subcategory name</b>");
			this.GtkLabel7.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel7;
			this.hbox3.Add (this.frame1);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.frame1]));
			w42.Position = 0;
			w42.Expand = false;
			w42.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.frame2 = new global::Gtk.Frame ();
			this.frame2.Name = "frame2";
			this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame2.Gtk.Container+ContainerChild
			this.GtkAlignment5 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment5.Name = "GtkAlignment5";
			this.GtkAlignment5.LeftPadding = ((uint)(12));
			// Container child GtkAlignment5.Gtk.Container+ContainerChild
			this.subcatcombobox = new global::Gtk.ComboBox ();
			this.subcatcombobox.Name = "subcatcombobox";
			this.GtkAlignment5.Add (this.subcatcombobox);
			this.frame2.Add (this.GtkAlignment5);
			this.GtkLabel8 = new global::Gtk.Label ();
			this.GtkLabel8.Name = "GtkLabel8";
			this.GtkLabel8.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Subcategory type</b>");
			this.GtkLabel8.UseMarkup = true;
			this.frame2.LabelWidget = this.GtkLabel8;
			this.hbox3.Add (this.frame2);
			global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.frame2]));
			w45.Position = 1;
			// Container child hbox3.Gtk.Box+BoxChild
			this.addbutton = new global::Gtk.Button ();
			this.addbutton.TooltipMarkup = "Add this subcategory";
			this.addbutton.Sensitive = false;
			this.addbutton.CanFocus = true;
			this.addbutton.Name = "addbutton";
			this.addbutton.UseUnderline = true;
			// Container child addbutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w46 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w47 = new global::Gtk.HBox ();
			w47.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w48 = new global::Gtk.Image ();
			w48.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-add", global::Gtk.IconSize.Menu);
			w47.Add (w48);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w50 = new global::Gtk.Label ();
			w50.LabelProp = global::Mono.Unix.Catalog.GetString ("_Add subcategory");
			w50.UseUnderline = true;
			w47.Add (w50);
			w46.Add (w47);
			this.addbutton.Add (w46);
			this.hbox3.Add (this.addbutton);
			global::Gtk.Box.BoxChild w54 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.addbutton]));
			w54.Position = 2;
			w54.Expand = false;
			w54.Fill = false;
			this.vbox1.Add (this.hbox3);
			global::Gtk.Box.BoxChild w55 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox3]));
			w55.Position = 1;
			w55.Expand = false;
			w55.Fill = false;
			this.GtkAlignment3.Add (this.vbox1);
			this.frame3.Add (this.GtkAlignment3);
			this.GtkLabel11 = new global::Gtk.Label ();
			this.GtkLabel11.Name = "GtkLabel11";
			this.GtkLabel11.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Subcategories</b>");
			this.GtkLabel11.UseMarkup = true;
			this.frame3.LabelWidget = this.GtkLabel11;
			this.vbox2.Add (this.frame3);
			global::Gtk.Box.BoxChild w58 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.frame3]));
			w58.Position = 1;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.sortmethodcombobox.Changed += new global::System.EventHandler (this.OnSortmethodcomboboxChanged);
			this.nameentry.Changed += new global::System.EventHandler (this.OnNameentryChanged);
			this.changebuton.Clicked += new global::System.EventHandler (this.OnChangebutonClicked);
			this.colorbutton1.ColorSet += new global::System.EventHandler (this.OnColorbutton1ColorSet);
			this.tagfieldcheckbutton.Clicked += new global::System.EventHandler (this.OnTagfieldcheckbuttonClicked);
			this.trajectorycheckbutton.Clicked += new global::System.EventHandler (this.OnTrajectorycheckbuttonClicked);
			this.taghalffieldcheckbutton.Clicked += new global::System.EventHandler (this.OnTaghalffieldcheckbuttonClicked);
			this.trajectoryhalfcheckbutton.Clicked += new global::System.EventHandler (this.OnTrajectoryhalffieldcheckbuttonClicked);
			this.taggoalcheckbutton.Clicked += new global::System.EventHandler (this.OnTaggoalcheckbuttonClicked);
			this.subcatcombobox.Changed += new global::System.EventHandler (this.OnSubcatcomboboxChanged);
			this.addbutton.Clicked += new global::System.EventHandler (this.OnAddbuttonClicked);
		}
	}
}
