using SomethingToDo.Dto;
using SomethingToDo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomethingToDo.Mappers
{
    public static class Mapper
    {
        public static TodoDto Map(TodoItem item)
        {
            return new TodoDto()
            {
                Id = item.Id,
                Name = item.Name,
                IsComplete = item.IsComplete
            };
        }
    }
}
