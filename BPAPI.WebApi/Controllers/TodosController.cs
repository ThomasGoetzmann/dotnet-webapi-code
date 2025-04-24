using BPAPI.Domain;
using BPAPI.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace BPAPI.WebApi.Controllers;

[ApiController]
[Route("todos")]
public class TodosController : ControllerBase
{
    private readonly ITodoService _todos;

    public TodosController(ITodoService todos)
    {
        _todos = todos;
    }
    
    [HttpGet("open")]
    public ActionResult<IList<Todo>> GetOpenTodos()
    {
        var openTodos = _todos.AllOpen();
        return Ok(openTodos);
    }

    [HttpGet("done")]
    public ActionResult<IList<Todo>> GetDoneTodos()
    {
        var doneTodos = _todos.AllDone();
        return Ok(doneTodos);
    }
}