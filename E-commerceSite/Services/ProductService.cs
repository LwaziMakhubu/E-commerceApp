using ECommerceApp.Models;
using System.Collections.Generic;

namespace ECommerceApp.Services
{
    public class ProductService
    {
        public List<Product> GetProducts(string category = null)
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 999.99m, Description = "High performance laptop", Category = "Electronics", ImageUrl = "https://via.placeholder.com/150" },
                new Product { Id = 2, Name = "Smartphone", Price = 499.99m, Description = "Latest model smartphone", Category = "Electronics", ImageUrl = "https://via.placeholder.com/150" },
                new Product { Id = 3, Name = "Headphones", Price = 199.99m, Description = "Noise cancelling headphones", Category = "Electronics", ImageUrl = "https://via.placeholder.com/150" },
                new Product { Id = 4, Name = "Desk Chair", Price = 149.99m, Description = "Ergonomic desk chair", Category = "Furniture", ImageUrl = "https://via.placeholder.com/150" },
                new Product { Id = 5, Name = "Coffee Table", Price = 89.99m, Description = "Modern coffee table", Category = "Furniture", ImageUrl = "https://via.placeholder.com/150" },
                new Product { Id = 6, Name = "Blender", Price = 59.99m, Description = "High-speed blender", Category = "Home Appliances", ImageUrl = "https://via.placeholder.com/150" },
                new Product { Id = 7, Name = "Toaster", Price = 29.99m, Description = "2-slice toaster", Category = "Home Appliances", ImageUrl = "https://via.placeholder.com/150" },
                new Product { Id = 8, Name = "Gaming Console", Price = 399.99m, Description = "Next-gen gaming console", Category = "Electronics", ImageUrl = "https://via.placeholder.com/150" },
                new Product { Id = 9, Name = "Monitor", Price = 199.99m, Description = "24-inch LED monitor", Category = "Electronics", ImageUrl = "https://via.placeholder.com/150" },
                new Product { Id = 10, Name = "Bookshelf", Price = 79.99m, Description = "5-tier bookshelf", Category = "Furniture", ImageUrl = "https://via.placeholder.com/150" },
                new Product { Id = 11, Name = "Microwave", Price = 89.99m, Description = "700W microwave oven", Category = "Home Appliances", ImageUrl = "https://via.placeholder.com/150" },
                new Product { Id = 12, Name = "Refrigerator", Price = 599.99m, Description = "Double-door refrigerator", Category = "Home Appliances", ImageUrl = "https://via.placeholder.com/150" },
                new Product { Id = 13, Name = "Washing Machine", Price = 399.99m, Description = "Front-load washing machine", Category = "Home Appliances", ImageUrl = "https://via.placeholder.com/150" }
            };

            if (!string.IsNullOrEmpty(category))
            {
                products = products.FindAll(p => p.Category == category);
            }

            return products;
        }
    }
}
