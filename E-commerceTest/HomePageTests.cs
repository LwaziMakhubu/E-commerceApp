using Microsoft.VisualStudio.TestTools.UnitTesting;
using ECommerceApp.Controllers;
using ECommerceApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ECommerceApp.Models;

namespace ECommerceApp.Tests
{
    [TestClass]
    public class HomePageTests
    {
        [TestMethod]
        public void Test_Products_Displayed_On_HomePage()
        {
            // Arrange
            var productService = new ProductService();
            var homeController = new HomeController();

            // Act
            var result = homeController.Index(null) as ViewResult;
            var model = result?.Model as List<Product>;

            // Assert
            Assert.IsNotNull(model);
            Assert.IsTrue(model.Count > 0);
        }

        [TestMethod]
        public void Test_Products_Filtered_By_Category()
        {
            // Arrange
            var productService = new ProductService();
            var homeController = new HomeController();

            // Act
            var result = homeController.Index("Electronics") as ViewResult;
            var model = result?.Model as List<Product>;

            // Assert
            Assert.IsNotNull(model);
            Assert.IsTrue(model.Count > 0);
            Assert.IsTrue(model.All(p => p.Category == "Electronics"));
        }
    }
}
