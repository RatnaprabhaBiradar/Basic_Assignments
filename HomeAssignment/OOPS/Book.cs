using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPS
{
    internal class Book
    {
        public string name;
        public string author;
        public int volume;
        public int price;
        public string publication;
        public void setdata()
        {
            Console.WriteLine("\nEnter name of book");
            name = Console.ReadLine();
            Console.WriteLine("Enter name of Author");
            author = Console.ReadLine();
            Console.WriteLine("Enter Volume");
            volume = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Price");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Publication");
            publication = Console.ReadLine();
        }
        public void Displaydata()
        {
            Console.WriteLine($"Name:\t{name}\nAuthor:\t{author}\nVolume:\t{volume}\nPrice:\t{price}\nPublication:\t{publication}");
        }
    }
    class test
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            Book b2 = new Book();
            b1.name = "abcd";
            b1.author = "RRRRR";
            b1.volume = 2;
            b1.price = 245;
            b1.publication = "xyz";
            b1.Displaydata();
            b2.setdata();
            b2.Displaydata();
        }
    }
}
