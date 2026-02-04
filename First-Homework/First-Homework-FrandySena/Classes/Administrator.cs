using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1_FrandySena.Classes
{
    public class Administrator : Teacher
    {
        public string Level { get; set; }
        public string AreaOfOversight { get; set; }

        public Administrator(string name, string lastName, int age, string nacionality, string idCard, char genre,
                             string role, string address, string jobTitle, string department,
                             string company, double salary, string subject, int yearsOfExperience, string title,
                             string level, string areaOfOversight)
            : base(name, lastName, age, nacionality, idCard, genre, role, address, jobTitle, department,
                   company, salary, subject, yearsOfExperience, title)
        {
            Level = level;
            AreaOfOversight = areaOfOversight;
        }
    }
}
