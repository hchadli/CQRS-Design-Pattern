using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class TodoItem
    {
        public int Id { get; set; }

        public int ListId { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public bool Done { get; set; }
        public DateTime?  Reminder { get; set; }
        public TodoList List { get; set; }

    }
}
