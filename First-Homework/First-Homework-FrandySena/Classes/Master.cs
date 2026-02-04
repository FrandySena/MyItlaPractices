using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1_FrandySena.Classes
{
    public class Master : Teacher
    {
        public string ThesisTopic { get; set; }
        public string Advisor { get; set; }

        public Master(string name, string lastName, int age, string nacionality, string idCard, char genre,
                      string role, string address, string jobTitle, string department,
                      string company, double salary, string subject, int yearsOfExperience, string title,
                      string thesisTopic, string advisor)
            : base(name, lastName, age, nacionality, idCard, genre, role, address, jobTitle, department,
                   company, salary, subject, yearsOfExperience, title)
        {
            ThesisTopic = thesisTopic;
            Advisor = advisor;
        }
    }
}
