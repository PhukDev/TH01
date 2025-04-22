using Microsoft.AspNetCore.Mvc;
using TH01.Models.Interfaces;

namespace TH01.Controllers
{
    public class ProductController : Controller
    {
        IProductRepository productRepository;
        ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult Shop()
        {
            return View (productRepository.GetProduct());
        }
    }
}
