using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Containment
{
    internal class Flat
    {
        int flatno;
        string buildingname;
        Owner flatowner = new Owner();
        public Flat()
        {

        }

        public Flat(int flatno, string buildingname, Owner flatowner)
        {
            this.Flatno = flatno;
            this.Buildingname = buildingname;
            this.Flatowner = flatowner;
        }

        public int Flatno { get => flatno; set => flatno = value; }
        public string Buildingname { get => buildingname; set => buildingname = value; }
        internal Owner Flatowner { get => flatowner; set => flatowner = value; }
    }
    class Owner
    {
        string ownername;
        int age;
        string profession;
        char gender;
        public Owner()
        {

        }

        public Owner(string ownername, int age, string profession, char gender)
        {
            this.Ownername = ownername;
            this.Age = age;
            this.Profession = profession;
            this.Gender = gender;
        }

        public string Ownername { get => ownername; set => ownername = value; }
        public int Age { get => age; set => age = value; }
        public string Profession { get => profession; set => profession = value; }
        public char Gender { get => gender; set => gender = value; }
    }
    class TestFlat
    {
        static void Main(string[] args)
        {
            Flat f1 = new Flat();
            Console.WriteLine("Enter flat number, building name");
            f1.Flatno = Convert.ToInt32(Console.ReadLine());
            f1.Buildingname = Console.ReadLine();
            Console.WriteLine("enter Owner nmae,age,profession and gender");
            f1.Flatowner.Ownername = Console.ReadLine();
            f1.Flatowner.Age= Convert.ToInt32(Console.ReadLine());
            f1.Flatowner.Profession = Console.ReadLine();
            f1.Flatowner.Gender = Convert.ToChar(Console.Read());
            Console.WriteLine(f1.Flatno);
            Console.WriteLine(f1.Buildingname);
            Console.WriteLine(f1.Flatowner.Ownername);
            Console.WriteLine(f1.Flatowner.Age);
            Console.WriteLine(f1.Flatowner.Profession);
            Console.WriteLine(f1.Flatowner.Gender);
            Flat f2 = new Flat();
            f2.Flatno = 123;
            f2.Buildingname = "swar";
            f2.Flatowner.Age = 54;
            f2.Flatowner.Ownername = "aaaaa";
            f2.Flatowner.Profession = "Doctor";
            f2.Flatowner.Gender = 'F';
            Console.WriteLine(f2.Flatno);
            Console.WriteLine(f2.Buildingname);
            Console.WriteLine(f2.Flatowner.Ownername);
            Console.WriteLine(f2.Flatowner.Age);
            Console.WriteLine(f2.Flatowner.Profession);
            Console.WriteLine(f2.Flatowner.Gender);




        }
        
    }
}
