using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Employee
    {
        public Employee(string name, string surname, byte age, string departmentNo, int salary)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.DepartmentName = departmentNo;
            this.Salary = salary;

        }

        public string Name;
        public string Surname;
        public byte Age;
        public string DepartmentName;
        public int Salary;
    }
}
