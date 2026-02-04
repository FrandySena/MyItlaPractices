using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1_FrandySena.Classes
{
    public class Teacher : Employee
    {
        public string Subject { get; set; }
        public int YearsOfExperience { get; set; }
        public string Title { get; set; }

        public Teacher(string name, string lastName, int age, string nacionality, string idCard, char genre,
                       string role, string address, string jobTitle, string department,
                       string company, double salary, string subject, int yearsOfExperience, string title)
            : base(name, lastName, age, nacionality, idCard, genre, role, address, jobTitle, department, company, salary)
        {
            Subject = subject;
            YearsOfExperience = yearsOfExperience;
            Title = title;
        }

    }
}
