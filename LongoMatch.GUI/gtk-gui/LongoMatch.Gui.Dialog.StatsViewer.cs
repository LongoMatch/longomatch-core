
// This file has been generated by the GUI designer. Do not modify.
namespace LongoMatch.Gui.Dialog
{
	public partial class StatsViewer
	{
		private global::Gtk.Notebook notebook1;
		private global::LongoMatch.Gui.Component.GameViewer gameviewer;
		private global::Gtk.Label label2;
		private global::LongoMatch.Gui.Component.Stats.CategoriesViewer categoriesviewer;
		private global::Gtk.Label label1;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget LongoMatch.Gui.Dialog.StatsViewer
			this.Name = "LongoMatch.Gui.Dialog.StatsViewer";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child LongoMatch.Gui.Dialog.StatsViewer.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 0;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.gameviewer = new global::LongoMatch.Gui.Component.GameViewer ();
			this.gameviewer.Events = ((global::Gdk.EventMask)(256));
			this.gameviewer.Name = "gameviewer";
			this.notebook1.Add (this.gameviewer);
			// Notebook tab
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Game stats");
			this.notebook1.SetTabLabel (this.gameviewer, this.label2);
			this.label2.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.categoriesviewer = new global::LongoMatch.Gui.Component.Stats.CategoriesViewer ();
			this.categoriesviewer.Events = ((global::Gdk.EventMask)(256));
			this.categoriesviewer.Name = "categoriesviewer";
			this.notebook1.Add (this.categoriesviewer);
			global::Gtk.Notebook.NotebookChild w3 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.categoriesviewer]));
			w3.Position = 1;
			// Notebook tab
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Categories stats");
			this.notebook1.SetTabLabel (this.categoriesviewer, this.label1);
			this.label1.ShowAll ();
			w1.Add (this.notebook1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(w1 [this.notebook1]));
			w4.Position = 0;
			// Internal child LongoMatch.Gui.Dialog.StatsViewer.ActionArea
			global::Gtk.HButtonBox w5 = this.ActionArea;
			w5.Name = "dialog1_ActionArea";
			w5.Spacing = 10;
			w5.BorderWidth = ((uint)(5));
			w5.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w6 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w5 [this.buttonCancel]));
			w6.Expand = false;
			w6.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w7 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w5 [this.buttonOk]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 1167;
			this.DefaultHeight = 619;
			this.Show ();
		}
	}
}
