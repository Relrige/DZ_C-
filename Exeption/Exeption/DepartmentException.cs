using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Homework
{
    class DepartmentException : ApplicationException
    {
        public DepartmentException(String message)
            : base(message) { }
    }
    class EmptyDerartmentException : DepartmentException
    {
        public EmptyDerartmentException(string message = "Department is empty") : base(message)
        { }
    }

    class FullDerartmentException : ApplicationException
    {
        public FullDerartmentException(string message = "Department is full") : base(message)
        { }
    }

}
