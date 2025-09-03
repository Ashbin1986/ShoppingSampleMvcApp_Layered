using Microsoft.AspNetCore.Mvc;

namespace ShoppingSampleMvcApp_Layered.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
