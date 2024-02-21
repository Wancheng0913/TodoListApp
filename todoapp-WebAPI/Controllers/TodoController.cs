using Microsoft.AspNetCore.Mvc;
using todoapp_WebAPI.Services;

namespace todoapp_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly TodoService _todoService;

        public TodoController(TodoService todoService) {
            _todoService = todoService;
        }

        [HttpGet("getWorkTasks")]
        public IActionResult GetTodoItems() {
            var todoItems = _todoService.GetTodoItems();
            return Ok(todoItems);
        }
    }
}