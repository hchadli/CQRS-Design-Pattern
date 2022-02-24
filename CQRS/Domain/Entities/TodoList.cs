using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class TodoList
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Color { get; set; }
        public IList<TodoItem> Items { get; private set; } = new List<TodoItem>();
    }
}
