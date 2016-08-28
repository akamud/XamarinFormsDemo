using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinFormsDemo
{
	public class LoginViewModel
	{
		private INavigation navigation;

		public LoginViewModel (INavigation navigation)
		{
			this.navigation = navigation;
		}

		ICommand _loginCommand;
		public ICommand LoginCommand
		=> _loginCommand ?? (_loginCommand = new Command (async () => await ExecuteLoginAsync ()));

		private async Task ExecuteLoginAsync ()
		{
			await navigation.PushAsync (new HomePage ());
		}
	}
}

