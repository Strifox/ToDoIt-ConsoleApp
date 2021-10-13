using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoIt_ConsoleApp.Data
{
    public class TodoSequencer
    {
        private static int todoId;

        public static int TodoId { get => todoId; }

        /// <summary>
        /// Increments personId for next person.
        /// </summary>
        public static int NextTodoId()
        {
            return ++todoId;
        }

        /// <summary>
        /// Resets person Id
        /// </summary>
        public static void Reset()
        {
            todoId = 0;
        }
    }
}
