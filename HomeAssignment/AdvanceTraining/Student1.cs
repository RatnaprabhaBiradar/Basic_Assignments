using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.AdvanceTraining
{
    internal class Student1
    {
    }
    class Student
    {
        public int RollNo { get; set; }
        public string SName { get; set; }
        public float Percentage { get; set; }
        public string Branch { get; set; }
    }
    class TestStudent
    {
        static void Main(string[] args)
        {
            List<Student> StudentList = new List<Student>()
            {
                new Student{RollNo=001,SName="Prajkta",Branch="Electronics",Percentage=77.5f },
                new Student{RollNo=002,SName="Nilesh",Branch="Electronics",Percentage=85.88f },
                new Student{RollNo=003,SName="Maya",Branch="Electronics",Percentage=74.33f },
                new Student{RollNo=004,SName="Deepak",Branch="Electronics",Percentage=72.00f },
                new Student{RollNo=001,SName="Deepali",Branch="Computer",Percentage=67.5f },
                new Student{RollNo=002,SName="Ganesh",Branch="Computer",Percentage=70.5f },
                new Student{RollNo=003,SName="Poonam",Branch="Computer",Percentage=87.5f },
                new Student{RollNo=001,SName="Avanish",Branch="IT",Percentage=84.5f },
                new Student{RollNo=002,SName="Gauri",Branch="IT",Percentage=62.5f },
                new Student{RollNo=001,SName="Sumit",Branch="Production",Percentage=57.5f },
                new Student{RollNo=002,SName="Shreya",Branch="Production",Percentage=86.5f },
                new Student{RollNo=003,SName="Nitin",Branch="Production",Percentage=91.5f }
            };
            var result = from p in StudentList
                         where p.Branch.Contains("IT")
                         select p;
            foreach (var d in result)
            {
                Console.WriteLine($"Roll NO={d.RollNo}\t Name={d.SName}\t Branch={d.Branch}\tPercentage={d.Percentage}");
            }
            Console.WriteLine("-------------------------------------------------------------------");
            var result1 = from p in StudentList
                          where p.Branch.Contains("Computer")
                          select p;
            foreach (var d in result1)
            {
                Console.WriteLine($"Roll NO={d.RollNo}\t Name={d.SName}\t Branch={d.Branch}\tPercentage={d.Percentage}");
            }
            Console.WriteLine("-------------------------------------------------------------------");
            var result2 = from p in StudentList
                          where p.RollNo == 001
                          select p;
            foreach (var d in result2)
            {
                Console.WriteLine($"Roll NO={d.RollNo}\t Name={d.SName}\t Branch={d.Branch}\tPercentage={d.Percentage}");
            }
            Console.WriteLine("-------------------------------------------------------------------");
            var result3 = from p in StudentList
                          where p.Branch.Contains("IT") && p.Percentage > 70.00f
                          select p;
            foreach (var d in result3)
            {
                Console.WriteLine($"Roll NO={d.RollNo}\t Name={d.SName}\t Branch={d.Branch}\tPercentage={d.Percentage}");
            }
            Console.WriteLine("-------------------------------------------------------------------");
            var result4 = from p in StudentList
                          where p.Percentage > 60.00f
                          orderby p.Percentage
                          select p;
            foreach (var d in result4)
            {
                Console.WriteLine($"Roll NO={d.RollNo}\t Name={d.SName}\t Branch={d.Branch}\tPercentage={d.Percentage}");
            }
            Console.WriteLine("-------------------------------------------------------------------");
            var result5 = from p in StudentList
                          orderby p.Percentage
                          select p;
            foreach (var d in result5)
            {
                Console.WriteLine($"Roll NO={d.RollNo}\t Name={d.SName}\t Branch={d.Branch}\tPercentage={d.Percentage}");
            }
            Console.WriteLine("-------------------------------------------------------------------");

        }
    }
}
