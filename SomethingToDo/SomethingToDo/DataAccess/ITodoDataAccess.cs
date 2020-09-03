using SomethingToDo.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SomethingToDo.DataAccess
{
    public interface ITodoDataAccess
    {
        IAsyncEnumerable<TodoDto> GetTodoListAsync();
        Task<IEnumerable<TodoDto>> GetTodoListTaskAsync();
    }
}
