using System;
using System.Collections.Generic;
using System.Text;
using Tarea1_FrandySena.Classes;
namespace Tarea1_FrandySena.Classes
{
    public class CommunityMember : Person
    {
        public string Role { get; set; }
        public string Address { get; set; }

        public CommunityMember(string name, string lastName, int age, string nacionality, string idCard, char genre,
                               string role, string address)
            : base(name, lastName, age, nacionality, idCard, genre)
        {
            Role = role;
            Address = address;
        }

    }
}
