using MauiApp1.ViewModels;
using Microsoft.Maui.Controls;
namespace MauiApp1;


public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
   
}
