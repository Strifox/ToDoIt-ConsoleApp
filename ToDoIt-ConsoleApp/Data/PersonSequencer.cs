using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoIt_ConsoleApp.Data
{
    public class PersonSequencer
    {
        private static int personId;

        public static int PersonId { get => personId; }

        /// <summary>
        /// Increments personId for next person.
        /// </summary>
        public static void NextPersonId()
        {
            personId++;
        }

        /// <summary>
        /// Resets person Id
        /// </summary>
        public static void Reset()
        {
            personId = 0;
        }
    }
}
