using Microsoft.EntityFrameworkCore;
using SomethingToDo.Dto;
using SomethingToDo.Mappers;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomethingToDo.DataAccess
{
    public class TodoDataAccess : ITodoDataAccess
    {
        private readonly TodoContext context;

        public TodoDataAccess(TodoContext context)
        {
            this.context = context;

            this.context.Database.EnsureCreated();
        }

        public async IAsyncEnumerable<TodoDto> GetTodoListAsync()
        {
            await foreach (var item in context.TodoItems.AsAsyncEnumerable())
            {
                yield return Mapper.Map(item);
            }
        }

        public async Task<IEnumerable<TodoDto>> GetTodoListTaskAsync()
        {
            return await context
                .TodoItems
                .Select(x => Mapper.Map(x))
                .ToListAsync();
        }
    }
}
