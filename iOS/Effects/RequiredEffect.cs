using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinFormsDemo.iOS;

[assembly: ResolutionGroupName ("XamFormsDemo")]
[assembly: ExportEffect (typeof (RequiredEffect), "RequiredEffect")]
namespace XamarinFormsDemo.iOS
{
	public class RequiredEffect : PlatformEffect
	{
		protected override void OnAttached ()
		{
			var label = Control as UIKit.UILabel;

			if (label != null) {
				label.TextColor = UIKit.UIColor.Red;
				return;
			}

			var text = Control as UIKit.UITextField;

			if (text != null) {
				text.BackgroundColor = UIColor.FromRGBA(1f, 0f, 0f, 0.2f);
			}
		}

		protected override void OnDetached ()
		{
			throw new NotImplementedException ();
		}
	}
}

