// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace sJana_Formatting_Exceptions_Mac
{
	[Register ("MainWindow")]
	partial class MainWindow
	{
		[Outlet]
		AppKit.NSView ClickedLabel { get; set; }

		[Outlet]
		AppKit.NSTextField SearchBox { get; set; }

		[Action ("Search:")]
		partial void Search (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (ClickedLabel != null) {
				ClickedLabel.Dispose ();
				ClickedLabel = null;
			}

			if (SearchBox != null) {
				SearchBox.Dispose ();
				SearchBox = null;
			}
		}
	}
}
