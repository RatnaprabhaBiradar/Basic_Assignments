using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Inherit
{
    internal class Pen1
    {
        Refill r=new Refill();
        int caplength;
        string brand;
        public Pen1()
        { 

        }

        public Pen1(Refill r, int caplength, string brand)
        {
            this.R = r;
            this.Caplength = caplength;
            this.Brand = brand;
        }

        public int Caplength { get => caplength; set => caplength = value; }
        public string Brand { get => brand; set => brand = value; }
        internal Refill R { get => r; set => r = value; }
    }
    class Refill
    {
        string inkcolor;
        int length;
        Nib n=new Nib();
        public Refill()
        {

        }

        public Refill(string inkcolor, int length, Nib n)
        {
            this.Inkcolor = inkcolor;
            this.Length = length;
            this.N = n;
        }

        public string Inkcolor { get => inkcolor; set => inkcolor = value; }
        public int Length { get => length; set => length = value; }
        internal Nib N { get => n; set => n = value; }
    }
    class Nib
    {
        string mattype;
        int width;
        public Nib()
        {

        }

        public Nib(string mattype, int width)
        {
            this.Mattype = mattype;
            this.Width = width;
        }

        public string Mattype { get => mattype; set => mattype = value; }
        public int Width { get => width; set => width = value; }
    }
    class Testpen
    {
        static void Main(string[] args)
        {
            Pen1 p1 = new Pen1();
            p1.Brand = "Parker";
            p1.Caplength = 2;
            p1.R.Inkcolor = "Blue";
            p1.R.Length = 5;
            p1.R.N.Mattype = "XYZ";
            p1.R.N.Width = 1;
            Console.WriteLine($"Pen Brand is --- {p1.Brand}");
            Console.WriteLine($"Pen CapLength is --- {p1.Caplength}");
            Console.WriteLine($"Pen Refill Ink color is --- {p1.R.Inkcolor}");
            Console.WriteLine($"Pen refill Length is --- {p1.R.Length}");
            Console.WriteLine($"Pen Refill Nib Matterial type --- {p1.R.N.Mattype}");
            Console.WriteLine($"Pen Prfill Nib Width is --- {p1.R.N.Width}");

        }
    }
}
