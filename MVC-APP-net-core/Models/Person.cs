using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_APP_net_core.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public byte? Age { get; set; }

        public Person()
        {

        }
        public Person(string firstName = null, string lastName = null, byte? age = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
    }
}
