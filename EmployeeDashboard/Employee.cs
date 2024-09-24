using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDashboard
{
    public class Employee
    {
        private int empID;
        public string empName;
        public double empSalary;
        private string empPerformance;
        public static string companyName;

        //Constructor
        public Employee()
        {
            Console.WriteLine("Object Launched");
        }

        public Employee(int empID)
        {
            this.empID = empID;
        }


        public int EmpID
        {
            get
            {
                return empID;
            }
            set
            {
                if (value > 100)
                {
                    empID = value;
                }
                else
                {
                    Console.WriteLine("employee id is 0. please provide value more than 100");
                }
            }
        }

        //set property should validate and accept empPerformance only if it A or B or C

        public String EmpPerformance
        {
          
            set
            {
                if (value.Equals("A") || value.Equals("B") || value.Equals("C"))
                {
                    empPerformance = value;
                }
                else
                {
                    Console.WriteLine("Please enter performance in A,B,C");

                }
               
                
            }
                
               
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee ID: " + empID);
            Console.WriteLine("Employee Name: " + empName);
            Console.WriteLine("Employee Salary: " + empSalary);
            Console.WriteLine("Employee Performance: " + empPerformance);
            Console.WriteLine("Company Name: " + Employee.companyName);
            Console.WriteLine("---------------------------------------------");


        }

        public void AllocateBonus()
        {
            if (empPerformance != null)
            {
                if (empPerformance.Equals("A"))
                {
                    empSalary = empSalary + 1000;
                }
                else if (empPerformance.Equals("B"))
                {
                    empSalary = empSalary + 500;
                }
                else
                {
                    empSalary = empSalary + 100;
                }
            }
        }
    }
}
