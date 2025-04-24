using BPAPI.Domain;
using BPAPI.Domain.Todos;

namespace BPAPI.WebApi.DTOs;

public record TodoInput(string Text)
{
    public Todo ToNewTodo()
        => new(Guid.NewGuid(), Text, false);
}