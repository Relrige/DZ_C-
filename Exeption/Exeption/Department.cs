using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Homework
{
    class Department
    {
        List<Employee> department;
        public Department() 
        {
            department = new List<Employee>();
        }
        public void AddEmployeer(Employee employee)
        {

            FullDepartment();
            department.Add(employee);
            
        }
        public void RemoveEmployee(Employee employee)
        {
            EmptyDepartment();
            department.Remove(employee);

        }
        public void Render()
        {
            foreach (var item in department)
            {
                Console.WriteLine(item);
            }
        }
        private void FullDepartment()
        {
            if (department.Count>15)
                throw new FullDerartmentException();
        }
        private void EmptyDepartment()
        {
            if (department == null)
                throw new EmptyDerartmentException();
        }

    }
}