using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Inherit
{
    internal class OverLoadVolume
    {
        public OverLoadVolume()
        {

        }
        public double volume1(double r)
        {
            return (4 / 3 * 22 / 7 * (Math.Pow(r, 3)));

        }
        public double volume1(double h, double r)
        {
            return (22 / 7 * r * h);
        }
        public double volume1(double l,double b,double h)
        {
            return l * b * h;
        }
    }
    class TestOverLoadVolume
    {
        static void Main(string[] args)
        {
            OverLoadVolume ov = new OverLoadVolume();
            Console.WriteLine("Volume with 1 Argument: "+ov.volume1(8.5));
            Console.WriteLine("Volume Overloaded with 2 arguments: "+ov.volume1(5.6,4));
            Console.WriteLine("Volume Overloaded with 3 arguments: "+ov.volume1(5.1,4,6.5));

        }
    }
}
