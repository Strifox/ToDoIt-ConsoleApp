using System;
using System.Collections.Generic;
using System.Text;
using ToDoIt_ConsoleApp.Data;
using ToDoIt_ConsoleApp.Model;
using Xunit;

namespace UnitTest
{
    public class DataTests
    {
        #region PersonSequencer Tests

        [Fact]
        public void NextPersonIdTest()
        {
            //Increments person id
            PersonSequencer.NextPersonId();

            var personId = PersonSequencer.PersonId;
            var expected = 1;

            Assert.Equal(expected, personId);
        }

        [Fact]
        public void PersonIdResetTest()
        {

            var result = PersonSequencer.PersonId;
            var expected = 0;

            Assert.Equal(expected, result);
        }

        #endregion
    }
}
