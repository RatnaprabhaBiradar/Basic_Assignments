using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Containment
{
    internal class EMP
    {
        int empid;
        string name;
        double salary;
        Department dep = new Department();
        public EMP()
        {

        }

        public EMP(int empid, string name, double salary, Department dep)
        {
            this.Empid = empid;
            this.Name = name;
            this.Salary = salary;
            this.Dep = dep;
        }

        public int Empid { get => empid; set => empid = value; }
        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }
        internal Department Dep { get => dep; set => dep = value; }
    }
    class Department
    {
        public int Deptid
            {
            get;
            set;
             }
        public string Deptname
        {
            get;
            set;
        }
        public string Deptmanager
        {
            get;
            set;
        }

       /* int deptid;
        string deptname;
        string deptmanager;
        public Department()
        {

        }

        public Department(int deptid, string deptname, string deptmanager)
        {
            this.Deptid = deptid;
            this.Deptname = deptname;
            this.Deptmanager = deptmanager;
        }

        public int Deptid { get => deptid; set => deptid = value; }
        public string Deptname { get => deptname; set => deptname = value; }
        public string Deptmanager { get => deptmanager; set => deptmanager = value; }
        
        */
    }
    class testEMP
    {
        static void Main(string[] args)
        {
            EMP e1 = new EMP();
            Console.WriteLine("Enter employee id, name and salary");
            e1.Empid = Convert.ToInt32(Console.ReadLine());
            e1.Name = Console.ReadLine();
            e1.Salary = Convert.ToDouble(Console.ReadLine());
            e1.Dep.Deptid = 1;
            e1.Dep.Deptname = "rrrr";
            e1.Dep.Deptmanager = "qqqq";
            
          


        }
    }
}
