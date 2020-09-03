using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SomethingToDo.DataAccess;
using SomethingToDo.Dto;
using SomethingToDo.Mappers;

namespace SomethingToDo.Controllers.V1
{
    [ApiVersion("1.0")]
    public class ToDoController : ApiBaseController
    {
        private readonly ITodoDataAccess dataAccess;

        public ToDoController(ITodoDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }

        [HttpGet]
        public IAsyncEnumerable<TodoDto> Get()
        {
            return dataAccess.GetTodoListAsync();
        }
    }
}
