using KatmanAdmin.BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using KatmanAdmin.AdminPanel.Models;
using System.Diagnostics;
using KatmanAdmin.Entity.Entities;
using AdminPanel.Models;

namespace RustamGapurovEndTask.AdminPanel.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager _userManager;
        private readonly CategoryManager _categoryManager;
        private readonly ProductManager _productManager;

        public HomeController()
        {
            _userManager = new UserManager();
            _categoryManager = new CategoryManager();
            _productManager = new ProductManager();
        }



        
        //public IActionResult AddCategoryView()
        //{
        //    //List<Category> categories = _categoryManager.GetAll();
        //    //return View(categories);
        //}

        //public IActionResult AddProductView()
        //{
        //    return View();
        //}

        //public IActionResult UserView()
        //{
        //    List<User> users = _userManager.ListUser();
        //    return View(users);
        //}
        //[HttpGet]


        //[HttpPost]
        //public IActionResult AddProduct(ProductModel p)
        //{
        //    Product product = new Product();
        //    product.Name = p.Name;
        //    product.Price = p.Price;
        //    product.Quantity = p.Quantity;
        //    product.CategoryId = p.CategoryId;
        //    product.CreateDate = DateTime.Now;
        //    product.TagId = p.TagId;

        //    _productManager.AddProduct(product);

        //    return RedirectToAction("ProductList");
        //}

        //public IActionResult DeleteProduct(Product p)
        //{
        //    _productManager.DeleteProduct(p);
        //    return RedirectToAction("Index");
        //}


        public IActionResult Index()
        {
            return View();

        }
        //public IActionResult ProductList()
        //{
        //    List<Product> ListModel = _productManager.ListProduct();
        //    return View(ListModel);

        //}



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