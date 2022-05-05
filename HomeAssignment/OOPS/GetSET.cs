using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPS
{
   
       
    internal class GetSET
    {

        long adharno;
        string name;
        string voteCast;
        public void SetAdharno(long ad)
        {
            adharno = ad;
        }
        public long GetAdharno()
        {
            return adharno;
        }
        public void SetName(string nm)
        {
            name = nm;
        }
        public string Getname()
        {
            return name;
        }
        public void SetVotecast(string vc)
        {
            voteCast = vc;
        }
        public string GetVotecast()
        {
            return voteCast;
        }
       

    }
    class Test
    {
        static void Main(string[] args)
        {
            GetSET c1 = new GetSET();
            Console.WriteLine("Enter Adhar Card Number");
            c1.SetAdharno(Convert.ToInt64(Console.ReadLine()));
            Console.WriteLine("Enter Name");
            c1.SetName(Console.ReadLine());
            Console.WriteLine("Enter to cast vote");
            c1.SetVotecast(Console.ReadLine());
            Console.WriteLine("Details of voter");
            Console.WriteLine("Adhar Card No:\t"+c1.GetAdharno());
            Console.WriteLine("Name :\t"+c1.Getname());
            Console.WriteLine("Vote Casted:\t"+c1.GetVotecast());
        }
    }
}
