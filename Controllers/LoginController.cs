using Microsoft.AspNetCore.Mvc;
using project.ViewModel;

namespace project.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Account == "Bird"
                    && model.Password == "686")
                    //冷知識:台灣有紀錄的鳥種約686種上下
                {
                    HttpContext.Session.SetString(
                        "User",
                        model.Account);

                    return RedirectToAction(
                        "Index",
                        "Birds");
                }

                ViewBag.Message = "帳號或密碼錯誤";
            }

            return View(model);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Login");
        }
    }
}