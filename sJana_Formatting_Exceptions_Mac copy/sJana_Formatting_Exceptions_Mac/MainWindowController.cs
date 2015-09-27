using System;

using Foundation;
using AppKit;

namespace sJana_Formatting_Exceptions_Mac
{
	public partial class MainWindowController : NSWindowController
	{
		public MainWindowController (IntPtr handle) : base (handle)
		{
		}

		[Export ("initWithCoder:")]
		public MainWindowController (NSCoder coder) : base (coder)
		{
		}

		public MainWindowController () : base ("MainWindow")
		{
		}

		public override void AwakeFromNib ()
		{
			base.AwakeFromNib ();
		}

		public new MainWindow Window {
			get { return (MainWindow)base.Window; }
		}
	}
}
