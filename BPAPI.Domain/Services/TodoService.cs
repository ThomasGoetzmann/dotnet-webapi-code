namespace BPAPI.Domain.Services;

public interface ITodoService
{
    IEnumerable<Todo> AllOpen();
    IEnumerable<Todo> AllDone();
}

public class TodoService : ITodoService
{
    private static List<Todo> todos = [
        new(1, "Créer le controler", true),
        new(2, "Créer le service et le domain", true),
        new(3, "Injecter les dépendances", false)
    ];
    
    public IEnumerable<Todo> AllOpen() 
        => todos
            .Where(t => !t.IsDone);
    
    public IEnumerable<Todo> AllDone()
        => todos
            .Where(t => t.IsDone); 
}

