using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Containment
{
    internal class Student
    {
        int studid;
        string studname;
        float percent;
        Batch batch1=new Batch();
        Address add=new Address();
        public Student()
        {

        }

        public Student(int studid, string studname, float percent, Batch batch1, Address add)
        {
            this.Studid = studid;
            this.Studname = studname;
            this.Percent = percent;
            this.Batch1 = batch1;
            this.Add = add;
        }

        public int Studid { get => studid; set => studid = value; }
        public string Studname { get => studname; set => studname = value; }
        public float Percent { get => percent; set => percent = value; }
        internal Batch Batch1 { get => batch1; set => batch1 = value; }
        internal Address Add { get => add; set => add = value; }
    }
    class Batch
    {
        string batctname;
        string subject;
        public Batch()
        {

        }
        public Batch(string batctname, string subject)
        {
            this.Batctname = batctname;
            this.Subject = subject;
        }

        public string Batctname { get => batctname; set => batctname = value; }
        public string Subject { get => subject; set => subject = value; }
    }
    class Address
    {
        string street;
        string city;
        int zipcode;
        public Address()
        {

        }
        public Address(string street, string city, int zipcode)
        {
            this.Street = street;
            this.City = city;
            this.Zipcode = zipcode;
        }

        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }
        public int Zipcode { get => zipcode; set => zipcode = value; }
    }
    class TestConainment
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
           // Student s2 = new Student(5, fsd, 5.6, gggdf, fdfsf, dsfs, fsdfs,5648);
            Console.WriteLine("Enter student id, student name, student percent");
            s1.Studid = Convert.ToInt32(Console.ReadLine());
            s1.Studname = Console.ReadLine();
            s1.Percent = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Batch name and subject");
            s1.Batch1.Batctname = Console.ReadLine();
            s1.Batch1.Subject = Console.ReadLine();
            Console.WriteLine("Enter Address Street, city, Zipcode");
            s1.Add.Street= Console.ReadLine();
            s1.Add.City= Console.ReadLine();
            s1.Add.Zipcode= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Student Id=\t\t{s1.Studid}");
            Console.WriteLine($"Student Name=\t\t{s1.Studname}");
            Console.WriteLine($"Student Percent=\t\t{s1.Percent}");
            Console.WriteLine($"Student Batch Name=\t\t{s1.Batch1.Batctname}");
            Console.WriteLine($"Student Batch Subject=\t\t{s1.Batch1.Subject}");
            Console.WriteLine($"Student Address Street\t\t{s1.Add.Street} \nCity\t\t{s1.Add.City}\nZipcode\t\t{s1.Add.Zipcode}");


        }
    }

}
