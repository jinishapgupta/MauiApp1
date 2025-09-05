using MauiApp1.Models;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;



namespace MauiApp1.ViewModels
{
    public class MainPageViewModel
    {
        public ObservableCollection<Product> Products { get; }
        public ICommand IncreaseQuantityCommand { get; }

        public MainPageViewModel()
        {
            Products = new ObservableCollection<Product>
            {
                new Product { Title = "Witbrood ", Price = 4.00m, Image = "sandwich1.png", Quantity = 0, RibbonColor = "#005FA6",BorderColor = "#CCCCCC"  },
                new Product { Title = "Witbrood volkoren", Price = 4.00m, Image = "sandwich2.png", Quantity = 0, RibbonColor = "#8BC34A",BorderColor = "#CCCCCC"  },
                new Product { Title = "Witbrood", Price = 4.00m, Image = "sandwich3.png", Quantity = 0, RibbonColor = "#005FA6",BorderColor = "#CCCCCC" },
                 new Product { Title = "Witbrood", Price = 4.00m, Image = "sandwich3.png", Quantity = 0, RibbonColor = "#005FA6",BorderColor = "#CCCCCC" },
                  new Product { Title = "Witbrood ", Price = 4.00m, Image = "sandwich1.png", Quantity = 0, RibbonColor = "#005FA6",BorderColor = "#CCCCCC"  },
                new Product { Title = "Witbrood volkoren", Price = 4.00m, Image = "sandwich2.png", Quantity = 0, RibbonColor = "#8BC34A",BorderColor = "#CCCCCC"  },
                new Product { Title = "Witbrood", Price = 4.00m, Image = "sandwich3.png", Quantity = 0, RibbonColor = "#005FA6",BorderColor = "#CCCCCC" },
                 new Product { Title = "Witbrood", Price = 4.00m, Image = "sandwich3.png", Quantity = 0, RibbonColor = "#005FA6",BorderColor = "#CCCCCC" },
                  new Product { Title = "Witbrood ", Price = 4.00m, Image = "sandwich1.png", Quantity = 0, RibbonColor = "#005FA6",BorderColor = "#CCCCCC"  },
                new Product { Title = "Witbrood volkoren", Price = 4.00m, Image = "sandwich2.png", Quantity = 0, RibbonColor = "#8BC34A",BorderColor = "#CCCCCC"  },
                new Product { Title = "Witbrood", Price = 4.00m, Image = "sandwich3.png", Quantity = 0, RibbonColor = "#005FA6",BorderColor = "#CCCCCC" },
                 new Product { Title = "Witbrood", Price = 4.00m, Image = "sandwich3.png", Quantity = 0, RibbonColor = "#005FA6",BorderColor = "#CCCCCC" }
            };

            IncreaseQuantityCommand = new Command<Product>(p =>
            {
                if (p != null)
                    p.Quantity++;
            });
        }
    }
}
