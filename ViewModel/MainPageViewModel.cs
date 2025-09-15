using MauiApp1.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace MauiApp1.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        public ObservableCollection<Product> Products { get; }

        [ObservableProperty]
        private ObservableCollection<Product> filteredProducts;

        [ObservableProperty]
        private string selectedCategory = "All";

        public ObservableCollection<Category> Categories { get; } = new();

        public ICommand IncreaseQuantityCommand { get; }
        public ICommand FilterCommand { get; }

        public MainPageViewModel()
        {


            Categories = new ObservableCollection<Category>();
            Products = new ObservableCollection<Product>
            {
                new Product { Title = "Witbrood", Price = 4.00m, Image = "sandwich1.png", Quantity = 0, RibbonColor = null, Category="Witbrood" },
                new Product { Title = "Witbrood volkoren", Price = 4.00m, Image = "sandwich2.png", Quantity = 0, RibbonColor = "#8BC34A", Category="Witbrood volkoren" },
                new Product { Title = "Witbrood heel", Price = 4.00m, Image = "sandwich3.png", Quantity = 0, RibbonColor = "#005FA6", Category="Witbrood heel" },
                 new Product { Title = "Witbrood", Price = 4.00m, Image = "sandwich1.png", Quantity = 0, RibbonColor = "#005FA6", Category="Witbrood" },
                new Product { Title = "Volkoren", Price = 4.00m, Image = "sandwich2.png", Quantity = 0, RibbonColor = "#8BC34A", Category="Volkoren" },
                new Product { Title = "Witbrood heel", Price = 4.00m, Image = "sandwich3.png", Quantity = 0, RibbonColor = "#005FA6", Category="Witbrood heel" },
                 new Product { Title = "Witbrood", Price = 4.00m, Image = "sandwich1.png", Quantity = 0,  Category="Witbrood" },
                new Product { Title = "Witbrood volkoren", Price = 4.00m, Image = "sandwich2.png", Quantity = 0, Category="Witbrood volkoren" },
                new Product { Title = "Witbrood heel", Price = 4.00m, Image = "sandwich3.png", Quantity = 0, RibbonColor = "#005FA6", Category="Witbrood heel" },
                 new Product { Title = "Witbrood", Price = 4.00m, Image = "sandwich1.png", Quantity = 0, RibbonColor = "#005FA6", Category="Witbrood" },
                new Product { Title = "Glutenvrij", Price = 4.00m, Image = "sandwich2.png", Quantity = 0, RibbonColor = "#8BC34A", Category="Glutenvrij" },
                new Product { Title = "Witbrood heel", Price = 4.00m, Image = "sandwich3.png", Quantity = 0,  Category="Witbrood heel" },
                 new Product { Title = "Witbrood", Price = 4.00m, Image = "sandwich1.png", Quantity = 0, RibbonColor = "#005FA6", Category="Witbrood" },
                new Product { Title = "Volkoren", Price = 4.00m, Image = "sandwich2.png", Quantity = 0, RibbonColor = "#8BC34A", Category="Volkoren" },
                new Product { Title = "Witbrood heel", Price = 4.00m, Image = "sandwich3.png", Quantity = 0, RibbonColor = "#005FA6", Category="Witbrood heel" },
                 new Product { Title = "Witbrood", Price = 4.00m, Image = "sandwich1.png", Quantity = 0, RibbonColor = "#005FA6", Category="Witbrood" },
                new Product { Title = "Witbrood volkoren", Price = 4.00m, Image = "sandwich2.png", Quantity = 0, RibbonColor = "#8BC34A", Category="Witbrood volkoren" },
                new Product { Title = "Glutenvrij", Price = 4.00m, Image = "sandwich3.png", Quantity = 0, Category="Glutenvrij" },


            };
            var names = Products
            .Select(p => p.Category)
            .Where(c => !string.IsNullOrWhiteSpace(c))
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .OrderBy(c => c);

            Categories.Add(new Category { Name = "All", IsSelected = true });
            foreach (var n in names)
                Categories.Add(new Category { Name = n });

            FilteredProducts = new ObservableCollection<Product>(Products);

            IncreaseQuantityCommand = new Command<Product>(p =>
            {
                if (p != null)
                    p.Quantity++;
            });

            FilterCommand = new Command<string>(OnFilter);
            OnFilter(SelectedCategory);
        }

        private void OnFilter(string categoryName)
        {
            foreach (var c in Categories)
            {
                if (c.Name == categoryName)
                {
                    c.IsSelected = true;
                    c.BackgroundColor = Color.FromArgb("#8BC34A"); 
                    c.TextColor = Colors.Black;
                }
                else
                {
                    c.IsSelected = false;
                    c.BackgroundColor = Colors.White;
                    c.TextColor = Colors.Black;
                }
            }

            SelectedCategory = categoryName;

            if (string.IsNullOrEmpty(categoryName) || categoryName == "All")
                FilteredProducts = new ObservableCollection<Product>(Products);
            else
                FilteredProducts = new ObservableCollection<Product>(
                    Products.Where(p => p.Category == categoryName));
        }

    }
}
