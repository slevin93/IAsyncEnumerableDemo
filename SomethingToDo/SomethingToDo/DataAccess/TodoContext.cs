using Microsoft.EntityFrameworkCore;
using SomethingToDo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SomethingToDo.Dto;

namespace SomethingToDo.DataAccess
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            TodoItem[] todoItem = new TodoItem[15000];

            for (int i = 0; i < 15000; i++)
            {
                todoItem[i] = new TodoItem() { Id = i + 1, Name = "git", IsComplete = false };
            }


            modelBuilder.Entity<TodoItem>().HasData(todoItem);
        }

        public DbSet<TodoItem> TodoItems { get; set; }

        public DbSet<SomethingToDo.Dto.TodoDto> TodoDto { get; set; }
    }
}
