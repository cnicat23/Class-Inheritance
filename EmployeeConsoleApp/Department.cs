using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Department
    {
        Employee[] Employees = new Employee[] { };

        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref Employees, Employees.Length + 1);

            Employees[Employees.Length - 1] = employee;
        }
        public void ShowEmployeeInfo()
        {
            for (int i = 0; i < Employees.Length; i++)
            {
                Console.WriteLine($"Name: {Name}\nSurname: {Surname}\nAge: {Age}\nDepartmentName:{DepartmentName}\nSalary: {Salary}");
                Console.WriteLine("------------------------------------------");
            }


        }
        public Employee[] GetAllEmployees()
        {
            return Employees;
        }

        public void GetAllEmployeesBySalary(int minSalary, int maxSalar)
        {
            if (Employees.Length != 0)
            {
                for (int i = 0; i < Employees.Length; i++)
                {
                    if (Salary > minSalary && Salary < maxSalar)
                    {
                        Console.WriteLine($"Name: {Name}\nSurname: {Surname}\nAge: {Age}\nDepartmentName:{DepartmentName}\nSalary: {Salary}");
                        Console.WriteLine("------------------------------------------");

                    }
                    else
                    {
                        Console.WriteLine("Bu maaş aralığında işçi yoxdur!!");
                        break;
                    }

                }
            }
            else
            {
                Console.WriteLine("Işçi yoxdur!!");
            }



        }
    }
}
