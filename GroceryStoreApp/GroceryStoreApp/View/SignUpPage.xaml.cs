using GroceryStoreApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GroceryStoreApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
            BindingContext = new SignUpPageViewModel();
        }
    }
}