using Microsoft.AspNetCore.Mvc;
using EntityD.Repositories;
using EntityD.Models;
namespace EntityD.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepo productRepo;
        public ProductController(IProductRepo repo)
        {
            productRepo = repo;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            productRepo.AddProduct(product);
            return Content("Product has been inserted sucesssful");
        }
        public IActionResult Index()
        {
            var product = productRepo.GetAllProducts();
            return View(product);
        }
        public IActionResult Update(int id)
        {
            Product product = productRepo.GetProductDetail(id);
            return View(product);
        }
        public IActionResult Update(Product product)
        {
            Product p = productRepo.EditProduct(product);
            if (p != null)
                return RedirectToAction("Index");
            else
                return View();
        }
        public IActionResult Delete(int id)
        {
            Product product = productRepo.GetProductDetail(id);
            return View(product);
        }
        [HttpDelete]
        public IActionResult Delete(Product product)
        {
            productRepo.DeleteProduct(product.Id);
            return RedirectToAction("Index");
        }

    }
}
