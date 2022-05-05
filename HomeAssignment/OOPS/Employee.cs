using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPS
{
    internal class Employee
    {
        int id;
        string name;
        long salary;
        public void SetId(int id)
        {
            this.id = id;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetSalary(long salary)
        {
            this.salary = salary;
        }
        public int GetId()
        {
            return id;
        }
        public string GetName()
        {
            return name;

        }
        public long GetSalary()
        {
            return salary;
        }
    }
    class EmpTest
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Console.WriteLine("Enter Employee Id");
            e1.SetId(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter Employee name");
            e1.SetName(Console.ReadLine());
            Console.WriteLine("Enter Employee Salary");
            e1.SetSalary(Convert.ToInt64(Console.ReadLine()));
            Console.WriteLine($"Employee Id :\t{e1.GetId()}");
            Console.WriteLine($"Employee Name: \t{e1.GetName()}");
            Console.WriteLine($"Employee Salary :\t{e1.GetSalary()}");
        }
    }
}
