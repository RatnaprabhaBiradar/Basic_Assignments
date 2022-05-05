using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.OOPS
{
    internal class Country1
    {
        string countryname;
        int noofstates;
        int noof_language;

        public Country1(string countryname, int noofstates, int noof_language)
        {
            this.Countryname = countryname;
            this.Noofstates = noofstates;
            this.Noof_language = noof_language;
        }

        public string CountryName
        {
            get { return Countryname; }
            set { Countryname = value; }
        }

        public string Countryname { get => countryname; set => countryname = value; }

        public int NoofStates
        {
            get { return Noofstates; }
            set { Noofstates = value; }
        }

        public int Noofstates { get => noofstates; set => noofstates = value; }

        public int NoofLanguages
        {
            get { return Noof_language; }
            set { Noof_language = value; }
        }

        public int Noof_language { get => noof_language; set => noof_language = value; }
    }
    class TestCountry
    {
        static void Main(string[] args)
        {
            Country1 c1 = new Country1("india",28,121);
            c1.CountryName="India";
            c1.NoofStates = 28;
            c1.NoofLanguages = 121;
            Console.WriteLine(" country Name=\t"+c1.CountryName);
            Console.WriteLine(" No of states=\t" + c1.NoofStates);
            Console.WriteLine(" No of Languages Spoken=" + c1.NoofLanguages);

        }
    }
}
