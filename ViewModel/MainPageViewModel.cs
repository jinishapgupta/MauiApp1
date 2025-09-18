using MauiApp1.Models;
using MauiApp1.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace MauiApp1.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        private readonly IProductService _productService;

        public ObservableCollection<Product> Products { get; }

        [ObservableProperty]
        private ObservableCollection<Product> filteredProducts;

        [ObservableProperty]
        private string selectedCategory = "All";

        public ObservableCollection<Category> Categories { get; } = new();

        public ICommand IncreaseQuantityCommand { get; }
        public ICommand FilterCommand { get; }

        public MainPageViewModel(IProductService productService)
        {
            _productService = productService;

           
            Products = new ObservableCollection<Product>(_productService.GetProducts());

            
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
