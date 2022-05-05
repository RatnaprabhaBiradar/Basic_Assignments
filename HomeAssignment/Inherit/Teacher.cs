using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Inherit
{
    internal class Teacher
    {
        int tid;
        string tname;
        long mobileno;
        public Teacher()
        {

        }

        public Teacher(int tid, string tname, long mobileno)
        {
            this.Tid = tid;
            this.Tname = tname;
            this.Mobileno = mobileno;
            Console.WriteLine("In Teacher Class Constructor");
        }

        public int Tid { get => tid; set => tid = value; }
        public string Tname { get => tname; set => tname = value; }
        public long Mobileno { get => mobileno; set => mobileno = value; }
    }

    class HourlyBased:Teacher
    {
        float rateperhr;
        int hr;
        public HourlyBased()
        {

        }

        public HourlyBased(int tid1,string tname1,long mobno,float  rateperhr, int hr):base(tid1,tname1,mobno)
        {
            this.rateperhr = rateperhr;
            this.hr = hr;
            Console.WriteLine("In hourely based Class Constructor");
        }
        public void salary()
        {
            float sal = rateperhr * hr;
            Console.WriteLine("Salary of hourely based Teacher= "+sal);
        }
    }

    class SalBased:Teacher
    {
        int salary;
        public SalBased()
        {

        }

        public SalBased(int tid,string tname,long mobno,int salary):base(tid,tname,mobno)
        {
            this.salary = salary;
            Console.WriteLine("In Salary based Class Constructor");
        }
        public void Salary1()
        {
            Console.WriteLine("Salary Of Salary Based Teacher= "+salary);
        }
    }

    class TestTeacherIn
    {
        static void Main(string[] args)
        {
            
            
            HourlyBased h1 = new HourlyBased(1, "Neha", 9561008753, 1000.5f, 8);
            h1.salary();
            SalBased s1 = new SalBased(2, "Mugdha", 9561227278, 55555);
            s1.Salary1();
        }
    }
}
