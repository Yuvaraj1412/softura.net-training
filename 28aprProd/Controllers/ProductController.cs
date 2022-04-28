using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProdEF.Models;


namespace ProdEF.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create(Product P)
        {
            if(ModelState.IsValid)
            {
                ProdDBContext dBContext = new ProdDBContext();
                dBContext.Add(P);
                dBContext.SaveChanges();
                return Content("Saved to Product list");
            }
            return View("Index");
        }
    }
}
