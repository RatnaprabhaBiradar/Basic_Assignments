using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Inherit
{
    internal class OverrideC
    {
    }
    class P
    {

        public P()
        {
            Console.WriteLine("Parent");
        }
        public virtual void study()
        {
            Console.WriteLine("In parents Study");
        }
        public void exam()
        {
            Console.WriteLine("In Parents Exam");
        }
    }

    class C1 : P
    {
        public C1()
        {
            Console.WriteLine("In Child 1");
        }
        public override void study()
        {
            Console.WriteLine("In Childs Study");

        }
        public new void exam()
        {
            Console.WriteLine("In childs Exam");
        }
        public virtual void H()
        {
            Console.WriteLine("aaaaaaaaaa");
        }

    }
    class D : C1
    {
        public D()
        {
            Console.WriteLine("In child 2");
        }
        public override void study()
        {
            Console.WriteLine("IN Derived class of D");
        }
        public override void H()
        {
            Console.WriteLine("BBBBBBB");
        }
    }
    class TestOver
    {
        static void Main(string[] args)
        {
            /* P n = new P();
             n.study();
             P x = new C1();
             x.study();
             n.exam();
             x.exam();
             C1 d = new C1();
             P r = new D();
             r.study();
             n.study();
             x.study();

             d.exam();
            D g =       new D();*/
            D a = new D();
            a.H();




        }
    }
    class StringAn
    {
        static void Main(string[] args)
        {
            GrandParent g2 = new GrandParent();

            Console.WriteLine("Enter first string");
            string st1 = Console.ReadLine();
            Console.WriteLine("Enter Second string");
            string st2 = Console.ReadLine();
            int flag = 0;
            for (int i = 0; i < st1.Length; i++)
            {
                for (int j = 0; j < st2.Length; j++)
                {
                    if (st2[j] == st1[i])
                    {
                        flag++;
                        Console.WriteLine(flag);
                    }


                }
            }
            if (flag == st1.Length)
            {
                Console.WriteLine("strings are anagram");
            }
            else
                Console.WriteLine("not equal");

        }
    }


    public class GrandParent
    {
        public int j;
        int age;
        //private protected can not asccess outside assembely or can use only in subclasses
        protected string name;
        //current assembely every n other sub classes
        protected internal int a;
        public GrandParent()
        {
            Console.WriteLine("Grand Parents Contructor");
        }
        public virtual void m1()
        {
            Console.WriteLine("In Grand parents m1() method ");
        }

        public virtual void m2()
        {
            Console.WriteLine("In Grand parents m2() method ");
        }
        //static method can not mark as Virtual
        //we can not override static method
        /* public static virtual void m3()
         {
             Console.WriteLine("In static method of Grand Parents class");
         }*/
        public static void m3()
        {
            Console.WriteLine("Method hiding of Grand parent class ");
        }
    }
    public class Parent : GrandParent
    {
        GrandParent g = new GrandParent();

        int parage;
        string pname;
        public override string ToString()
        {
            return "Over";
        }

        public Parent()
        {

            Console.WriteLine("Parents Constructor");
        }
        public override void m1()
        {
            Console.WriteLine("In parents overridden method m1()");
        }
        sealed public override void m2()
        {
            Console.WriteLine("In parents overridden method m2()");
        }

        /*public  new static void  m3()
        {
            Console.WriteLine("Overloaded method of parent class");
        }
       */

    }
    public class child : Parent
    {

        int cage;
        string cname;
        public child()
        {
            Console.WriteLine("In Childs Constructor");
        }
        public override void m1()
        {
            Console.WriteLine("In Childs overridden method m1()");
        }
        //can not override sealed method
        /* public override void m2()
         {
             Console.WriteLine("In childs overridden method m1()");
         }*/
    }
    class Testoverl
    {
        static void Main(string[] args)
        {
            GrandParent g1 = new Parent();
            g1.m1();

            g1.m2();
            Parent.m3();
            GrandParent.m3();
            GrandParent gp = new child();
            gp.m1();
            gp.m2();
            Console.WriteLine(g1.ToString());


        }
    }
    class sdfg
    {
        public static void rsd(int n)
        {
            if(n>0)
            {
                Console.WriteLine(n);
                rsd(n - 1);
            }
        }
        public static int fact(int n)
        {
            if (n == 1)
                return 1;
            else
            {
                int ans = fact(n - 1);
                return n * ans;
            }
        }
        static void Main(string[] args)
        {
            int fact1=sdfg.fact(5);
            Console.WriteLine(fact1);
        }
    }
}
