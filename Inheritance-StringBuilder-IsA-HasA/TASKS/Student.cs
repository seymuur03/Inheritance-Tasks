using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKS
{
    internal class Student
    {
        public string FullName;
        public DateTime BirthDate;
        public string GroupNo;
        public int Point ;

        public void ShowInfo()
        {
            Console.WriteLine($" FullName :{FullName} Point :{Point}");
        }
        public Student(string fullname,int point)
        {
            if (point < 0 || point > 100)
                throw new ArgumentException("Point must be between 0 and 100.");
            FullName = fullname;
            Point = point;
        }
    }
}
