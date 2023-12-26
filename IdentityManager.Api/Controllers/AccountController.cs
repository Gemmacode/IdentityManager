using IdentityManager.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace IdentityManager.Api.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            RegisterViewModel registerViewModel = new RegisterViewModel();
            return View(registerViewModel);
        }
    }
}
