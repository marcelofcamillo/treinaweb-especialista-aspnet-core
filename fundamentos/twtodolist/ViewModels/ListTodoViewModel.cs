using twtodolist.Models;

namespace TwTodolist.ViewModels;

public class ListTodoViewModel
{
    public ICollection<Todo> Todos { get; set; } = new List<Todo>();
}
