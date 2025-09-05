using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp1.Models
{
    public partial class Product : ObservableObject
    {
        [ObservableProperty]
        string? title;

        [ObservableProperty]
        decimal price;

        [ObservableProperty]
        string? image;

        [ObservableProperty]
        int quantity;

        [ObservableProperty]
        string? ribbonColor;

        [ObservableProperty]
        string? borderColor = "#CCCCCC";
    }
}
