using Foundation;
using System;
using UIKit;

namespace Issue3182
{
	public partial class MyViewController : UIViewController
	{
		public string LabelText { get; set; }
		
		public MyViewController (IntPtr handle) : base (handle)
		{
		}
		
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			Label.Text = LabelText;
		}
	}
}