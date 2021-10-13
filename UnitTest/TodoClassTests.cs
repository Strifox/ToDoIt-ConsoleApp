using System;
using System.Collections.Generic;
using System.Text;
using ToDoIt_ConsoleApp.Model;
using Xunit;

namespace UnitTest
{
    public class TodoClassTests
    {
        [Fact]
        public void ConstructorTest()
        {
            Todo todo = new Todo(0, "Skapa ett test");

            Assert.NotNull(todo);
        }

    }
}
