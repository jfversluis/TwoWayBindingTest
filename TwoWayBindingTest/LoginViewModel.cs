using System;
using System.ComponentModel;

namespace TwoWayBindingTest
{
	public class LoginViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged = delegate { };

		private string _email;
		public string Email
		{
			get => _email;
			set
			{
				_email = value;
				PropertyChanged(this, new PropertyChangedEventArgs(nameof(Email)));
			}
		}
	}
}