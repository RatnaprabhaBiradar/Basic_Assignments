using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Inherit
{
    internal class Person
    {
        int id;
        string name;
        Vehicle v=new Vehicle();
        public override string ToString()
        {
            return $"id={id} name={name} vname={v.Vname} vid={v.Vid}";
        }
        public Person()
        {
            
        }

        public Person(int id, string name,Vehicle v)
        {
            this.Id = id;
            this.Name = name;
            this.V = v;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        internal Vehicle V { get => v; set => v = value; }
    }
    class Vehicle
    {
        int vid;
        string vname;
        public Vehicle()
        {

        }

        public Vehicle(int vid, string vname)
        {
            this.Vid = vid;
            this.Vname = vname;
        }

        public int Vid { get => vid; set => vid = value; }
        public string Vname { get => vname; set => vname = value; }
    }
    class TestPerson
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Console.WriteLine("Enter Person Id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Person Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Vehical ID");
            int vid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Vehical Name");
            string vname = Console.ReadLine();
            p1.Id = id;
            p1.Name = name;
            p1.V.Vid = vid;
            p1.V.Vname = vname;
            Console.WriteLine($"Person Id : {p1.Id}");
            Console.WriteLine($"Person Name : {p1.Name}");
            Console.WriteLine($"Vehical Id : {p1.V.Vid}");
            Console.WriteLine($"Vehical Name : {p1.V.Vname}");

            Console.WriteLine(p1);


        }
    }
}
