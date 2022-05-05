using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPS
{
    internal class Car
    {
        public string brand;
        public long price;
        public string color;
        public int manfyear;
        public string fuealType;
        public void display()
        {

        }
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.brand = "Honda";
            c1.price = 2000000;
            c1.color = "black";
            c1.manfyear = 2021;
            c1.fuealType = "Petrol";
            Car c2 = new Car();
            c2.brand = "Toyota";
            c2.price = 3000000;
            c2.color = "Red";
            c2.manfyear = 2022;
            c2.fuealType = "Dieael";
            Console.WriteLine(c1);
            Console.WriteLine(c2);
        }
    }
}
