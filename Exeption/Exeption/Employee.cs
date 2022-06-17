using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Homework
{
    class Employee
    {
        public readonly uint ID;
        private static uint Counter;
        private String name;
        private String surname;
        private ushort salary;
        private int numberOfContract;
        
        public String Name
        {
            get { return name; }
            set
            {
                ValidationEmptyName(value); 
                ValidationName(value);
                this.name = value;
                
            }
        }
        public String Surname
        {
            get => surname;
            set
            {
                ValidationEmptyName(value);
                ValidationName(value);
                this.surname = value;
            }
        }
        public ushort Salary
        {
            get => salary;
            set
            {
                if (value > 0 && value < 65534)
                {
                    this.salary = value;
                }
                else
                {
                    var ex = new EmployeeException($"Error with salary!\n" +
                        "Example : 1000,2000,1300,4800\n");
                }
            }
        }


        static Employee() 
        {
            Counter = 0;
            //Counter = (uint)new Random().Next(1000-2000);
        }
        public Employee(string name,string surname,ushort salary)
        {
            this.Name = name;
            this.Surname = surname;
            this.Salary = salary;
            ID = ++Counter;
        }
        
        public override string ToString()
        {
            return $"ID {ID}\n" +
                $"Name {Name}\n" +
                $"Surname {Surname}\n" +
                $"Salary {Salary}\n";
        }
        private void ValidationEmptyName(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
                throw new EmptynameException();
        }
        private void ValidationName(string name)
        {

            for (int i = 0; i < name.Length; i++)
            {
                if (!char.IsLetter(name[i]))
                    throw new InvalidNameException(i);
            }
        }
        // Methods
        public void InputSurName()
        {
            bool exit = false;
            while (!exit)
            {
                try
                {
                    Console.WriteLine("Enter SurName...");
                    string tmp = Console.ReadLine();
                    checkName(tmp);
                    this.Surname = tmp;
                    exit = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        void checkName(string name)
        {
            //if (String.IsNullOrWhiteSpace(name))
            //{
            //    throw new InvalidNameException("Name is null or whitespace");
            //}
            //if (name.All(char.IsDigit))
            //{
            //    throw new InvalidNameException("Name must be only letters");
            //}
            ValidationEmptyName(name);
            ValidationName(name);
        }
        public void inputName()
        {

            bool exit = false;
            while (!exit)
            {
                try
                {
                    Console.WriteLine("Enter Name...");
                    string tmp = Console.ReadLine();
                    checkName(tmp);
                    this.Name = tmp;
                    exit = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
        public void AddSalary(ushort salary)
        {
            if (salary > 0)
            {
                checked
                {
                    this.Salary += salary;
                }
            }
            else
            {
                throw new EmployeeException("Error with add salary!");
            }
        }
        public void RemoveSalary(ushort salary)
        {
            if (salary > 0)
            {
                checked
                {
                    this.Salary -= salary;
                }
            }
            else
            {
                throw new EmployeeException("Error with add salary!");
            }
        }


    }
}
