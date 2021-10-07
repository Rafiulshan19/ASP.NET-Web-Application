using System;

namespace Practice.Controllers
{
    internal class Student
    {
        public string SName { get; internal set; }
        public int SId { get; internal set; }
        public string SAddress { get; internal set; }

        public static implicit operator Student(Student v)
        {
            throw new NotImplementedException();
        }
    }
}