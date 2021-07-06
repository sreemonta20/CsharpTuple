using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTuple
{
    public class EmployeeDepartment
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }



        public Tuple<string, List<EmployeeDepartment>> GetEmployeesByDept()
        {
            
            string dept = "IT";
            List<EmployeeDepartment> oList = new();
            oList.Add(new EmployeeDepartment { FirstName = "Sreemonta", LastName = "Bhowmik", Age = 30, Department = "IT" });
            oList.Add(new EmployeeDepartment { FirstName = "Ruhul", LastName = "Amin", Age = 30, Department = "IT" });
            oList.Add(new EmployeeDepartment { FirstName = "Fedric", LastName = "Thomas", Age = 30, Department = "Sales" });
            oList.Add(new EmployeeDepartment { FirstName = "Jhonson", LastName = "Nicolas", Age = 30, Department = "Sales" });

            Tuple<string, List<EmployeeDepartment>> tupleobjet = Tuple.Create(dept, oList.FindAll(x=> x.Department == dept));

            return tupleobjet;
        }
    }

}
