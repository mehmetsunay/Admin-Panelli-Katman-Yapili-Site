using Microsoft.AspNetCore.Mvc;
using KatmanAdmin.AdminPanel.Models;
using KatmanAdmin.BusinessLayer.Concrete;

namespace RustamGapurovEndTask.AdminPanel.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager _userManager;
        public UserController()
        {
            _userManager = new UserManager();
        }

        public IActionResult LoginPanel()
        {
            return View();
        }

        public ActionResult Login(UserModel model)
        {
            bool result = _userManager.Login(model.Email, model.Password);
            if (result)
            {
                TempData["ErrorMessage"] = "";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["ErrorMessage"] = "Kullanıcı adı veya şifre hatalı...";
                return RedirectToAction("LoginPanel", "User");
            }

        }
    }
}
