using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Basic.Models
{
    public class Student
    {
        public int? Id { get; set; }
        [Required(ErrorMessage ="Tenc anun ova dnum?")] //es menak name-i vraya azdum? isk ete uzum em iranci nerqev exac bolori vra? shat ban es uzum amen mekin irane piti tas ok? lav
        public string Name { get; set; }
        public string Department { get; set; }
        [Range(0,120,ErrorMessage ="et tariqi mard vortex es tesel")] //spasi
        public byte? Age { get; set; }

        public List<string> ErrMsgs { get; set; }
        public Student() { }
        
        public Student(int? id = null, string name = null, string department = null, byte? age = null)
        {
            this.Id = id;
            this.Name = name;
            this.Department = department;
            this.Age = age;
        }
    }
}
