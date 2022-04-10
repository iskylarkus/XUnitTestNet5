using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using System.Linq;
using Xunit;
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

        [Fact]
        public async void GetProducts_ActionExecutes_ReturnOkResultWithProduct()
        {
            _mock.Setup(x => x.GetAll()).ReturnsAsync(_products);

            var result = await _controller.GetProducts();

            var okResult = Assert.IsType<OkObjectResult>(result);

            var returnProducts = Assert.IsAssignableFrom<IEnumerable<Product>>(okResult.Value);

            Assert.Equal<int>(2, returnProducts.ToList().Count);
        }

        [Theory]
        [InlineData(0)]
        public async void GetProduct_IdInValid_ReturnNotFound(int productId)
        {
            Product product = null;

            _mock.Setup(x => x.GetById(productId)).ReturnsAsync(product);

            var result = await _controller.GetProduct(productId);

            Assert.IsType<NotFoundResult>(result);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public async void GetProduct_IdValid_ReturnOkObjectResult(int productId)
        {
            var product = _products.Find(x => x.Id == productId);

            _mock.Setup(x => x.GetById(productId)).ReturnsAsync(product);

            var result = await _controller.GetProduct(productId);

            var okResult = Assert.IsType<OkObjectResult>(result);

            var returnProduct = Assert.IsType<Product>(okResult.Value);

            Assert.Equal(productId, returnProduct.Id);
            Assert.Equal(product.Name, returnProduct.Name);
        }

        [Theory]
        [InlineData(1)]
        public void PutProduct_IdIsNotEqualProduct_ReturnBadRequestResult(int productId)
        {
            var product = _products.First(x => x.Id == productId);

            var result = _controller.PutProduct(2, product);

            Assert.IsType<BadRequestResult>(result);
        }
    }
}
