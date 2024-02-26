using GroceryStoreApp.ViewModel;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GroceryStoreApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {   
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomePageViewModel();
        }
    }
    
}