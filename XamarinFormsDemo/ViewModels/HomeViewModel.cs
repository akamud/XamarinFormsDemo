using System;
using System.ComponentModel;
using Plugin.Settings;

namespace XamarinFormsDemo
{
	public class HomeViewModel : INotifyPropertyChanged
	{
		//private string _email;

		//public string Email {
		//	get {
		//		return _email;
		//	}
		//	set {
		//		if (_email != value) {
		//			_email = value;
		//			OnPropertyChanged (nameof(Email));
		//		}
		//	}
		//}

		public HomeViewModel ()
		{
			//Email = CrossSettings.Current.GetValueOrDefault<string>("Email");
		}

		public event PropertyChangedEventHandler PropertyChanged;

		void OnPropertyChanged (string propertyName)
		{
			var changed = PropertyChanged;
			if (changed != null) {
				PropertyChanged (this, new PropertyChangedEventArgs (propertyName));
			}
		}
	}
}

