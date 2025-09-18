using MauiApp1.Models;

namespace MauiApp1.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
    }

    public class ProductService : IProductService
    {
        public IEnumerable<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product { Title = "Witbrood", Price = 4.00m, Image = "sandwich1.png", Quantity = 0, RibbonColor = null, Category="Witbrood" },
                new Product { Title = "Witbrood volkoren", Price = 4.00m, Image = "sandwich2.png", Quantity = 0, RibbonColor = "#8BC34A", Category="Witbrood volkoren" },
                new Product { Title = "Witbrood heel", Price = 4.00m, Image = "sandwich3.png", Quantity = 0, RibbonColor = "#005FA6", Category="Witbrood heel" },
                new Product { Title = "Volkoren", Price = 4.00m, Image = "sandwich2.png", Quantity = 0, RibbonColor = "#8BC34A", Category="Volkoren" },
                new Product { Title = "Glutenvrij", Price = 4.00m, Image = "sandwich3.png", Quantity = 0, RibbonColor = "#8BC34A", Category="Glutenvrij" },
                  new Product { Title = "Witbrood heel", Price = 4.00m, Image = "sandwich3.png", Quantity = 0, RibbonColor = "#005FA6", Category="Witbrood heel" },
                new Product { Title = "Volkoren", Price = 4.00m, Image = "sandwich2.png", Quantity = 0, RibbonColor = "#8BC34A", Category="Volkoren" },
                new Product { Title = "Glutenvrij", Price = 4.00m, Image = "sandwich3.png", Quantity = 0, RibbonColor = "#8BC34A", Category="Glutenvrij" },
                  new Product { Title = "Witbrood heel", Price = 4.00m, Image = "sandwich3.png", Quantity = 0, RibbonColor =null, Category="Witbrood heel" },
                new Product { Title = "Volkoren", Price = 4.00m, Image = "sandwich2.png", Quantity = 0, RibbonColor = "#8BC34A", Category="Volkoren" },
                new Product { Title = "Glutenvrij", Price = 4.00m, Image = "sandwich3.png", Quantity = 0, RibbonColor = "#8BC34A", Category="Glutenvrij" },
                  new Product { Title = "Witbrood heel", Price = 4.00m, Image = "sandwich3.png", Quantity = 0, RibbonColor = "#005FA6", Category="Witbrood heel" },
                new Product { Title = "Volkoren", Price = 4.00m, Image = "sandwich2.png", Quantity = 0, RibbonColor = "#8BC34A", Category="Volkoren" },
                new Product { Title = "Glutenvrij", Price = 4.00m, Image = "sandwich3.png", Quantity = 0, RibbonColor = "#8BC34A", Category="Glutenvrij" },
                  new Product { Title = "Witbrood heel", Price = 4.00m, Image = "sandwich3.png", Quantity = 0, RibbonColor =null, Category="Witbrood heel" },
                new Product { Title = "Volkoren", Price = 4.00m, Image = "sandwich2.png", Quantity = 0, RibbonColor = "#8BC34A", Category="Volkoren" },
                new Product { Title = "Glutenvrij", Price = 4.00m, Image = "sandwich3.png", Quantity = 0, RibbonColor = "#8BC34A", Category="Glutenvrij" }
            };
        }
    }
}
