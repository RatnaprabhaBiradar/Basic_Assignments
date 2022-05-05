using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace HomeAssignment.AdvanceTraining
{
    internal class CollectionNew
    {

    }
    public class Emp:IComparable
    {
        public int EmpId { get;
            set;
        }
        public Double Salary { get; set; }
        public string Name { get; set; }
        public int CompareTo(object? obj)
        {
            Emp e2 = (Emp)obj;
            if (this.Salary > e2.Salary)
                return 1;
            else
                return 0;

         }
        public override string ToString()
        {
            return $" Id= {EmpId}\tName= {Name}\tSalary= {Salary}";
        }
    }
    class Test2 : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Emp e1 = (Emp)x;
            Emp e2 = (Emp)y;
            if(e1.Salary>e2.Salary)
                return 1;
            else
                return 0;
           
        }
    }

    public class Test
    {
        static void Main(string[] args)
        {
            Emp e1 = new Emp { EmpId = 1,Salary=120000 };
            Emp e2 = new Emp { EmpId=2,Salary=1756489};
            int result=e1.CompareTo(e2);
            if(result==1)
            {
                Console.WriteLine("Salary of First Employee is Greater");
            }
            else
                Console.WriteLine("Salary of second Employee is Greater");
            Test2 t = new Test2();
            int a=t.Compare(e1, e2);
            if(a == 1)
            {
                Console.WriteLine("Salary of First Employee is Greater");
            }
            else
                Console.WriteLine("Salary of second Employee is Greater");


        }
    }
    class test3
    {
        static void Main(string[] args)
        {
            List < Emp > e= new List<Emp>()
            {
                new Emp{EmpId=1,Name="Ratna",Salary=1500000},
                new Emp{EmpId=2,Name="Rita",Salary=500000},
                new Emp{EmpId=3,Name="shobha",Salary=180000},
                new Emp{EmpId=4,Name="Radha",Salary=1200000},
                new Emp{EmpId=5,Name="Neha",Salary=190000},

            };
            foreach(var p in e)
            {
                Console.WriteLine(p);
            }

        }        
    }
    class Stack12
    {
        static void Main(string[] args)
        {
             Stack<int> i = new Stack<int>();

              i.Push(10);
              i.Push(20);
              i.Push(30);
              foreach(var a in  i)
                  Console.WriteLine(a);
              Console.WriteLine("***************");
             int x= i.Pop();
              Console.WriteLine(x);
              foreach (var a in i)
                  Console.WriteLine(a);
            Console.WriteLine("----------------------");

              
            Stack s = new Stack();
            s.Push(10);
            s.Push(20);
            s.Push(30);
            s.Push(40);
            foreach(var c in s)
                Console.WriteLine(c);
            Console.WriteLine("------------------------");
            Stack<Emp> em1 = new Stack<Emp>();
            em1.Push(new Emp { EmpId = 1, Name = "Ratna", Salary = 75000 });
            em1.Push(new Emp { EmpId = 2, Name = "Jay", Salary = 65000 });
            em1.Push(new Emp { EmpId = 3, Name = "Krishang", Salary = 90000 });
            em1.Push(new Emp { EmpId = 4, Name = "Praj", Salary = 45000 });

            foreach(var u in em1)
                Console.WriteLine(u);
            Console.WriteLine("-------------------------");
            Emp ew= em1.Peek();//returns last stack object without removing it
            Console.WriteLine(ew);
            em1.Pop();//removes and reaturn the last object from stack
            Console.WriteLine("*************************");
            foreach (var u in em1)
                Console.WriteLine(u);
        }
    }

    class TestQueue
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue("Ratna");
            q.Enqueue(20);
            q.Enqueue(10.6f);
            q.Enqueue(89000);
            foreach(var a in q)
                Console.WriteLine(a);
            Console.WriteLine("************");
            q.Dequeue();//Removes and returns the first element from queue
            foreach (var a in q)
                Console.WriteLine(a);
            Console.WriteLine("**************");
            Console.WriteLine(q.Count);//displays number of elements in queue
           Queue k= (Queue)q.Clone();//???????????
            Console.WriteLine("*******************");
            foreach (var a in k)
                Console.WriteLine(a);
            Console.WriteLine(q.Contains(20));//An object is present in Queue or not
            Console.WriteLine("****************************");
            Console.WriteLine("Queue Generic");
            Queue<Emp> e2 = new Queue<Emp>();
            e2.Enqueue(new Emp { EmpId = 1, Name = "Ratna", Salary = 75000 });
            e2.Enqueue(new Emp { EmpId = 2, Name = "Jay", Salary = 65000 });
            e2.Enqueue(new Emp { EmpId = 3, Name = "Krishang", Salary = 90000 });
            e2.Enqueue(new Emp { EmpId = 4, Name = "Praj", Salary = 45000 });
            foreach(var ed in e2)
                Console.WriteLine(ed);
            e2.Dequeue();
            Console.WriteLine("*****************");
            foreach (var ed in e2)
                Console.WriteLine(ed);
            Console.WriteLine(e2.Count());
            Emp e3 = e2.Peek();
            Console.WriteLine(e3);
            
        }
    }

    class Emp1
    {
        public int Empid { get; set; }
        public string EmpName { get; set; }
    }
    class Dept
    {
        public string DeptName { get; set; }
       public List<Emp1> ep = new List<Emp1>();
    }
    class TestDept
    {
        static void Main(string[] args)
        {
            List<Dept> d = new List<Dept>()
            {
                new Dept{DeptName="Prod", ep={new Emp1{EmpName="Ratna"}, new Emp1 { EmpName = "neha" }, new Emp1 { EmpName = "sachin" } } },

                new Dept{DeptName="Service", ep={new Emp1{EmpName="Ajay"},new Emp1{EmpName="shredhha"} } },
                new Dept{DeptName="Mantenance", ep={new Emp1{EmpName="Shekhar"}, new Emp1 { EmpName = "Mohan" }, new Emp1 { EmpName = "Swati" } } },
                new Dept{DeptName="Sestain", ep={new Emp1{EmpName="Prajkta"}, new Emp1 { EmpName = "Vachi" }, new Emp1 { EmpName = "Advay" } } }

            };
            foreach(Dept d1 in d)
            {
                Console.WriteLine(d1.DeptName );
                foreach(Emp1 e1 in d1.ep)
                {
                    Console.WriteLine($"\t{e1.EmpName}");
                }
                Console.WriteLine();
            }
        }
    }
    public delegate int Mydel(int a, int b);
    class DelegMulti
    {
       
        public int Add(int a,int b)
        {
            return a + b;
        }
        public int sub(int a, int b)
        {
            return a - b;
        }
        public int Multi(int a, int b)
        {
            return a * b;
        }
        
    }
    class TestDel
    {
        static void Main(string[] args)
        {
            DelegMulti m = new DelegMulti();
            Mydel del = new Mydel(m.Add);
            del +=new  Mydel (m.sub);
            del += new Mydel(m.Multi);
            Delegate[] list = del.GetInvocationList();
            foreach  (Delegate d in list)
            {
                Console.WriteLine(d.Method);
                Console.WriteLine(d.DynamicInvoke(20,30));
            }

        }
    }
    public delegate void MyDelegate(string s);
    class UperLower
    {
        public void UperCase(string s)
        {
            s = s.ToUpper();
            Console.WriteLine(s);
        }
        public void LowerCase(string s)
        {
            s = s.ToLower();
            Console.WriteLine(s);
        }

    }
    class TestUpper
    {
        static void Main(string[] args)
        {
            UperLower ul = new UperLower();
            MyDelegate m1 = new MyDelegate(ul.UperCase);
            m1 += new MyDelegate(ul.LowerCase);
            Delegate[] list = m1.GetInvocationList();

            foreach (Delegate d in list)
            {
                Console.WriteLine(d.Method);
                d.DynamicInvoke("Ratna");
                
            }

        }
    }

}
