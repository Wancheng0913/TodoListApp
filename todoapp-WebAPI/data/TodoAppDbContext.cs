using Microsoft.EntityFrameworkCore;
using todoapp_WebAPI.data.entities;

namespace todoapp_WebAPI.data
{
    public class TodoAppDbContext: DbContext
    {
        public TodoAppDbContext(DbContextOptions<TodoAppDbContext> options): base(options)
        {

        }
        public DbSet<TodoItem> TodoItems {get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<TodoItem>().HasData(
                new TodoItem{Id = 1, Title = "Todo Item 1", isDone = false},
                new TodoItem{Id = 2, Title = "Todo Item 2", isDone = false},
                new TodoItem{Id = 3, Title = "Todo Item 3", isDone = true}
            );
        }
    }

    
}