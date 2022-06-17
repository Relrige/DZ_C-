using System;

namespace Exception_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Mike", "Ross", 1000);
            Employee employee2 = new Employee("Volodumr", "Zelenskii", 12000);
            Department department = new Department();

            try
            {
                employee.AddSalary(4000);
                employee.RemoveSalary(1600);
                Console.WriteLine(employee);
                Console.WriteLine(employee2);

                //                     department

                department.AddEmployeer(new Employee("Harvy", "Spectr", 2400));
                department.AddEmployeer(new Employee("Luis", "Litt", 1200));
                department.AddEmployeer(new Employee("Robert", "Zeyn", 11200));
                //department.AddEmployeer(new Employee(null, null, 21000));
                department.RemoveEmployee(employee);
                department.Render();

            }
            catch (DepartmentException ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            catch (EmployeeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //catch (...)
            //{
            //    Console.WriteLine("Error");
            //}

        }
    }
}
