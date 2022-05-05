using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HomeAssignment.MyCollection
{
    internal class FirstArrList
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();
            a1.Add("Ratnaprabha");
            a1.Add(90);
            a1.Add("ratnajbiradar@gmail.com");
            a1.Add("pune");
            a1.Insert(1, "Jayvant");
            for(int i=0;i<a1.Count;i++)
                Console.WriteLine(a1[i]);
            Console.WriteLine("--------------------------");
            Console.WriteLine("After Remove Operation");
            a1.Remove("pune");
            for (int i = 0; i < a1.Count; i++)
                Console.WriteLine(a1[i]);
            a1.Add("pune");
            int a = a1.IndexOf("pune");
            a1.RemoveAt(a);
            Console.WriteLine("--------------------------");
            for (int i = 0; i < a1.Count; i++)
                Console.WriteLine(a1[i]);
            Console.WriteLine("--------------------------");
            a1.Reverse();
            for (int i = 0; i < a1.Count; i++)
                Console.WriteLine(a1[i]);
            a1.Add("asd");
            a1.Add("dfgh");
            a1.Add("2");
            a1.Add(10);
            Console.WriteLine("--------------------------");
            for (int i = 0; i < a1.Count; i++)
                Console.WriteLine(a1[i]);
            int b = a1.IndexOf("asd");
            a1.RemoveRange(b, 2);
            Console.WriteLine("--------------------------");
            for (int i = 0; i < a1.Count; i++)
                Console.WriteLine(a1[i]);           
        }
    }
    class Hashtable12
    {
        static void Main(string[] args)
        {
            int i = -10;
            for(;Convert.ToBoolean(Convert.ToInt32(i));Console.WriteLine(i++))
            {

            }
        }
    }
   
}
