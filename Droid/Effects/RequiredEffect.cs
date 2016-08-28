using System;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinFormsDemo.Droid;

[assembly: ResolutionGroupName ("XamFormsDemo")]
[assembly: ExportEffect (typeof (RequiredEffect), "RequiredEffect")]
namespace XamarinFormsDemo.Droid
{
	public class RequiredEffect : PlatformEffect
	{
		public RequiredEffect ()
		{
		}

		protected override void OnAttached ()
		{
			var label = Control as TextView;

			if (label != null) {
				label.SetTextColor (Android.Graphics.Color.Red);
				return;
			}

			var entry = Control as EditText;
			if (entry != null) {
				entry.SetBackgroundColor (Android.Graphics.Color.LightSalmon);
			}
		}

		protected override void OnDetached ()
		{
			throw new NotImplementedException ();
		}
	}
}

