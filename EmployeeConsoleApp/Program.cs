using System.Xml.Linq;

namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();

            string choose ="";
            do
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("1.Employee əlavə et\n2. Bütün işçilərə bax\n3. Maaş aralığına görə işçiləri axtarış et\n0. Proqramı bitir");
                Console.WriteLine("------------------------------------------");
                Console.Write("Seçim edin: ");
                choose = Console.ReadLine();
                if (choose == "1")
                {
                    Console.WriteLine("------------------------------------------");
                    Console.Write("Işçinin adını daxil edin: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("------------------------------------------");
                    Console.Write("Işçinin soyadını daxil edin: ");
                    string surname = Console.ReadLine();
                    string ageStr = "";
                    byte age;
                    do
                    {
                        Console.WriteLine("------------------------------------------");
                        Console.Write("Işçinin yaşını daxil edin: ");
                        ageStr = Console.ReadLine();

                    } while (!byte.TryParse(ageStr, out age));
                    Console.WriteLine("------------------------------------------");
                    Console.Write("Işçinin departmentName daxil edin: ");
                    string departmentName = Console.ReadLine();
                    string salaryStr = "";
                    int salary;
                    do
                    {
                        Console.WriteLine("------------------------------------------");
                        Console.Write("Iscinin maasini daxil edin: ");
                        salaryStr = Console.ReadLine();
                    } while (!int.TryParse(salaryStr, out salary));
                    Employee employee = new Employee(name, surname, age, departmentName, salary);
                    department.AddEmployee(employee);
                }
                else if (choose == "2")
                {
                    Console.WriteLine("------------------------------------------");
                    Employee[] departmentEmployees = department.GetAllEmployees();
                    if (departmentEmployees.Length == 0)
                    {
                        Console.WriteLine("Işçiler yoxdur: ");
                    }
                    else
                    {
                        
                        department.ShowEmployeeInfo();
                      
                    }

                    Console.WriteLine("------------------------------------------");
                }
                else if (choose == "3")
                {

                    string minSalaryStr = "";
                    int minSalary;
                    do
                    {
                        Console.Write("minimum maaş daxil edin: ");
                        minSalaryStr = Console.ReadLine();

                    } while (!int.TryParse(minSalaryStr, out minSalary));
                    
                    string maxSalaryStr = "";
                    int maxSalary;
                    do
                    {
                        Console.Write("maximum maaş daxil edin: ");
                        maxSalaryStr = Console.ReadLine();

                    } while (!int.TryParse(maxSalaryStr, out maxSalary));


                    Console.WriteLine("------------------------------------------");
                    department.GetAllEmployeesBySalary(minSalary, maxSalary);
                    Console.WriteLine("------------------------------------------");
                }


            } while (choose != "0");


          
            
           

           

         
        }
    }
}
