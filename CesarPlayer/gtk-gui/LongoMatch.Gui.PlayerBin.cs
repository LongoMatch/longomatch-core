// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.42
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace LongoMatch.Gui {
    
    
    public partial class PlayerBin {
        
        private Gtk.HBox mainbox;
        
        private Gtk.VBox vbox2;
        
        private Gtk.HBox videobox;
        
        private Gtk.HBox controlsbox;
        
        private Gtk.HBox buttonsbox;
        
        private Gtk.Button closebutton;
        
        private Gtk.Button playbutton;
        
        private Gtk.Button pausebutton;
        
        private Gtk.Button prevbutton;
        
        private Gtk.Button nextbutton;
        
        private Gtk.Label tlabel;
        
        private Gtk.HScale timescale;
        
        private Gtk.Label timelabel;
        
        private Gtk.Button volumebutton;
        
        private Gtk.VBox vbox3;
        
        private Gtk.VScale vscale1;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget LongoMatch.Gui.PlayerBin
            Stetic.BinContainer.Attach(this);
            this.Name = "LongoMatch.Gui.PlayerBin";
            // Container child LongoMatch.Gui.PlayerBin.Gtk.Container+ContainerChild
            this.mainbox = new Gtk.HBox();
            this.mainbox.Name = "mainbox";
            this.mainbox.Spacing = 6;
            // Container child mainbox.Gtk.Box+BoxChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            // Container child vbox2.Gtk.Box+BoxChild
            this.videobox = new Gtk.HBox();
            this.videobox.Name = "videobox";
            this.videobox.Spacing = 6;
            this.vbox2.Add(this.videobox);
            Gtk.Box.BoxChild w1 = ((Gtk.Box.BoxChild)(this.vbox2[this.videobox]));
            w1.Position = 0;
            // Container child vbox2.Gtk.Box+BoxChild
            this.controlsbox = new Gtk.HBox();
            this.controlsbox.Name = "controlsbox";
            this.controlsbox.Spacing = 6;
            // Container child controlsbox.Gtk.Box+BoxChild
            this.buttonsbox = new Gtk.HBox();
            this.buttonsbox.Name = "buttonsbox";
            this.buttonsbox.Homogeneous = true;
            // Container child buttonsbox.Gtk.Box+BoxChild
            this.closebutton = new Gtk.Button();
            this.closebutton.CanFocus = true;
            this.closebutton.Name = "closebutton";
            this.closebutton.UseUnderline = true;
            // Container child closebutton.Gtk.Container+ContainerChild
            Gtk.Alignment w2 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w3 = new Gtk.HBox();
            w3.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w4 = new Gtk.Image();
            w4.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-close", Gtk.IconSize.Dnd, 32);
            w3.Add(w4);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w6 = new Gtk.Label();
            w6.LabelProp = "";
            w3.Add(w6);
            w2.Add(w3);
            this.closebutton.Add(w2);
            this.buttonsbox.Add(this.closebutton);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(this.buttonsbox[this.closebutton]));
            w10.Position = 0;
            w10.Expand = false;
            w10.Fill = false;
            // Container child buttonsbox.Gtk.Box+BoxChild
            this.playbutton = new Gtk.Button();
            this.playbutton.CanFocus = true;
            this.playbutton.Name = "playbutton";
            this.playbutton.UseUnderline = true;
            this.playbutton.Relief = ((Gtk.ReliefStyle)(2));
            // Container child playbutton.Gtk.Container+ContainerChild
            Gtk.Alignment w11 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w12 = new Gtk.HBox();
            w12.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w13 = new Gtk.Image();
            w13.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-media-play", Gtk.IconSize.Button, 20);
            w12.Add(w13);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w15 = new Gtk.Label();
            w15.LabelProp = "";
            w12.Add(w15);
            w11.Add(w12);
            this.playbutton.Add(w11);
            this.buttonsbox.Add(this.playbutton);
            Gtk.Box.BoxChild w19 = ((Gtk.Box.BoxChild)(this.buttonsbox[this.playbutton]));
            w19.Position = 1;
            w19.Expand = false;
            w19.Fill = false;
            // Container child buttonsbox.Gtk.Box+BoxChild
            this.pausebutton = new Gtk.Button();
            this.pausebutton.CanFocus = true;
            this.pausebutton.Name = "pausebutton";
            this.pausebutton.UseUnderline = true;
            this.pausebutton.Relief = ((Gtk.ReliefStyle)(2));
            // Container child pausebutton.Gtk.Container+ContainerChild
            Gtk.Alignment w20 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w21 = new Gtk.HBox();
            w21.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w22 = new Gtk.Image();
            w22.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-media-pause", Gtk.IconSize.Button, 20);
            w21.Add(w22);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w24 = new Gtk.Label();
            w24.LabelProp = "";
            w21.Add(w24);
            w20.Add(w21);
            this.pausebutton.Add(w20);
            this.buttonsbox.Add(this.pausebutton);
            Gtk.Box.BoxChild w28 = ((Gtk.Box.BoxChild)(this.buttonsbox[this.pausebutton]));
            w28.Position = 2;
            w28.Expand = false;
            w28.Fill = false;
            // Container child buttonsbox.Gtk.Box+BoxChild
            this.prevbutton = new Gtk.Button();
            this.prevbutton.CanFocus = true;
            this.prevbutton.Name = "prevbutton";
            this.prevbutton.UseUnderline = true;
            this.prevbutton.Relief = ((Gtk.ReliefStyle)(2));
            // Container child prevbutton.Gtk.Container+ContainerChild
            Gtk.Alignment w29 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w30 = new Gtk.HBox();
            w30.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w31 = new Gtk.Image();
            w31.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-media-previous", Gtk.IconSize.Button, 20);
            w30.Add(w31);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w33 = new Gtk.Label();
            w33.LabelProp = "";
            w30.Add(w33);
            w29.Add(w30);
            this.prevbutton.Add(w29);
            this.buttonsbox.Add(this.prevbutton);
            Gtk.Box.BoxChild w37 = ((Gtk.Box.BoxChild)(this.buttonsbox[this.prevbutton]));
            w37.Position = 3;
            w37.Expand = false;
            w37.Fill = false;
            // Container child buttonsbox.Gtk.Box+BoxChild
            this.nextbutton = new Gtk.Button();
            this.nextbutton.Sensitive = false;
            this.nextbutton.CanFocus = true;
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.UseUnderline = true;
            this.nextbutton.Relief = ((Gtk.ReliefStyle)(2));
            // Container child nextbutton.Gtk.Container+ContainerChild
            Gtk.Alignment w38 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w39 = new Gtk.HBox();
            w39.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w40 = new Gtk.Image();
            w40.Pixbuf = Stetic.IconLoader.LoadIcon(this, "gtk-media-next", Gtk.IconSize.Button, 20);
            w39.Add(w40);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w42 = new Gtk.Label();
            w42.LabelProp = "";
            w39.Add(w42);
            w38.Add(w39);
            this.nextbutton.Add(w38);
            this.buttonsbox.Add(this.nextbutton);
            Gtk.Box.BoxChild w46 = ((Gtk.Box.BoxChild)(this.buttonsbox[this.nextbutton]));
            w46.Position = 4;
            w46.Expand = false;
            w46.Fill = false;
            this.controlsbox.Add(this.buttonsbox);
            Gtk.Box.BoxChild w47 = ((Gtk.Box.BoxChild)(this.controlsbox[this.buttonsbox]));
            w47.Position = 0;
            w47.Expand = false;
            w47.Fill = false;
            // Container child controlsbox.Gtk.Box+BoxChild
            this.tlabel = new Gtk.Label();
            this.tlabel.Name = "tlabel";
            this.tlabel.LabelProp = Mono.Unix.Catalog.GetString("Time:");
            this.controlsbox.Add(this.tlabel);
            Gtk.Box.BoxChild w48 = ((Gtk.Box.BoxChild)(this.controlsbox[this.tlabel]));
            w48.Position = 1;
            w48.Expand = false;
            w48.Fill = false;
            // Container child controlsbox.Gtk.Box+BoxChild
            this.timescale = new Gtk.HScale(null);
            this.timescale.CanFocus = true;
            this.timescale.Name = "timescale";
            this.timescale.UpdatePolicy = ((Gtk.UpdateType)(1));
            this.timescale.Adjustment.Upper = 65535;
            this.timescale.Adjustment.PageIncrement = 10;
            this.timescale.Adjustment.StepIncrement = 1;
            this.timescale.Adjustment.Value = 10;
            this.timescale.DrawValue = false;
            this.timescale.Digits = 0;
            this.timescale.ValuePos = ((Gtk.PositionType)(2));
            this.controlsbox.Add(this.timescale);
            Gtk.Box.BoxChild w49 = ((Gtk.Box.BoxChild)(this.controlsbox[this.timescale]));
            w49.Position = 2;
            // Container child controlsbox.Gtk.Box+BoxChild
            this.timelabel = new Gtk.Label();
            this.timelabel.Name = "timelabel";
            this.timelabel.LabelProp = "";
            this.controlsbox.Add(this.timelabel);
            Gtk.Box.BoxChild w50 = ((Gtk.Box.BoxChild)(this.controlsbox[this.timelabel]));
            w50.Position = 3;
            w50.Expand = false;
            // Container child controlsbox.Gtk.Box+BoxChild
            this.volumebutton = new Gtk.Button();
            this.volumebutton.CanFocus = true;
            this.volumebutton.Name = "volumebutton";
            this.volumebutton.UseUnderline = true;
            this.volumebutton.Relief = ((Gtk.ReliefStyle)(2));
            // Container child volumebutton.Gtk.Container+ContainerChild
            Gtk.Alignment w51 = new Gtk.Alignment(0.5F, 0.5F, 0F, 0F);
            // Container child GtkAlignment.Gtk.Container+ContainerChild
            Gtk.HBox w52 = new Gtk.HBox();
            w52.Spacing = 2;
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Image w53 = new Gtk.Image();
            w53.Pixbuf = Stetic.IconLoader.LoadIcon(this, "stock_volume", Gtk.IconSize.Button, 20);
            w52.Add(w53);
            // Container child GtkHBox.Gtk.Container+ContainerChild
            Gtk.Label w55 = new Gtk.Label();
            w55.LabelProp = "";
            w52.Add(w55);
            w51.Add(w52);
            this.volumebutton.Add(w51);
            this.controlsbox.Add(this.volumebutton);
            Gtk.Box.BoxChild w59 = ((Gtk.Box.BoxChild)(this.controlsbox[this.volumebutton]));
            w59.Position = 4;
            w59.Expand = false;
            w59.Fill = false;
            this.vbox2.Add(this.controlsbox);
            Gtk.Box.BoxChild w60 = ((Gtk.Box.BoxChild)(this.vbox2[this.controlsbox]));
            w60.Position = 1;
            w60.Expand = false;
            this.mainbox.Add(this.vbox2);
            Gtk.Box.BoxChild w61 = ((Gtk.Box.BoxChild)(this.mainbox[this.vbox2]));
            w61.Position = 0;
            // Container child mainbox.Gtk.Box+BoxChild
            this.vbox3 = new Gtk.VBox();
            this.vbox3.Name = "vbox3";
            this.vbox3.Spacing = 6;
            // Container child vbox3.Gtk.Box+BoxChild
            this.vscale1 = new Gtk.VScale(null);
            this.vscale1.WidthRequest = 45;
            this.vscale1.Sensitive = false;
            this.vscale1.CanFocus = true;
            this.vscale1.Name = "vscale1";
            this.vscale1.UpdatePolicy = ((Gtk.UpdateType)(1));
            this.vscale1.Inverted = true;
            this.vscale1.Adjustment.Lower = 1;
            this.vscale1.Adjustment.Upper = 28;
            this.vscale1.Adjustment.PageIncrement = 3;
            this.vscale1.Adjustment.PageSize = 1;
            this.vscale1.Adjustment.StepIncrement = 1;
            this.vscale1.Adjustment.Value = 25;
            this.vscale1.DrawValue = true;
            this.vscale1.Digits = 0;
            this.vscale1.ValuePos = ((Gtk.PositionType)(3));
            this.vbox3.Add(this.vscale1);
            Gtk.Box.BoxChild w62 = ((Gtk.Box.BoxChild)(this.vbox3[this.vscale1]));
            w62.Position = 0;
            this.mainbox.Add(this.vbox3);
            Gtk.Box.BoxChild w63 = ((Gtk.Box.BoxChild)(this.mainbox[this.vbox3]));
            w63.Position = 1;
            w63.Expand = false;
            w63.Fill = false;
            this.Add(this.mainbox);
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.closebutton.Hide();
            this.prevbutton.Hide();
            this.nextbutton.Hide();
            this.controlsbox.Hide();
            this.Show();
            this.closebutton.Clicked += new System.EventHandler(this.OnClosebuttonClicked);
            this.playbutton.Clicked += new System.EventHandler(this.OnPlaybuttonClicked);
            this.pausebutton.Clicked += new System.EventHandler(this.OnPausebuttonClicked);
            this.prevbutton.Clicked += new System.EventHandler(this.OnPrevbuttonClicked);
            this.nextbutton.Clicked += new System.EventHandler(this.OnNextbuttonClicked);
            this.timescale.ValueChanged += new System.EventHandler(this.OnTimescaleValueChanged);
            this.timescale.AdjustBounds += new Gtk.AdjustBoundsHandler(this.OnTimescaleAdjustBounds);
            this.volumebutton.Clicked += new System.EventHandler(this.OnVolumebuttonClicked);
            this.vscale1.FormatValue += new Gtk.FormatValueHandler(this.OnVscale1FormatValue);
            this.vscale1.ValueChanged += new System.EventHandler(this.OnVscale1ValueChanged);
        }
    }
}
