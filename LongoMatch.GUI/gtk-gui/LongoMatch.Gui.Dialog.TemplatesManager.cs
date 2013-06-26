
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Dialog
{
	public partial class TemplatesManager
	{
		private global::Gtk.HPaned hpaned1;
		private global::Gtk.VBox vbox2;
		private global::Gtk.TreeView treeview;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Button newbutton;
		private global::Gtk.Button deletebutton;
		private global::Gtk.Button savebutton;
		private global::Gtk.HBox templateditorbox;
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Dialog.TemplatesManager
			this.Name = "LongoMatch.Gui.Dialog.TemplatesManager";
			this.Title = global::Mono.Unix.Catalog.GetString ("Templates Manager");
			this.Icon = global::Stetic.IconLoader.LoadIcon (this, "longomatch", global::Gtk.IconSize.Dialog);
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Modal = true;
			this.Gravity = ((global::Gdk.Gravity)(5));
			this.SkipPagerHint = true;
			this.SkipTaskbarHint = true;
			// Internal child LongoMatch.Gui.Dialog.TemplatesManager.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hpaned1 = new global::Gtk.HPaned ();
			this.hpaned1.CanFocus = true;
			this.hpaned1.Name = "hpaned1";
			this.hpaned1.Position = 144;
			// Container child hpaned1.Gtk.Paned+PanedChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.treeview = new global::Gtk.TreeView ();
			this.treeview.CanFocus = true;
			this.treeview.Name = "treeview";
			this.vbox2.Add (this.treeview);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.treeview]));
			w2.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Homogeneous = true;
			// Container child hbox2.Gtk.Box+BoxChild
			this.newbutton = new global::Gtk.Button ();
			this.newbutton.TooltipMarkup = "Create a new template";
			this.newbutton.CanFocus = true;
			this.newbutton.Name = "newbutton";
			this.newbutton.UseUnderline = true;
			// Container child newbutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w3 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w4 = new global::Gtk.HBox ();
			w4.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w5 = new global::Gtk.Image ();
			w5.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-new", global::Gtk.IconSize.Button);
			w4.Add (w5);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w7 = new global::Gtk.Label ();
			w4.Add (w7);
			w3.Add (w4);
			this.newbutton.Add (w3);
			this.hbox2.Add (this.newbutton);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.newbutton]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.deletebutton = new global::Gtk.Button ();
			this.deletebutton.TooltipMarkup = "Delete this template";
			this.deletebutton.Sensitive = false;
			this.deletebutton.CanFocus = true;
			this.deletebutton.Name = "deletebutton";
			this.deletebutton.UseUnderline = true;
			// Container child deletebutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w12 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w13 = new global::Gtk.HBox ();
			w13.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w14 = new global::Gtk.Image ();
			w14.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-delete", global::Gtk.IconSize.Button);
			w13.Add (w14);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w16 = new global::Gtk.Label ();
			w13.Add (w16);
			w12.Add (w13);
			this.deletebutton.Add (w12);
			this.hbox2.Add (this.deletebutton);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.deletebutton]));
			w20.Position = 1;
			w20.Expand = false;
			w20.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.savebutton = new global::Gtk.Button ();
			this.savebutton.TooltipMarkup = "Save this template";
			this.savebutton.Sensitive = false;
			this.savebutton.CanFocus = true;
			this.savebutton.Name = "savebutton";
			this.savebutton.UseUnderline = true;
			// Container child savebutton.Gtk.Container+ContainerChild
			global::Gtk.Alignment w21 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			global::Gtk.HBox w22 = new global::Gtk.HBox ();
			w22.Spacing = 2;
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Image w23 = new global::Gtk.Image ();
			w23.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-save", global::Gtk.IconSize.Button);
			w22.Add (w23);
			// Container child GtkHBox.Gtk.Container+ContainerChild
			global::Gtk.Label w25 = new global::Gtk.Label ();
			w22.Add (w25);
			w21.Add (w22);
			this.savebutton.Add (w21);
			this.hbox2.Add (this.savebutton);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.savebutton]));
			w29.Position = 2;
			w29.Expand = false;
			w29.Fill = false;
			this.vbox2.Add (this.hbox2);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox2]));
			w30.Position = 1;
			w30.Expand = false;
			w30.Fill = false;
			this.hpaned1.Add (this.vbox2);
			global::Gtk.Paned.PanedChild w31 = ((global::Gtk.Paned.PanedChild)(this.hpaned1 [this.vbox2]));
			w31.Resize = false;
			// Container child hpaned1.Gtk.Paned+PanedChild
			this.templateditorbox = new global::Gtk.HBox ();
			this.templateditorbox.Name = "templateditorbox";
			this.templateditorbox.Spacing = 6;
			this.hpaned1.Add (this.templateditorbox);
			w1.Add (this.hpaned1);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(w1 [this.hpaned1]));
			w33.Position = 0;
			// Internal child LongoMatch.Gui.Dialog.TemplatesManager.ActionArea
			global::Gtk.HButtonBox w34 = this.ActionArea;
			w34.Name = "dialog1_ActionArea";
			w34.Spacing = 6;
			w34.BorderWidth = ((uint)(5));
			w34.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-quit";
			this.AddActionWidget (this.buttonOk, 0);
			global::Gtk.ButtonBox.ButtonBoxChild w35 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w34 [this.buttonOk]));
			w35.Expand = false;
			w35.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 866;
			this.DefaultHeight = 336;
			this.Show ();
			this.treeview.RowActivated += new global::Gtk.RowActivatedHandler (this.OnTreeviewRowActivated);
			this.treeview.CursorChanged += new global::System.EventHandler (this.OnTreeviewCursorChanged);
			this.newbutton.Clicked += new global::System.EventHandler (this.OnNewbuttonClicked);
			this.deletebutton.Clicked += new global::System.EventHandler (this.OnDeletebuttonClicked);
			this.savebutton.Clicked += new global::System.EventHandler (this.OnSavebuttonClicked);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonOkClicked);
		}
	}
}
