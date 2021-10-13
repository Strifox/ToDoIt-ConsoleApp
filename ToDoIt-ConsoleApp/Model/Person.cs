using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoIt_ConsoleApp.Model
{
    public class Person
    {
        static int idCounter = 0;
        private readonly int personId;
        public int PersonId { get { return personId; } }

        private string firstname;
        public string Firstname
        {
            get { return firstname; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Firstname cannot be null or empty");
                }
                firstname = value;
            }
        }
        private string lastname;
        public string Lastname
        {
            get { return lastname; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Lastname cannot be null or empty");
                lastname = value;
            }
        }


        public Person(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }
    }
}
