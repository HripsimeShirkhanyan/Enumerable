using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_app.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> employeeList;

        public MockEmployeeRepository()
        {
            employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, FirstName = "Ani", LastName = "Karapetyan" },
                new Employee() { Id = 2, FirstName = "Karen", LastName = "Santrosyan" },
                new Employee() { Id = 3, FirstName = "Vazgen", LastName = "Sahakyan" }
            };

        }
        public Employee GetEmployee(int id)
        {
            return employeeList.FirstOrDefault(e => e.Id == id);
        }
    }
}
