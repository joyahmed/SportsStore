using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class FakeProductRepository: IProductRepositiory
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product { Name = "Football", Price = 25 },
            new Product { Name = "Surf Bord", Price = 179 },
            new Product { Name = "running shoes", Price = 95 }

        }.AsQueryable<Product>();
    }
}
