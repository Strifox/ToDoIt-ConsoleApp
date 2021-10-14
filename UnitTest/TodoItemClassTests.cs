using ToDoIt_ConsoleApp.Data;
using ToDoIt_ConsoleApp.Model;
using Xunit;

namespace UnitTest
{
    public class TodoItemClassTests
    {
        TodoItems todoItem = new TodoItems();

        [Fact]
        public void ArrayLengthTest()
        {
            todoItem.Clear();
            var result = todoItem.Size();
            var expected = 0;

            Assert.Equal(expected, result);
            todoItem.Clear();
        }

        [Fact]
        public void FindAllTest()
        {
            todoItem.Clear();
            TodoSequencer.Reset();

            var persons = todoItem.FindAll();

            Assert.NotNull(persons);
            todoItem.Clear();
        }

        [Fact]
        public void CreateTodosTest()
        {
            todoItem.Clear();
            TodoSequencer.Reset();

            var result = todoItem.CreateTodo("What to do");

            Assert.IsType<Todo>(result);
            todoItem.Clear();
        }

        [Fact]
        public void FindByIdTest()
        {
            todoItem.Clear();
            TodoSequencer.Reset();
            var result = todoItem.CreateTodo("What to do");
            var expected = todoItem.FindById(1);

            Assert.Same(expected, result);
            todoItem.Clear();
        }

        [Fact]
        public void ClearTest()
        {
            todoItem.Clear();

            var result = todoItem.Size();
            var expected = 0;

            Assert.Equal(expected, result);
            todoItem.Clear();
        }
    }
}
