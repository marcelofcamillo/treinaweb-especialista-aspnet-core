using Microsoft.AspNetCore.Mvc;

namespace twtodolist.Controllers;

public class TestController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
