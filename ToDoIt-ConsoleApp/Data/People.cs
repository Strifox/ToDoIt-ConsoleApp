using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ToDoIt_ConsoleApp.Model;

namespace ToDoIt_ConsoleApp.Data
{
    public class People
    {
        private static Person[] persons = new Person[0];
        private static int personCounter = 0;

        public int Size()
        {
            return persons.Length;
        }

        public Person[] FindAll()
        {
            return persons;
        }

        public Person FindById(int personId)
        {
            return persons.Where(x => x.PersonId == personId).FirstOrDefault();
        }

        public Person CreatePerson(string firstname, string lastname)
        {
            personCounter++;

            var personId = PersonSequencer.NextPersonId();
            var person = new Person(firstname, lastname, personId);

            Array.Resize(ref persons, personCounter);

            for (int i = 0; i < persons.Length; i++)
            {
                if (persons[i] == null)
                    persons[i] = person;
            }

            return person;
        }

        public void Clear()
        {
            persons = new Person[0];
            personCounter = 0;
        }

        public Person[] RemovePerson(Person person)
        {
           return persons.Where(x => x != person).ToArray();
        }
    }
}
