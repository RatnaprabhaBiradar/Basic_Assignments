using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.AdvanceTraining
{
    internal class Linquary1
    {
    }
    class Product
    {
        public int ProdId { get; set; }
        public string Name { get; set; }
        public double price { get; set; }
    }
    class Employee
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public double salary { get; set; }
        public string city { get; set; }
    }
    class TestProd
    {
        static void Main(string[] args)
        {
            List<Product> productl = new List<Product>()
            {
                new Product{ProdId=1,Name="HP laptop",price=34000},
                new Product{ProdId=2,Name="Lenovo laptop",price=38000},
                new Product{ProdId=3,Name="Dell laptop",price=37000},
                new Product{ProdId=4,Name="Acer laptop",price=340850},
                new Product{ProdId=5,Name="Apple laptop",price=94000},
                new Product{ProdId=6,Name="Samsung laptop",price=39000},
                new Product{ProdId=7,Name="Toshiba laptop",price=36000},
                new Product{ProdId=8,Name="Dell laptop",price=42000}
            };
            List<Employee> Emplist = new List<Employee>()
            {
                new Employee{Id=1,EmpName="Radha",city="Pune",salary=45000},
                new Employee{Id=2,EmpName="Prajkta",city="Mumbai",salary=48000},
                new Employee{Id=3,EmpName="Nilesh",city="Pune",salary=34000},
                new Employee{Id=4,EmpName="Deepak",city="Pune",salary=64000},
                new Employee{Id=5,EmpName="Maya",city="Hydrabad",salary=75000},
                new Employee{Id=6,EmpName="Rutuja",city="Benglore",salary=45000},
                new Employee{Id=7,EmpName="Hemant",city="Hydrabad",salary=47000},
                new Employee{Id=9,EmpName="Neha",city="Mumbai",salary=34000},
                new Employee{Id=10,EmpName="Anirudh",city="Nashik",salary=45890},
                new Employee{Id=11,EmpName="Shruti",city="Pune",salary=42000},
                new Employee{Id=12,EmpName="Aniket",city="Benglore",salary=42000},
                new Employee{Id=13,EmpName="Gauri",city="Nashik",salary=46000},
            };
             var result = from p in productl
                          where p.price >35000 && p.price<38000
                          orderby p.price//shows in assending order
                          select p;
             foreach ( var data in result)
             {
                 Console.WriteLine($"{data.Name}\t{data.price}");
             }
             Console.WriteLine("*************************");
             var result1 = from p in productl
                          where p.Name.StartsWith('L')||p.Name.StartsWith('l')
                          orderby p.price
                          select p;
             foreach (var data in result1)
             {
                 Console.WriteLine($"{data.Name}\t{data.price}");
             }

             Console.WriteLine("*************************");
             var result2 = from p in productl
                           where p.Name.Contains("Dell")
                           orderby p.price descending
                           select p;
             foreach (var data in result2)
             {
                 Console.WriteLine($"{data.Name}\t{data.price}");
             }
             Console.WriteLine("*************************");
            var result3 = from p in Emplist
                          where p.salary > 45000
                          select p;
            foreach (var data in result3)
            {
                Console.WriteLine($"{data.Id}\t{data.EmpName}\t{data.salary}\t{data.city}");
            }
            Console.WriteLine("*************************");
            var result4 = from p in Emplist
                          orderby p.EmpName
                          select p;
            foreach (var data in result4)
            {
                Console.WriteLine($"{data.Id}\t{data.EmpName}\t{data.salary}\t{data.city}");
            }
            Console.WriteLine("*************************");
            var result5 = from p in Emplist
                          where p.city.Contains("Mumbai")
                          select p;
            foreach (var data in result5)
            {
                Console.WriteLine($"{data.Id}\t{data.EmpName}\t{data.salary}\t{data.city}");
            }
            Console.WriteLine("*************************");
            var result6 = from p in Emplist
                          orderby p.salary descending
                          select p;
            foreach (var data in result6)
            {
                Console.WriteLine($"{data.Id}\t{data.EmpName}\t{data.salary}\t{data.city}");
            }
            Console.WriteLine("*************************");
            var result7 = from p in Emplist
                          where p.EmpName.StartsWith('A') || p.EmpName.StartsWith('K')
                          select p;
            foreach (var data in result7)
            {
                Console.WriteLine($"{data.Id}\t{data.EmpName}\t{data.salary}\t{data.city}");
            }
            Console.WriteLine("*************************");
            var result8 = from p in Emplist
                          where p.city.Contains("Pune") && p.salary < 35000
                          select p;
            foreach (var data in result8)
            {
                Console.WriteLine($"{data.Id}\t{data.EmpName}\t{data.salary}\t{data.city}");
            }


        }
    }    
              
}


   

