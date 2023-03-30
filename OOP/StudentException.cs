using System;

namespace OOP
{
    public class StudentException : ArgumentException
    {
        public StudentException(string message) : base(message)
        {
            
        }
    }
}
