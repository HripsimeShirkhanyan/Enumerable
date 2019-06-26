using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpecialTemplateSample.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Role Role { get; set; }
    }

    public enum Role
    {
        Guest, User, Admin
    }
}
