using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class ProductControllerTests
    {
        [Fact]
        public void Can_Paginate()
        {
            //Arrange
            Mock<IProductRepositiory> mock = new Mock<IProductRepositiory>();

            mock.Setup(m => m.Products).Returns((new Product[]
            {
                new Product  {ProductID = 1, Name = "P1"}, 
                new Product  {ProductID = 2, Name = "P2"}, 
                new Product  {ProductID = 3, Name = "P3"}, 
                new Product  {ProductID = 4, Name = "P4"}, 
                new Product  {ProductID = 5, Name = "P5"}, 
            }).AsQueryable <Product());
            
        }
    }
}
