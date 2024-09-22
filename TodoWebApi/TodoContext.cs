using Microsoft.EntityFrameworkCore;
using TodoWebApi.Entities;

namespace TodoWebApi
{
    public class TodoContext(DbContextOptions<TodoContext> context) : DbContext(context)
    {
        public DbSet<Todo> Todos => Set<Todo>();
    }
}
