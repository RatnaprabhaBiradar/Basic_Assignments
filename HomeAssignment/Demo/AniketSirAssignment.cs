using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Demo
{
    internal class AniketSirAssignment
    {
    }
    class Emp
    {
        int empid;
        string name;
        double salary;
        public Emp()
        {

        }
        public Emp(int empid, string name, double salary)
        {
            this.Empid = empid;
            this.Name = name;
            this.Salary = salary;
        }

        public int Empid { get => empid; set => empid = value; }
        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }
    }
    class TestEMP
    {
        static void Main(string[] args)
        {
            Emp[] e = new Emp[5] {
            new Emp(1, "name", 45689),
            new Emp(2, "Ratna", 30000),
            new Emp(3, "Ratna", 30000),
            new Emp(4, "Ratna", 30000),
            new Emp(5, "Ratna", 30000),
        };
               
            for (int i = 0; i < e.Length; i++)
            {
                if (e[i].Salary > 45000)
                {
                    Console.WriteLine("Emp Details");
                    Console.WriteLine("Emp Id = " + e[i].Empid);
                    Console.WriteLine("Emp Name = " + e[i].Name);
                    Console.WriteLine("Emp Salary = " + e[i].Salary);


                }
            }
        }
    }
    class Student
    {
        string studname;

        public Student(string studname)
        {
            this.Studname = studname;
        }

        public string Studname { get => studname; set => studname = value; }
    }
    class CourseC
    {
        String Coursename;
        Student[] s = new Student[10];
        public CourseC()
        {

        }

        public CourseC(string coursename, Student[] s)
        {
            Coursename1 = coursename;
            this.S = s;
        }

        public string Coursename1 { get => Coursename; set => Coursename = value; }
        internal Student[] S { get => s; set => s = value; }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Student[] s = new Student[] 
                        { new Student("r"),
                        new Student("a"),
                        new Student("t"),
                        new Student("n"),
                        new Student("a"),
                        new Student("p"),
                        new Student("u"),
                        new Student("b"),
                        new Student("h"),
                        new Student("j"),
                        new Student("k"),
                          };
            CourseC c = new CourseC("C#",s);
            for(int i=0;i<=10;i++)
            Console.WriteLine(c.S[i].Studname);

        }
    }
}
