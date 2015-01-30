// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

#if OSTYPE_OS_X
namespace LongoMatch {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class GtkOSXApplication : GLib.Object {

		[Obsolete]
		protected GtkOSXApplication(GLib.GType gtype) : base(gtype) {}
		public GtkOSXApplication(IntPtr raw) : base(raw) {}

		public GtkOSXApplication() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.CDeclCallback]
		delegate void NSApplicationWillResignActiveVMDelegate (IntPtr inst);

		static NSApplicationWillResignActiveVMDelegate NSApplicationWillResignActiveVMCallback;

		static void nsapplicationwillresignactive_cb (IntPtr inst)
		{
			try {
				GtkOSXApplication inst_managed = GLib.Object.GetObject (inst, false) as GtkOSXApplication;
				inst_managed.OnNSApplicationWillResignActive ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideNSApplicationWillResignActive (GLib.GType gtype)
		{
			if (NSApplicationWillResignActiveVMCallback == null)
				NSApplicationWillResignActiveVMCallback = new NSApplicationWillResignActiveVMDelegate (nsapplicationwillresignactive_cb);
			OverrideVirtualMethod (gtype, "NSApplicationWillResignActive", NSApplicationWillResignActiveVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(LongoMatch.GtkOSXApplication), ConnectionMethod="OverrideNSApplicationWillResignActive")]
		protected virtual void OnNSApplicationWillResignActive ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("NSApplicationWillResignActive")]
		public event System.EventHandler NSApplicationWillResignActive {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "NSApplicationWillResignActive");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "NSApplicationWillResignActive");
				sig.RemoveDelegate (value);
			}
		}

		[GLib.CDeclCallback]
		delegate void NSApplicationDidBecomeActiveVMDelegate (IntPtr inst);

		static NSApplicationDidBecomeActiveVMDelegate NSApplicationDidBecomeActiveVMCallback;

		static void nsapplicationdidbecomeactive_cb (IntPtr inst)
		{
			try {
				GtkOSXApplication inst_managed = GLib.Object.GetObject (inst, false) as GtkOSXApplication;
				inst_managed.OnNSApplicationDidBecomeActive ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideNSApplicationDidBecomeActive (GLib.GType gtype)
		{
			if (NSApplicationDidBecomeActiveVMCallback == null)
				NSApplicationDidBecomeActiveVMCallback = new NSApplicationDidBecomeActiveVMDelegate (nsapplicationdidbecomeactive_cb);
			OverrideVirtualMethod (gtype, "NSApplicationDidBecomeActive", NSApplicationDidBecomeActiveVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(LongoMatch.GtkOSXApplication), ConnectionMethod="OverrideNSApplicationDidBecomeActive")]
		protected virtual void OnNSApplicationDidBecomeActive ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("NSApplicationDidBecomeActive")]
		public event System.EventHandler NSApplicationDidBecomeActive {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "NSApplicationDidBecomeActive");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "NSApplicationDidBecomeActive");
				sig.RemoveDelegate (value);
			}
		}

		[GLib.CDeclCallback]
		delegate bool NSApplicationOpenFileVMDelegate (IntPtr inst, IntPtr p0);

		static NSApplicationOpenFileVMDelegate NSApplicationOpenFileVMCallback;

		static bool nsapplicationopenfile_cb (IntPtr inst, IntPtr p0)
		{
			try {
				GtkOSXApplication inst_managed = GLib.Object.GetObject (inst, false) as GtkOSXApplication;
				return inst_managed.OnNSApplicationOpenFile (GLib.Marshaller.PtrToStringGFree(p0));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call doesn't return
				throw e;
			}
		}

		private static void OverrideNSApplicationOpenFile (GLib.GType gtype)
		{
			if (NSApplicationOpenFileVMCallback == null)
				NSApplicationOpenFileVMCallback = new NSApplicationOpenFileVMDelegate (nsapplicationopenfile_cb);
			OverrideVirtualMethod (gtype, "NSApplicationOpenFile", NSApplicationOpenFileVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(LongoMatch.GtkOSXApplication), ConnectionMethod="OverrideNSApplicationOpenFile")]
		protected virtual bool OnNSApplicationOpenFile (string p0)
		{
			GLib.Value ret = new GLib.Value (GLib.GType.Boolean);
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (p0);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
			bool result = (bool) ret;
			ret.Dispose ();
			return result;
		}

		[GLib.Signal("NSApplicationOpenFile")]
		public event NSApplicationOpenFileHandler NSApplicationOpenFile {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "NSApplicationOpenFile", typeof (LongoMatch.NSApplicationOpenFileArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "NSApplicationOpenFile", typeof (LongoMatch.NSApplicationOpenFileArgs));
				sig.RemoveDelegate (value);
			}
		}

		[GLib.CDeclCallback]
		delegate void NSApplicationWillTerminateVMDelegate (IntPtr inst);

		static NSApplicationWillTerminateVMDelegate NSApplicationWillTerminateVMCallback;

		static void nsapplicationwillterminate_cb (IntPtr inst)
		{
			try {
				GtkOSXApplication inst_managed = GLib.Object.GetObject (inst, false) as GtkOSXApplication;
				inst_managed.OnNSApplicationWillTerminate ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideNSApplicationWillTerminate (GLib.GType gtype)
		{
			if (NSApplicationWillTerminateVMCallback == null)
				NSApplicationWillTerminateVMCallback = new NSApplicationWillTerminateVMDelegate (nsapplicationwillterminate_cb);
			OverrideVirtualMethod (gtype, "NSApplicationWillTerminate", NSApplicationWillTerminateVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(LongoMatch.GtkOSXApplication), ConnectionMethod="OverrideNSApplicationWillTerminate")]
		protected virtual void OnNSApplicationWillTerminate ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[GLib.Signal("NSApplicationWillTerminate")]
		public event System.EventHandler NSApplicationWillTerminate {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "NSApplicationWillTerminate");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "NSApplicationWillTerminate");
				sig.RemoveDelegate (value);
			}
		}

		[GLib.CDeclCallback]
		delegate bool NSApplicationBlockTerminationVMDelegate (IntPtr inst);

		static NSApplicationBlockTerminationVMDelegate NSApplicationBlockTerminationVMCallback;

		static bool nsapplicationblocktermination_cb (IntPtr inst)
		{
			try {
				GtkOSXApplication inst_managed = GLib.Object.GetObject (inst, false) as GtkOSXApplication;
				return inst_managed.OnNSApplicationBlockTermination ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, true);
				// NOTREACHED: above call doesn't return
				throw e;
			}
		}

		private static void OverrideNSApplicationBlockTermination (GLib.GType gtype)
		{
			if (NSApplicationBlockTerminationVMCallback == null)
				NSApplicationBlockTerminationVMCallback = new NSApplicationBlockTerminationVMDelegate (nsapplicationblocktermination_cb);
			OverrideVirtualMethod (gtype, "NSApplicationBlockTermination", NSApplicationBlockTerminationVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(LongoMatch.GtkOSXApplication), ConnectionMethod="OverrideNSApplicationBlockTermination")]
		protected virtual bool OnNSApplicationBlockTermination ()
		{
			GLib.Value ret = new GLib.Value (GLib.GType.Boolean);
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
			bool result = (bool) ret;
			ret.Dispose ();
			return result;
		}

		[GLib.Signal("NSApplicationBlockTermination")]
		public event NSApplicationBlockTerminationHandler NSApplicationBlockTermination {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "NSApplicationBlockTermination", typeof (LongoMatch.NSApplicationBlockTerminationArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "NSApplicationBlockTermination", typeof (LongoMatch.NSApplicationBlockTerminationArgs));
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("libgtkmacintegration.0.dylib")]
		static extern void gtk_osxapplication_ready(IntPtr raw);

		public void Ready() {
			gtk_osxapplication_ready(Handle);
		}
			
		[DllImport("libgtkmacintegration.0.dylib")]
		static extern void gtk_osxapplication_set_dock_icon_resource(IntPtr raw, IntPtr name, IntPtr type, IntPtr subdir);

		public void SetDockIconResource(string name, string type, string subdir) {
			IntPtr native_name = GLib.Marshaller.StringToPtrGStrdup (name);
			IntPtr native_type = GLib.Marshaller.StringToPtrGStrdup (type);
			IntPtr native_subdir = GLib.Marshaller.StringToPtrGStrdup (subdir);
			gtk_osxapplication_set_dock_icon_resource(Handle, native_name, native_type, native_subdir);
			GLib.Marshaller.Free (native_name);
			GLib.Marshaller.Free (native_type);
			GLib.Marshaller.Free (native_subdir);
		}

		[DllImport("libgtkmacintegration.0.dylib")]
		static extern int gtk_osxapplication_attention_request(IntPtr raw, int type);

		public int AttentionRequest(GtkOSXApplicationAttentionType type) {
			int raw_ret = gtk_osxapplication_attention_request(Handle, (int) type);
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libgtkmacintegration.0.dylib")]
		static extern void gtk_osxapplication_cancel_attention_request(IntPtr raw, int id);

		public void CancelAttentionRequest(int id) {
			gtk_osxapplication_cancel_attention_request(Handle, id);
		}

		[DllImport("libgtkmacintegration.0.dylib")]
		static extern void gtk_osxapplication_sync_menubar(IntPtr raw);

		public void SyncMenubar() {
			gtk_osxapplication_sync_menubar(Handle);
		}

		[DllImport("libgtkmacintegration.0.dylib")]
		static extern void gtk_osxapplication_set_menu_bar(IntPtr raw, IntPtr menu);

		public void SetMenuBar (Gtk.MenuShell menu) {
			gtk_osxapplication_set_menu_bar (Handle, menu.Handle);
		}

		[DllImport("libgtkmacintegration.0.dylib")]
		static extern void gtk_osxapplication_insert_app_menu_item(IntPtr raw, IntPtr menu, int index);

		public void InsertAppMenuItem (Gtk.MenuItem menu, int index) {
			gtk_osxapplication_insert_app_menu_item (Handle, menu.Handle, index);
		}

		[DllImport("libgtkmacintegration.0.dylib")]
		static extern void gtk_osxapplication_set_use_quartz_accelerators(IntPtr raw, bool use_quartz_accelerators);
		[DllImport("libgtkmacintegration.0.dylib")]
		static extern bool gtk_osxapplication_use_quartz_accelerators(IntPtr raw);

		public bool UseQuartzAccelerators { 
			set {
				gtk_osxapplication_set_use_quartz_accelerators(Handle, value);
			}
			get {
				bool raw_ret = gtk_osxapplication_use_quartz_accelerators(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("libgtkmacintegration.0.dylib")]
		static extern IntPtr gtk_osxapplication_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_osxapplication_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgtkmacintegration.0.dylib")]
		static extern void gtk_osxapplication_cleanup(IntPtr raw);

		public void Cleanup() {
			gtk_osxapplication_cleanup(Handle);
		}

		static bool initialized = false;
		static GtkOSXApplication ()
		{
			if (initialized)
				return;
			GLib.GType.Register (GtkOSXApplication.GType, typeof (GtkOSXApplication));
			initialized = true;
		}
#endregion
	}

	public delegate void NSApplicationOpenFileHandler(object o, NSApplicationOpenFileArgs args);
	public class NSApplicationOpenFileArgs : GLib.SignalArgs {
		public string P0{
			get {
				return (string) Args [0];
			}
		}
	}

	public delegate void NSApplicationBlockTerminationHandler(object o, NSApplicationBlockTerminationArgs args);
	public class NSApplicationBlockTerminationArgs : GLib.SignalArgs {}

	public class GtkMacAttentionRequest : GLib.Opaque {
		public GtkMacAttentionRequest(IntPtr raw) : base(raw) {}
	}

	public enum GtkOSXApplicationAttentionType {
		CriticalRequest = 0,
		InfoRequest = 10,
	}
}
#endif