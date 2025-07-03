using Microsoft.AspNetCore.Mvc;
using twtodolist.Contexts;
using twtodolist.Models;
using twtodolist.ViewModels;

namespace twtodolist.Controllers;

public class TodoController : Controller
{
    private readonly AppDbContext _context;

    public TodoController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var todos = _context.Todos.ToList();
        var viewModel = new TwTodolist.ViewModels.ListTodoViewModel { Todos = todos };
        ViewData["Title"] = "Lista de Tarefas";

        return View(viewModel);
    }

    public IActionResult Delete(int id)
    {
        var todo = _context.Todos.Find(id);
        if (todo is null)
        {
            return NotFound();
        }
        _context.Remove(todo);
        _context.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Create()
    {
        ViewData["Title"] = "Cadastrar Tarefa";
        return View();
    }

    [HttpPost]
    public IActionResult Create(CreateTodoViewModel data)
    {
        var todo = new Todo(data.Title, data.Date);
        _context.Add(todo);
        _context.SaveChanges();

        return RedirectToAction(nameof(Index));
    }
}
