using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public interface IProductRepositiory
    {
        IQueryable<Product> Products { get; }
    }
}
