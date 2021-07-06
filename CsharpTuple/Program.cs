using CsharpTuple;
using System;
using System.Collections.Generic;

Console.WriteLine($"----------------------------Example 1------------------------------");
Employee oEmp = new();
List<Tuple<int, Employee>> details = oEmp.GetEmployees();
foreach (var item in details)
{
    Console.WriteLine($"Employee Number : {item.Item1} and First Name : {item.Item2.FirstName}");
}


Console.WriteLine($"----------------------------Example 2------------------------------");
EmployeeDepartment oEmpDept = new();

Tuple<string, List<EmployeeDepartment>> employeesdept = oEmpDept.GetEmployeesByDept();

Console.WriteLine($"Department is  {employeesdept.Item1}");
foreach (var item in employeesdept.Item2)
{
    Console.WriteLine($"Employee : {item.FirstName}, Age : {item.Age}");
}

Console.ReadKey();

