namespace BPAPI.Domain.Todos;

public interface ITodoRepository
{
    IList<Todo> GetAllTodos();
}

// Remark: this class should be in another "database" project
public class InMemoryTodoDatabase : ITodoRepository
{
    private static List<Todo> todos = [
        new(1, "Créer le controler", true),
        new(2, "Créer le service et le domain", true),
        new(3, "Injecter les dépendances", false)
    ];

    public IList<Todo> GetAllTodos() => todos;
}