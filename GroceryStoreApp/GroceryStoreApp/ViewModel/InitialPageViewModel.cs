using GroceryStoreApp.View;
using GroceryStoreApp.ViewModel.Base;
using System.Windows.Input;
using Xamarin.Forms;

namespace GroceryStoreApp.ViewModel
{
    public class InitialPageViewModel: BaseViewModel
    {
        public ICommand LogoTapped { get; set; }
        public InitialPageViewModel()
        {
            InitializeInfo();
            LogoTapped = new Command(LogoTappedExecute);
        }

        public void InitializeInfo() { }

        private async void LogoTappedExecute()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SignUpPage());
        }
    }

}
