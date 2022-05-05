using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPS
{
    internal class Movie
    {
        string mname;
        string director;
        string producer;
        string mactorname;
        string factorname;
        int rating;
        public Movie()
        {
            mname = "aaaa";
            director = "aers";
            producer = "rrrr";
            mactorname = "eeeee";
            factorname = "sertt";
            rating = 2;
            Console.WriteLine("default constructor");

        }
        public void Setmname(string s1)
        {
            mname = s1;
        }
        public void SetDirector(string s2)
        {
            director = s2;
        }
        public void SetProducer(string s3)
        {
            producer = s3;
        }
        public void SetMactorname(string s4)
        {
            mactorname = s4;
        }
        public void SetFactorname(string s5)
        {
            factorname = s5;
        }
        public void SetRating(int r)
        {
            rating = r;
        }
        public string GetMname()
        {
            return mname;
        }
        public string GetDirector()
        {
            return director;
        }
        public string GetProducer()
        {
            return producer;
        }
        public string GetMactorname()
        {
            return mactorname;
        }

        public string GetFactorname()
        {
            return factorname;
        }
        public int GetReating()
        {
            return rating;
        }

    }
    class Qtest
    {
        static void Main(string[] args)
        {
            Movie m1 = new Movie();

            m1.Setmname("asdf");
            m1.SetDirector("hdhg");
            m1.SetProducer("fdhsd");
            m1.SetFactorname("ertt");
            m1.SetMactorname("ftry");
            m1.SetRating(4);
            Console.WriteLine("Movie Name:\t " + m1.GetMname());
            Console.WriteLine("Movie Director:\t " + m1.GetDirector());
            Console.WriteLine("Movie Producer:\t " + m1.GetProducer());
            Console.WriteLine("Movie Mail Actor:\t " + m1.GetMactorname());
            Console.WriteLine("Movie Femail Actor:\t " + m1.GetFactorname());
            Console.WriteLine("Movie Rating:\t " + m1.GetReating());


            Movie m = new Movie();
            Console.WriteLine("Enter movie name");
            m.Setmname(Console.ReadLine());
            
            Console.WriteLine("Enter movie Director ");
            m.SetDirector(Console.ReadLine());
            
            Console.WriteLine("Enter movie Producer ");
            m.SetProducer(Console.ReadLine());
           
            Console.WriteLine("Enter Mail actor ");
            m.SetMactorname(Console.ReadLine());
            
            Console.WriteLine("Enter Femail Actor Name");
            m.SetFactorname(Console.ReadLine());
            Console.WriteLine("Enter Movie Rating");
            m.SetRating(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Movie Name:\t "+ m.GetMname());
            Console.WriteLine("Movie Director:\t "+ m.GetDirector());
            Console.WriteLine("Movie Producer:\t "+ m.GetProducer());
            Console.WriteLine("Movie Mail Actor:\t "+ m.GetMactorname());
            Console.WriteLine("Movie Femail Actor:\t "+ m.GetFactorname());
            Console.WriteLine("Movie Rating:\t "+ m.GetReating());
           
            


        }
        
    }
}
