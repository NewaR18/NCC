using EntityTry.Models;
using EntityTry.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EntityTry.Controllers
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
            return RedirectToAction("Index");
        }
        public IActionResult Index()
        {
            var Product = productRepo.GetAllProducts();
            return View(Product);
        }
        public IActionResult GetDetail(int id)
        {
            var Product = productRepo.GetProductDetail(id);
            return View(Product);
        }
        public IActionResult Update(int id)
        {
            var Product = productRepo.GetProductDetail(id);
            return View(Product);
        }
        [HttpPost]
        public IActionResult Update(Product product)
        {
            var Product = productRepo.EditProduct(product);
            if (Product != null)
            {
                return RedirectToAction("Index");
            }
            else{
                return View();
            }
        }
        public IActionResult Delete(int id)
        {
            var Product = productRepo.GetProductDetail(id);
            return View(Product);
        }
        [HttpPost]
        public IActionResult Delete(Product product)
        {
            productRepo.DeleteProduct(product.Id);
            return RedirectToAction("Index");
        }
    }
}
