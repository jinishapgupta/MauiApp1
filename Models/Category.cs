using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp1.Models
{
    public partial class Category : ObservableObject
    {
        [ObservableProperty]
        private string? name;

        [ObservableProperty]
        private bool isSelected;

        [ObservableProperty]
        private Color backgroundColor = Colors.White;

        [ObservableProperty]
        private Color textColor = Colors.Black;
    }
}
