using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDashboard
{
    public class EmployeeRunner
    {
        static void Main(string[] args)
        {
            Employee.companyName = "TR";

            Employee emp1= new Employee(101);
            Employee emp2= new Employee(102);
            Employee emp3= new Employee(103);

            emp1.empID = -101;   //set property
            emp1.empName = "saul";
            emp1.empSalary = 9000;
            emp1.empPerformance = "B";


            emp2.empID = 102;
            emp2.empName = "jack";
            emp2.empSalary = 8000;
            emp2.empPerformance = "A";

            emp1.DisplayEmployeeDetails();
            emp2.DisplayEmployeeDetails();
            emp3.DisplayEmployeeDetails();

            emp1.AllocateBonus();
            emp2.AllocateBonus();
            emp3.AllocateBonus();


            //Console.WriteLine(emp1.empID);
            //Console.WriteLine(emp2.empName);
        }
    }
}
