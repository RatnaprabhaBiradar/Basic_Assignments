using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPS
{
    internal class Pen1
    {
        string brand;
        string color;
        int price;
        public Pen1()
        {
            brand ="AAAA";
            color = "Blue";
            price = 10;
        }
        public Pen1(string brand,string color,int price)
        {
            this.brand = brand;
            this.color = color;
            this.price = price;
        }
        public void SetBrand(string brand)
        {
            this.brand = brand;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }
        public void SetPrice(int price)
        {
            this.price = price;
        }
        public string GetBrand()
        {
            return brand;
        }
        public string GetColor()
        {
            return color;
        }
        public int GetPrice()
        {
            return price;
        }
    }
    class TestPen
    {
        static void Main(string[] args)
        {
            Pen1 p1 = new Pen1();
            Console.WriteLine($" Pen Brand :\t{p1.GetBrand()}");
            Console.WriteLine($" Pen Color :\t{p1.GetColor()}");
            Console.WriteLine($" Pen Brand :\t{p1.GetPrice()}");
            Console.WriteLine("Enter Brand for Pen");
            p1.SetBrand(Console.ReadLine());
            Console.WriteLine("Enter Color of Pen");
            p1.SetColor(Console.ReadLine());
            Console.WriteLine("Enter Price for Pen");
            p1.SetPrice(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($" Pen Brand :\t{p1.GetBrand()}");
            Console.WriteLine($" Pen Color :\t{p1.GetColor()}");
            Console.WriteLine($" Pen Brand :\t{p1.GetPrice()}");
            Console.WriteLine("\n");
            Pen1 p2 = new Pen1("Renold", "black", 45);
            Console.WriteLine($" Pen Brand :\t{p2.GetBrand()}");
            Console.WriteLine($" Pen Color :\t{p2.GetColor()}");
            Console.WriteLine($" Pen Brand :\t{p2.GetPrice()}");

        }
    }
}
