using Xamarin.Forms;

namespace XamarinFormsDemo
{
	public partial class XamarinFormsDemoPage : ContentPage
	{
		public XamarinFormsDemoPage ()
		{
			InitializeComponent ();

			BindingContext = new LoginViewModel (Navigation);
		}
	}
}

