using System;
using System.Windows.Input;

namespace MedicomPrototype.Commands
{
	public class NavigateToSettingsCommand : ICommand
	{
		public event EventHandler CanExecuteChanged;

		public bool CanExecute(object parameter)
		{
			return true;
		}

		public void RaiseCanExecuteChanged()
		{
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

		public void Execute(object parameter)
		{
			NavigateAsync();
		}

		private async void NavigateAsync()
		{
			await App.Current.MainPage.Navigation.PushAsync(new Views.SettingsPage(), true);
		}
	}
}
