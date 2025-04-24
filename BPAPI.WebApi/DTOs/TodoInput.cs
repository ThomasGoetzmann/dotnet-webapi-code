using BPAPI.Domain;

namespace BPAPI.WebApi.DTOs;

public record TodoInput(string Text)
{
    public Todo ToNewTodo()
        => new(Guid.NewGuid(), Text, false);
}