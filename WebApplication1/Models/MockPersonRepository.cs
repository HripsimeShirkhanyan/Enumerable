using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MockPersonRepository : IPersonRepository
    {
        private List<Person> _personList;
        public MockPersonRepository()
        {
            _personList = new List<Person>()
            {
                new Person() {Name = "Anna", SurName = "Sukiasyan"},
                new Person() {Name = "Karine", SurName = "Sahakyan"},
                new Person() {Name = "Norayr", SurName = "Matinyan"}
            };
        }

        public Person GetPerson(string name)
        {
            return _personList.FirstOrDefault(e => e.Name == name);
        }
    }
}
