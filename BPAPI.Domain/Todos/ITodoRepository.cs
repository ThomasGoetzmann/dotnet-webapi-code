namespace BPAPI.Domain.Todos;

public interface ITodoRepository
{
    IList<Todo> GetAllTodos();
    void Add(Todo todo);
    Todo? Find(Guid id);
}

// Remark: this class should be in another "database" project
public class InMemoryTodoDatabase : ITodoRepository
{
    private static List<Todo> todos = [
        new(Guid.NewGuid(), "Créer le controler", true),
        new(Guid.NewGuid(), "Créer le service et le domain", true),
        new(Guid.NewGuid(), "Injecter les dépendances", false)
    ];

    public IList<Todo> GetAllTodos() 
        => todos;

    public void Add(Todo todo) 
        => todos.Add(todo);

    public Todo? Find(Guid id) 
        => todos.FirstOrDefault(t => t.Id == id);
}