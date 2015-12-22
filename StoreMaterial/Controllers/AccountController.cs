using StoreMaterial.Models.Administrator;
using StoreMaterial.Repository.Administrator;
using System.Web.Mvc;
using System.Web.Security;

namespace StoreMaterial.Controllers
{
    public class AccountController : Controller
    {
        private IUser _userService;
        public AccountController()
        {
            _userService = new UserService();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                if (string.IsNullOrEmpty(model.UserName) || string.IsNullOrEmpty(model.Password)) return View(model);
                var check = _userService.Login(model.UserName, model.Password);
                if (check)
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return RedirectToAction("Index", "Admin");
                }
                ModelState.AddModelError("LoginError", "Tài khoản hoặc mật khẩu không đúng.");
            }
            return View(model);
        }
    }
}