using System;
using System.Collections.Generic;
using System.Text;
using ToDoIt_ConsoleApp.Data;

namespace ToDoIt_ConsoleApp.Model
{
    public class Person
    {
        //static int idCounter = 0;

        #region Private Fields

        private readonly int personId;
        private string firstname;
        private string lastname;

        #endregion

        #region Public Properties

        public int PersonId { get => personId; }
        public string Firstname
        {
            get => firstname;
            set
            {
                // Input can not be null or empty else throws new exception
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Firstname cannot be null or empty");

                firstname = value;
            }
        }
        public string Lastname
        {
            get => lastname;
            set
            {
                // Input can not be null or empty else throws new exception
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Lastname cannot be null or empty");

                lastname = value;
            }
        }

        #endregion


        public Person(string firstname, string lastname, int personId)
        {
            Firstname = firstname;
            Lastname = lastname;
            this.personId = personId;
        }
    }
}
