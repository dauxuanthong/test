using Database_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Database_3.Controllers
{
    public class ProductsController : Controller
	{
		private ApplicationDbContext _context;
		//Create private variable of  
		public ProductsController()
		{
			_context = new ApplicationDbContext(); 
		}

		// Get
		[HttpGet]
		public ActionResult Index() // ActionResult must set as Public 
		{
			var products = _context.Products.ToList();
			return View(products);
		}

		
		[HttpGet] 
		public ActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Create(Product product)
		{
			if (!ModelState.IsValid)
			{
				return View();
			}

			//check product Already Exists
			if(_context.Products.Any(p => p.ProName.Contains(product.ProName)))
			{
				ModelState.AddModelError("Name", "Product Name Already Exists.");
				return View();
			}

			//Create new product
			var newProduct = new Product
			{
				ProName = product.ProName,
				Price = product.Price
			};
			//Add new product
			_context.Products.Add(newProduct);
			_context.SaveChanges();

			return RedirectToAction("Index");
		}


    }
}