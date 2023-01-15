using DemoApplication.Areas.Client.ViewModels.Basket;
using DemoApplication.Areas.Client.ViewModels.Home.Index;

namespace DemoApplication.Areas.Client.ViewModels.ShoppingCart
{
    public class ShoppingListViewModel
    {
        public ShoppingListViewModel(int id, string title, decimal price, int quantity, decimal total, string imageUrl)
        {
            Id = id;
            Title = title;
            Price = price;
            Quantity = quantity;
            Total = total;
            ImageUrl = ImageUrl;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
        public string ImageUrl { get; set; }
    }
}
