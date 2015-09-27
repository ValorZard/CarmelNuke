using System;

using Foundation;
using AppKit;
using System.Collections.Generic;
namespace sJana_Formatting_Exceptions_Mac
{
	public partial class MainWindow : NSWindow
	{
		public List<Food> orderList = new List<Food>();
		private Food yum = new Food();
		public MainWindow (IntPtr handle) : base (handle)
		{
		}

		[Export ("initWithCoder:")]
		public MainWindow (NSCoder coder) : base (coder)
		{
		}


		public override void AwakeFromNib ()
		{
			base.AwakeFromNib ();

			// Set the initial value for the label

		}
		partial void Search (Foundation.NSObject sender)
		{
			 string foodItem = SearchBox.StringValue;
			foreach( Food Foody in yum.getMenuy()){
				if(Foody.Name == foodItem){
					orderList.Add(Foody);
				}
			}

		}


	}
}
