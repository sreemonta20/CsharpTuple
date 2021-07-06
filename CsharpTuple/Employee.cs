using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTuple
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }



        public List<Tuple<int, Employee>> GetEmployees()
        {
            List<Tuple<int, Employee>> details = new();
            int empNumber = 0;
            List<Employee> oList = new();
            oList.Add(new Employee {FirstName= "Sreemonta", LastName = "Bhowmik", Age= 30 });
            oList.Add(new Employee { FirstName = "Ruhul", LastName = "Amin", Age = 30 });
            oList.Add(new Employee { FirstName = "Fedric", LastName = "Thomas", Age = 30 });
            oList.Add(new Employee { FirstName = "Jhonson", LastName = "Nicolas", Age = 30 });

            foreach (var item in oList)
            {
                Tuple<int, Employee> tupleobjet = Tuple.Create(empNumber++, item);
                details.Add(tupleobjet);
            }

            

            return details;
        }

    }

}
