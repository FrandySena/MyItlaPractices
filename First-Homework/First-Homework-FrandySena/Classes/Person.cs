using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1_FrandySena.Classes
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Nacionality { get; set; }
        public string IdCard { get; set; }
        public char Genre { get; set; }

        public Person(string name, string lastName, int age, string nacionality, string idCard, char genre)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            Nacionality = nacionality;
            IdCard = idCard;
            Genre = genre;
        }
    }
}
