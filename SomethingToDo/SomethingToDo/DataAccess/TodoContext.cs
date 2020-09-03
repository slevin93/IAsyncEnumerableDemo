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
            modelBuilder.Entity<TodoItem>().HasData(new TodoItem { Id = 1, Name = "git", IsComplete = false });
        }

        public DbSet<TodoItem> TodoItems { get; set; }

        public DbSet<SomethingToDo.Dto.TodoDto> TodoDto { get; set; }
    }
}
