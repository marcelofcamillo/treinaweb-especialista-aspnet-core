using Microsoft.AspNetCore.Mvc;
using twtodolist.Models;

namespace twtodolist.Controllers;

public class TestController : Controller
{
    public IActionResult Index()
    {
        var todo = new Todo
        {
            Title = "Estudar ASP .NET Core",
            Description = "Concluir o curso de ASP .NET Core",
        };

        //ViewData["todo"] = todo;
        ViewBag.todo = todo;

        TempData["message"] = "Mensagem vinda da action Index";
        return View();
    }

    public IActionResult Message()
    {
        return View();
    }
}
