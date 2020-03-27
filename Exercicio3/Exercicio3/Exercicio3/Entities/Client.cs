using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public void AddData(String name, string email, DateTime birth) 
        {
            Name = name;
            Email = email;
            BirthDate = birth;
        }

        public string GetName()
        {
            return Name; 
        }

    }
}
