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
        private readonly IProductRepositiory repository;

        public ProductController(IProductRepositiory repo)
        {
            repository = repo;
        }

        public ViewResult List() => View(repository.Products);                                           
    }
}
