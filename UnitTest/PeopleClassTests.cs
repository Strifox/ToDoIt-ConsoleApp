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
            people.Clear();

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

        [Theory]
        [InlineData("Erik","Karlsson")]
        public void FindByIdTest(string firstname, string lastname)
        {
            people.Clear();
            PersonSequencer.Reset();

            var result = people.CreatePerson(firstname, lastname);
            var expected = people.FindById(1);

            Assert.Same(expected, result);
        }

        [Fact]
        public void ClearTest()
        {
            people.Clear();

            var result = people.Size();
            var expected = 0;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void RemovePersonTest()
        {
            people.Clear();
            var person1 = people.CreatePerson("Erik", "Karlsson");
            people.CreatePerson("Boo", "Eriksson");
            people.CreatePerson("Fredrik", "Holmgren");

            var result = people.RemovePerson(person1);
            var expected = 2;

            Assert.Equal(expected, result.Length);
        }
    }
}
