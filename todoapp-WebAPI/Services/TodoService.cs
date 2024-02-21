using todoapp_WebAPI.Models;
using todoapp_WebAPI.data;

namespace todoapp_WebAPI.Services
{
    public class TodoService
    {
        private readonly TodoAppDbContext _dbContext;
        public TodoService(TodoAppDbContext dbContext) {
            _dbContext = dbContext;
        }

        public List<TodoItemDTO> GetTodoItems(){
            return _dbContext.TodoItems.Select(x => new TodoItemDTO 
            {
                Title = x.Title,
                isDone = x.isDone
            }).ToList();
        }
    }
}