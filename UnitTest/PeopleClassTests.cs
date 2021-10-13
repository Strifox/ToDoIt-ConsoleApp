using ToDoIt_ConsoleApp.Data;
using ToDoIt_ConsoleApp.Model;
using Xunit;

namespace UnitTest
{
    public class PeopleClassTests
    {
        People people = new People();

        [Fact]
        public void ArrayLengthTest()
        {
            var result = people.Size();
            var expected = 0;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void FindAllTest()
        {
            var persons = people.FindAll();

            Assert.NotNull(persons);
        }

        [Fact]
        public void CreatePersonsTest()
        {
            var result = people.CreatePerson("Erik", "Karlsson");
           
            Assert.IsType<Person>(result);
        }

        [Fact]
        public void FindByIdTest()
        {
            var result = people.CreatePerson("Erik", "Karlsson");
            var expected = people.FindById(1);

            Assert.Same(expected, result);
        }

        [Fact]
        public void ClearTest()
        {
            people.CreatePerson("Erik", "Karlsson");
            people.Clear();

            var result = people.Size();
            var expected = 0;

            Assert.Equal(expected, result);

        }
    }
}
