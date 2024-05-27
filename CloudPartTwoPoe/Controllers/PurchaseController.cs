using CloudPartTwoPoe.Models;
using CloudPartTwoPoe.Services;
using Microsoft.AspNetCore.Mvc;

namespace CloudPartTwoPoe.Controllers
{
	public class PurchaseController : Controller
	{
		private readonly ProjectDbContext project;

		public PurchaseController(ProjectDbContext project) 
		{
			this.project = project;
		}
		public IActionResult Index()
		{
			var purchases = project.Purchase.ToList();
			return View(purchases);
		}

        public IActionResult Create()
		{
			return View();
		}
        [HttpPost]
        public IActionResult Create(PurchaseDto purchaseDto)
        {
            if (!ModelState.IsValid)
            {
                return View(purchaseDto);
            }

            Purchase purchase = new Purchase()
            {
                FirstName = purchaseDto.FirstName,
                LastName = purchaseDto.LastName,
                Email = purchaseDto.Email,
                PhoneNumber = purchaseDto.PhoneNumber,
                Address = purchaseDto.Address,
                ItemPurchased = purchaseDto.ItemPurchased,
            };

            project.Purchase.Add(purchase);
            project.SaveChanges();

            return RedirectToAction("Index", "Purchase");
        }


    }
}
