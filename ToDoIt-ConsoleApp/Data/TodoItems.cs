using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoIt_ConsoleApp.Model;

namespace ToDoIt_ConsoleApp.Data
{
    public class TodoItems
    {
        private static Todo[] todos = new Todo[0];
        private static int todoCounter = 0;

        public int Size()
        {
            return todos.Length;
        }

        public Todo[] FindAll()
        {
            return todos;
        }

        public Todo FindById(int todoId)
        {
            return todos.Where(x => x.TodoId == todoId).FirstOrDefault();
        }

        public Todo CreateTodo(string description)
        {
            todoCounter++;

            var todoId = TodoSequencer.NextTodoId();
            var todo = new Todo(todoId, description);

            Array.Resize(ref todos, todoCounter);

            for (int i = 0; i < todos.Length; i++)
            {
                if (todos[i] == null)
                    todos[i] = todo;
            }

            return todo;
        }

        public void Clear()
        {
            todos = new Todo[0];
            todoCounter = 0;
        }
    }
}
