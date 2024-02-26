using GroceryStoreApp.ViewModel;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GroceryStoreApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InitialPage : ContentPage
    {
        public InitialPage()
        {
            InitializeComponent();
            BindingContext = new InitialPageViewModel();
        }
    }
}