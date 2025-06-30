using Microsoft.EntityFrameworkCore;
using twtodolist.EntityConfigs;
using twtodolist.Models;

namespace twtodolist.Contexts;

public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public DbSet<Todo> Todos => Set<Todo>();

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseSqlServer(
            "Server=localhost;Database=twtodolist;Trusted_Connection=True;Encrypt=False;"
        );
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new TodoEntityConfig());
    }
}
