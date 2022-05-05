using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.AdvanceTraining
{
    internal class Course1
    {
    }
    class course
    {
        public int Cid { get; set; }
        public string CName { get; set; }
        public double Fees { get; set; }
    }
    class TestCourse
    {
        static void Main(string[] args)
        {
            List<course> Lcourse = new List<course>()
              {
                  new course{Cid=1,CName="Java Full Stack",Fees=38000 },
                  new course{Cid=2,CName=".Net Full Stack",Fees=50000 },
                  new course{Cid=3,CName="C#",Fees=22000 },
                  new course{Cid=4,CName="SQL",Fees=18000 },
                  new course{Cid=5,CName="Java Full Stack",Fees=38000 },
                  new course{Cid=6,CName="Java Full Stack",Fees=38000 },
                  new course{Cid=7,CName="C#",Fees=22000 },
                  new course{Cid=8,CName="SQL",Fees=18000 },
                  new course{Cid=9,CName="Java Full Stack",Fees=38000 },

              };
            var result = from p in Lcourse
                         where p.CName.Contains("C#")
                         select p;

            foreach (var d in result)
            {
                Console.WriteLine($"Course Id={d.Cid}\t Course Name={d.CName}\t Corse Fees={d.Fees}");
            }
            var result1 = from p in Lcourse
                          where p.CName.Contains("Java Full Stack")
                          select p;
            Console.WriteLine("----------------------------------------");
            foreach (var d in result1)
            {
                Console.WriteLine($"Course Id={d.Cid}\t Course Name={d.CName}\t Corse Fees={d.Fees}");
            }
            var result2 = from p in Lcourse
                          orderby p.CName
                          select p;
            Console.WriteLine("----------------------------------------");
            foreach (var d in result2)
            {
                Console.WriteLine($"Course Id={d.Cid} \t Course Name={d.CName} \t Corse Fees={d.Fees}");
            }
            var result3 = from p in Lcourse
                          orderby p.Fees descending
                          select p;
            Console.WriteLine("----------------------------------------");
            foreach (var d in result3)
            {
                Console.WriteLine($"Course Id={d.Cid}\t Course Name={d.CName}\t Corse Fees={d.Fees}");
            }
            var result4 = from p in Lcourse
                          where p.CName.Contains("C#") || p.Fees < 35000
                          select p;

            Console.WriteLine("----------------------------------------");
            foreach (var d in result4)
            {
                Console.WriteLine($"Course Id={d.Cid}\t Course Name={d.CName}\t Corse Fees={d.Fees}");
            }
            var result5 = from p in Lcourse
                          where p.CName.StartsWith('s')
                          select p;
            Console.WriteLine("----------------------------------------");
            foreach (var d in result5)
            {
                Console.WriteLine($"Course Id={d.Cid}\t Course Name={d.CName}\t Corse Fees={d.Fees}");
            }
        }
    }
 }
