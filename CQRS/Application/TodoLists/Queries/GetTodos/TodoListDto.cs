using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Domain;

namespace Application.TodoLists.Queries.GetTodos
{
    public class TodoListDto : IMapFrom<TodoList>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public IList<TodoItemDto> Items { get; set; }

        public TodoListDto()
        {
            Items = new List<TodoItemDto>();
        }
    }
}
