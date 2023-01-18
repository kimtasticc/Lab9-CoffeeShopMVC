using Lab9CoffeeShopMVC.Models;

namespace Lab9CoffeeShopMVC
{
    public class ProductRepository
    {
        private List<ProductViewModel> _mockProducts;

        public ProductRepository()
        {
            CreateMockProductList();
        }

        private void CreateMockProductList()
        {
            _mockProducts = new List<ProductViewModel>();
            _mockProducts.Add(new ProductViewModel { Id = 1, Name = "Black Coffee", Description = "As basic as you can get. Add cream & sugar on your own time.", Price = 1.99, Category = "Drinks" });
            _mockProducts.Add(new ProductViewModel { Id = 2, Name = "Iced Tea", Description = "Choose between green or black tea. Fresh brewed.", Price = 1.50, Category = "Drinks" });
            _mockProducts.Add(new ProductViewModel { Id = 3, Name = "Bagel", Description = "Choose between plain or asiago. Complimentary cream cheese on the side.", Price = 2.75, Category = "Food" });
            _mockProducts.Add(new ProductViewModel { Id = 4, Name = "Ham & Cheese Croissant", Description = "Served warm.", Price = 3.00, Category = "Food" });
            _mockProducts.Add(new ProductViewModel { Id = 5, Name = "Travel Thermos", Description = "Black with our shop's logo. 32oz.", Price = 19.99, Category = "Merchandise" });
            _mockProducts.Add(new ProductViewModel { Id = 6, Name = "Coffee Mug", Description = "Available in white or dark green with our shop's logo.", Price = 12.75, Category = "Merchandise" });
        }

        public IEnumerable<ProductViewModel> GetMockProducts()
        {
            return _mockProducts;
        }
    }
}
