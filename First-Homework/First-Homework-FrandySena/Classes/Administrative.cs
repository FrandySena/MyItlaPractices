using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1_FrandySena.Classes
{
    public class Administrative : Employee
    {
        public string Area { get; set; }
        public string Responsibility { get; set; }

        public Administrative(string name, string lastName, int age, string nacionality, string idCard, char genre,
                              string role, string address, string jobTitle, string department,
                              string company, double salary, string area, string responsibility)
            : base(name, lastName, age, nacionality, idCard, genre, role, address, jobTitle, department, company, salary)
        {
            Area = area;
            Responsibility = responsibility;
        }
    }
}
