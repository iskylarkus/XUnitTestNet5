using Moq;
using System.Collections.Generic;
using XUnitTestNet5.Web.Controllers;
using XUnitTestNet5.Web.Models;
using XUnitTestNet5.Web.Repository;

namespace XUnitTestNet5.Web.Test
{
    public class ProductApiControllerTest
    {
        private readonly Mock<IRepository<Product>> _mock;
        private readonly ProductsApiController _controller;
        private List<Product> _products;

        public ProductApiControllerTest()
        {
            _mock = new Mock<IRepository<Product>>();
            _controller = new ProductsApiController(_mock.Object);
            _products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Kalem", Color = "Kırmızı", Price = 11, Stock = 1111},
                new Product() { Id = 2, Name = "Silgi", Color = "Sarı", Price = 19, Stock = 1919},
            };
        }
    }
}
