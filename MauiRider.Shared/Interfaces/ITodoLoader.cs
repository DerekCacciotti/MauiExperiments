using MauiRider.Shared.Models;

namespace MauiRider.Shared.Interfaces;

public interface ITodoLoader
{
    Task<List<Todo>> GetTodos();
}