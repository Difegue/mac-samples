// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace WhereIsMyMac {
	
	
	// Should subclass MonoMac.AppKit.NSWindow
	[Foundation.Register("MainWindow")]
	public partial class MainWindow {
	}
	
	// Should subclass MonoMac.AppKit.NSWindowController
	[Foundation.Register("MainWindowController")]
	public partial class MainWindowController {
		
		private global::AppKit.NSTextField __mt_accuracyLabel;
		
		private global::AppKit.NSTextField __mt_locationLabel;
		
		private global::WebKit.WebView __mt_webView;
		
		#pragma warning disable 0169
		[Foundation.Export("openInDefaultBrowser:")]
		partial void openInDefaultBrowser (AppKit.NSButton sender);

		[Foundation.Connect("accuracyLabel")]
		private global::AppKit.NSTextField accuracyLabel {
			get {
				this.__mt_accuracyLabel = ((global::AppKit.NSTextField)(this.GetNativeField("accuracyLabel")));
				return this.__mt_accuracyLabel;
			}
			set {
				this.__mt_accuracyLabel = value;
				this.SetNativeField("accuracyLabel", value);
			}
		}
		
		[Foundation.Connect("locationLabel")]
		private global::AppKit.NSTextField locationLabel {
			get {
				this.__mt_locationLabel = ((global::AppKit.NSTextField)(this.GetNativeField("locationLabel")));
				return this.__mt_locationLabel;
			}
			set {
				this.__mt_locationLabel = value;
				this.SetNativeField("locationLabel", value);
			}
		}
		
		[Foundation.Connect("webView")]
		private global::WebKit.WebView webView {
			get {
				this.__mt_webView = ((global::WebKit.WebView)(this.GetNativeField("webView")));
				return this.__mt_webView;
			}
			set {
				this.__mt_webView = value;
				this.SetNativeField("webView", value);
			}
		}
	}
}
