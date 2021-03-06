using System;
using System.Collections.Generic;
using System.Text;
using ToDoIt_ConsoleApp.Data;
using ToDoIt_ConsoleApp.Model;
using Xunit;

namespace UnitTest
{
    public class SequencesTests
    {
        #region PersonSequencer Tests

        [Fact]
        public void NextPersonIdTest()
        {
            //Increments person id
            PersonSequencer.Reset();

            var personId = PersonSequencer.NextPersonId(); 
            var expected = 1;

            Assert.Equal(expected, personId);
        }

        [Fact]
        public void PersonIdResetTest()
        {
            PersonSequencer.Reset();
            var result = PersonSequencer.PersonId;
            var expected = 0;

            Assert.Equal(expected, result);
        }

        #endregion

        #region TodoSequencer Tests

        [Fact]
        public void NextTodoIdTest()
        {
            TodoSequencer.Reset();
            TodoSequencer.NextTodoId();

            var personId = TodoSequencer.TodoId;
            var expected = 1;

            Assert.Equal(expected, personId);
        }

        [Fact]
        public void TodoIdResetTest()
        {
            TodoSequencer.Reset();
            var result = TodoSequencer.TodoId;
            var expected = 0;

            Assert.Equal(expected, result);
        }
        #endregion
    }
}
