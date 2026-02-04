using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea1_FrandySena.Classes
{
    public class Student : CommunityMember
    {
        public string Career { get; set; }
        public int Enrrolled { get; set; }
        public double Gpa { get; set; }
        public int Semester { get; set; }

        public Student(string name, string lastName, int age, string nacionality, string idCard, char genre,
                       string role, string address, string career, int enrrolled, double gpa, int semester)
            : base(name, lastName, age, nacionality, idCard, genre, role, address)
        {
            this.Career = career;
            this.Enrrolled = enrrolled;
            this.Gpa = gpa;
            this.Semester = semester;
        }
    }
}
