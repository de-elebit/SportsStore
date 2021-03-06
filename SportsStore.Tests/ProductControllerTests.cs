using System.Linq;
using Xunit;
using SportsStore.Controllers;
using SportsStore.Models;
using Moq;
using System.Collections.Generic;

namespace SportsStore.Tests
{
    public class ProductControllerTests
    {

        [Fact]
        public void Can_Paginate()
        {
            var mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns((new Product[]
            {
                new Product {ProductID = 1, Name = "P1"},
                new Product {ProductID = 2, Name = "P2"},
                new Product {ProductID = 3, Name = "P3"},
                new Product {ProductID = 4, Name = "P4"},
                new Product {ProductID = 5, Name = "P5"}
            }).AsQueryable());

            var controller = new ProductController(mock.Object);
            controller.PageSize = 3;

            // Act
            //var result = controller.List(2).ViewData.Model as IEnumerable<Product>;

            // Assert
            //    var prodArray = result.ToArray();
            //    Assert.True(prodArray.Length == 2);
            //    Assert.Equal("P4", prodArray[0].Name);
            //    Assert.Equal("P5", prodArray[1].Name);
        }
    }
}