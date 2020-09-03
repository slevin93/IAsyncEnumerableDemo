using SomethingToDo.Dto;
using System.Collections.Generic;

namespace SomethingToDo.DataAccess
{
    public interface ITodoDataAccess
    {
        IAsyncEnumerable<TodoDto> GetTodoListAsync();
    }
}
