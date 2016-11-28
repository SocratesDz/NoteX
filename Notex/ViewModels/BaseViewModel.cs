using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Notex
{
	public class BaseViewModel : INotifyPropertyChanged
	{
		public BaseViewModel()
		{
		}

		public event PropertyChangedEventHandler PropertyChanged;
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			if (PropertyChanged != null) 
			{
				PropertyChanged(this,
								new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
