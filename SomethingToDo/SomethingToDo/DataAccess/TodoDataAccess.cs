using SomethingToDo.Dto;
using SomethingToDo.Mappers;
using System.Collections.Generic;

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
    }
}
