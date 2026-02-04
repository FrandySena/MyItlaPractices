using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1_FrandySena.Classes
{
    public class Employee : CommunityMember
    {
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public string Company { get; set; }
        public double Salary { get; set; }

        public Employee(string name, string lastName, int age, string nacionality, string idCard, char genre,
                        string role, string address, string jobTitle, string department,
                        string company, double salary)
            : base(name, lastName, age, nacionality, idCard, genre, role, address)
        {
            JobTitle = jobTitle;
            Department = department;
            Company = company;
            Salary = salary;
        }
    }
}
