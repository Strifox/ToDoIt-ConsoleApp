using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoIt_ConsoleApp.Model
{
    public class Todo
    {
        #region Private Fields

        private readonly int todoId;
        private string description;
        private bool done;
        private Person assignee;

        #endregion

        #region Public Properties

        //public int TodoId { get => todoId; }
        public string Description { get => description; set => description = value; }
        //public bool Done { get => done; set => done = value; }
        //public Person Assignee { get => assignee; set => assignee = value; }

        #endregion

        public Todo(int todoId, string description)
        {
            this.todoId = todoId;
            Description = description;
        }
    }
}
