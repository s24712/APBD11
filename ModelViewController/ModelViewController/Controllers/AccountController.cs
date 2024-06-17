using Microsoft.AspNetCore.Mvc;
using ModelViewController.Models;

namespace ModelViewController.Controllers;

public class AccountController : Controller
{
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
    {
        if (ModelState.IsValid)
        {
        }

        return View(model);
    }
}