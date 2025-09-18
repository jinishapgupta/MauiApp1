using MauiApp1.ViewModels;
using Microsoft.Maui.Controls;

namespace MauiApp1.Views;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageViewModel vm) 
    {
        InitializeComponent();
        BindingContext = vm;
    }

    private async void OnScrollLeftClicked(object? sender, EventArgs e)
    {
        // prevent negative scroll
        var newX = Math.Max(0, CategoryScroll.ScrollX - 400);
        await CategoryScroll.ScrollToAsync(newX, 0, true);
    }

    private async void OnScrollRightClicked(object sender, EventArgs e)
    {
        var newX = CategoryScroll.ScrollX + 400;
        await CategoryScroll.ScrollToAsync(newX, 0, true);
    }
}
