using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Plugin.Settings;
using Xamarin.Forms;

namespace XamarinFormsDemo
{
	public class LoginViewModel : INotifyPropertyChanged
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
			CrossSettings.Current.AddOrUpdateValue ("Email", Email);

			await navigation.PushAsync (new HomePage ());
		}


		#region binding
		private string email;

		public string Email {
			get {
				return email;
			}
			set {
				if (email != value) {
					email = value;
					OnPropertyChanged (nameof (Email));
				}
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		void OnPropertyChanged (string propertyName)
		{
			var changed = PropertyChanged;
			if (changed != null) {
				PropertyChanged (this, new PropertyChangedEventArgs (propertyName));
			}
		}
		#endregion
	}
}

