using BPAPI.Domain.Todos;

namespace BPAPI.Domain.Services;

public interface ITodoService
{
    IEnumerable<Todo> AllOpen();
    IEnumerable<Todo> AllDone();
}

public class TodoService : ITodoService
{
    private readonly ITodoRepository _todoRepository;

    public TodoService(ITodoRepository todoRepository)
    {
        _todoRepository = todoRepository;
    }

    public IEnumerable<Todo> AllOpen() 
        => _todoRepository.GetAllTodos()
            .Where(t => !t.IsDone);
    
    public IEnumerable<Todo> AllDone()
        => _todoRepository.GetAllTodos()
            .Where(t => t.IsDone); 
}

