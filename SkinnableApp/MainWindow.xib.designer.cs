// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace SkinnableApp {


	// Should subclass MonoMac.AppKit.NSWindow
	[Foundation.Register("MainWindow")]
	public partial class MainWindow {
	}

	// Should subclass MonoMac.AppKit.NSWindowController
	[Foundation.Register("MainWindowController")]
	public partial class MainWindowController {

		private global::AppKit.NSPopUpButton __mt_themeChooser;

		private global::AppKit.NSTextField __mt_titleText;

		private global::WebKit.WebView __mt_webView;

		#pragma warning disable 0169
		[Foundation.Export("addContent:")]
		partial void addContent (AppKit.NSButton sender);

		[Foundation.Export("changeTheme:")]
		partial void changeTheme (AppKit.NSPopUpButton sender);

		[Foundation.Export("setTitle:")]
		partial void setTitle (AppKit.NSButton sender);

		[Foundation.Connect("themeChooser")]
		private global::AppKit.NSPopUpButton themeChooser {
			get {
				this.__mt_themeChooser = ((global::AppKit.NSPopUpButton)(this.GetNativeField("themeChooser")));
				return this.__mt_themeChooser;
			}
			set {
				this.__mt_themeChooser = value;
				this.SetNativeField("themeChooser", value);
			}
		}

		[Foundation.Connect("titleText")]
		private global::AppKit.NSTextField titleText {
			get {
				this.__mt_titleText = ((global::AppKit.NSTextField)(this.GetNativeField("titleText")));
				return this.__mt_titleText;
			}
			set {
				this.__mt_titleText = value;
				this.SetNativeField("titleText", value);
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
