using ToDoIt_ConsoleApp.Data;
using ToDoIt_ConsoleApp.Model;
using Xunit;

namespace UnitTest
{
    public class TodoItemClassTests
    {
        TodoItems todoItem = new TodoItems();
        People people = new People();

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

            Assert.NotNull(expected);
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

        [Fact]
        public void FindByDoneStatusTest()
        {
            todoItem.Clear();
            TodoSequencer.Reset();

            todoItem.CreateTodo("Eat").Done = true;
            todoItem.CreateTodo("Sleep").Done = false;
            todoItem.CreateTodo("Repeat").Done = true;

            var result = todoItem.FindByDoneStatus(true);

            Assert.All(result, item => Assert.True(item.Done));
        }

        [Fact]
        public void FindAssigneeByIdTest()
        {
            todoItem.Clear();
            TodoSequencer.Reset();

            todoItem.CreateTodo("Eat").Assignee = people.CreatePerson("Fredrik", "Karlsson");
            todoItem.CreateTodo("Sleep").Assignee = people.CreatePerson("Boo", "Karlsson");
            todoItem.CreateTodo("Repeat").Assignee = people.CreatePerson("Alfred", "Johansson");

            var result = todoItem.FindByAssignee(1);

            Assert.NotNull(result);
        }

        [Fact]
        public void FindAssigneeByPersonTest()
        {
            todoItem.Clear();
            TodoSequencer.Reset();

            var assignee1 = people.CreatePerson("Fredrik", "Karlsson");

            todoItem.CreateTodo("Eat").Assignee = assignee1;
            todoItem.CreateTodo("Sleep").Assignee = assignee1;
            todoItem.CreateTodo("Repeat").Assignee = people.CreatePerson("Alfred", "Johansson");

            var result = todoItem.FindByAssignee(assignee1);

            Assert.NotNull(result);
        }

        [Fact]
        public void FindUnassignedTodoItemsTest()
        {
            var result = todoItem.FindUnassignedTodoItems();

            Assert.All(result, item => Assert.True(item.Assignee == null));
        }

        [Fact]
        public void RemoveTodoTest()
        {
            todoItem.Clear();
            TodoSequencer.Reset();

            var todo1 = todoItem.CreateTodo("Remove");
            todoItem.CreateTodo("Next to do");
            todoItem.CreateTodo("Train");

            var result = todoItem.RemoveTodo(todo1);
            var expected = 2;

            Assert.Equal(expected, result.Length);
        }

    }
}
