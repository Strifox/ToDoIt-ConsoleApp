using System;
using ToDoIt_ConsoleApp.Model;
using Xunit;

namespace UnitTest
{
    public class PersonClassTests
    {
        [Fact]
        public void ConstructorTest()
        {
            Person person = new Person("Erik", "Karlsson");

            Assert.NotNull(person);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void FirstnameTest(string firstname)
        {
            var result = Assert.Throws<ArgumentException>(() => new Person(firstname, "Karlsson"));

            Assert.Equal("Firstname cannot be null or empty", result.Message);
        }

    }
}
