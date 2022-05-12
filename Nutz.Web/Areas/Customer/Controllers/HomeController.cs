using Microsoft.AspNetCore.Mvc;
using Nutz.DataAccess.Respository.IRespository;
using Nutz.Models;
using System.Diagnostics;

namespace Nutz.Web.Controllers
{
    // 003 - Home Page
    [Area("Customer")]
    public class HomeController : Controller
    {
        // Data
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        // Index
        public IActionResult Index()
        {
            //Var
            IEnumerable<Product> productList = _unitOfWork.Product.GetAll(includeProperties:"Category,CoverType"); // Product

            return View(productList);
        }

        // Details
        public IActionResult Details(int productId)
        {
            //Var
            ShoppingCart cartObj = new()
            {
                Count = 1,
                Product = _unitOfWork.Product.GetFirstOrDefault(u => u.Id == productId, includeProperties: "Category,CoverType") // Details
            };

            return View(cartObj);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}