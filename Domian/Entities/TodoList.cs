using Domian.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domian.Entities
{
    public class TodoList : AuditableEntity
    {
        public TodoList()
        {
            Items = new HashSet<TodoItem>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Colour { get; set; }

        public ICollection<TodoItem> Items { get;private set; }
    }
}