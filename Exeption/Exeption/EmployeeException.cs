using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Homework
{
    //class EmployeeException : ApplicationException
    //{
    //    public EmployeeException(String message) : base(message) { }
    //}

    class EmployeeException : ApplicationException
    {
        private string badValue;
        public EmployeeException(string message)
            : base(message)
        {
            this.badValue = badValue;
        }
        public override string Message => $"{base.Message}";
        public string Badvalue => badValue;
    }
    class EmptynameException : EmployeeException
    {
        public EmptynameException(string message = "Name is EMPTY")
            : base(message)
        {

        }
    }
    class InvalidNameException : EmployeeException
    {
        int index; 
        public InvalidNameException(int index = 0, string message = "Invalid symbols in name")
            : base(message)
        {
            this.index = index;
        }
        public int Index => index;
    }
    class InvalidSalaryException : ApplicationException
    {
        int index;
        public InvalidSalaryException(int index = 0, string message = "Invalid salary")
            : base(message)
        {
            this.index = index;
        }
        public int Index => index;
    }
}
