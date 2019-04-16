using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepositiory repository;

        public int PageSize = 4;

        public ProductController(IProductRepositiory repo)
        {
            repository = repo;
        }

        public ViewResult List(int productPage = 1)
            => View(repository.Products                                           
                .OrderBy(p => p.ProductID)
                .Skip((productPage -1) * PageSize)
                .Take(PageSize));
    }
}
