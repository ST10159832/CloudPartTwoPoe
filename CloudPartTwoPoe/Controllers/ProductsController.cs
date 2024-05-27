using CloudPartTwoPoe.Models;
using CloudPartTwoPoe.Services;
using Microsoft.AspNetCore.Mvc;

namespace CloudPartTwoPoe.Controllers
{
	public class ProductsController : Controller
	{
		private readonly ApplicationDbContext context;

		public ProductsController(ApplicationDbContext context)
		{
			this.context = context;
		}

		public IActionResult Index()
		{
			var products = context.Products.ToList();
			return View(products);
		}

		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(ProductDto productDto)
		{
			if (!ModelState.IsValid)
			{
				return View(productDto);
			}

			Product product = new Product()
			{
				Name = productDto.Name,
				Price = productDto.Price,
				Category = productDto.Category,
				Availability = productDto.Availability,
			};

			context.Products.Add(product);
			context.SaveChanges();

			return RedirectToAction("Index", "Products");
		}
	}
}
