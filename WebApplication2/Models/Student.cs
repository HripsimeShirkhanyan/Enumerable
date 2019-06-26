using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Student
    {
        public int Id { get; }

        [Required]
        public string Name { get; set; }

        [Range(15, 50)]
        public int Age { get; set; }


    }
}
