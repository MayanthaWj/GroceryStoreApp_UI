using GroceryStoreApp.View;
using GroceryStoreApp.ViewModel.Base;
using System.Windows.Input;
using Xamarin.Forms;

namespace GroceryStoreApp.ViewModel
{
    public class SignUpPageViewModel: BaseViewModel
    {
        public ICommand LoginButtonTapped { get; set; }
        public SignUpPageViewModel()
        {
            InitializeInfo();
            LoginButtonTapped = new Command(LoginThappedExecute);
        }
        public void InitializeInfo() { }

        private async void LoginThappedExecute()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new HomePage());
        }

    }
}
