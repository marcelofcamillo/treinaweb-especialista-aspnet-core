using twtodolist.Models;

namespace twtodolist.ViewModels;

public class DetailsTodoViewModel
{
    public Todo Todo { get; set; } = null!;
    public string PageTitle { get; set; } = string.Empty;
}
