using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignment.Inherit
{
    internal class Order
    {
        int order;
        string orderdate;
        Customer cst = new Customer();
        Item itm = new Item();
        public Order()
        {

        }

        public Order(int order, string orderdate, Customer cst, Item itm)
        {
            this.Ordr = order;
            this.Orderdate = orderdate;
            this.Cst = cst;
            this.Itm = itm;
        }

        public int Ordr { get => order; set => order = value; }
        public string Orderdate { get => orderdate; set => orderdate = value; }
        internal Customer Cst { get => cst; set => cst = value; }
        internal Item Itm { get => itm; set => itm = value; }
    }
    class Customer
    {
        int custid;
        string custname;
        Address ad = new Address();
        public Customer()
        {

        }

        public Customer(int custid, string custname, Address ad)
        {
            this.Custid = custid;
            this.Custname = custname;
            this.Ad = ad;
        }

        public int Custid { get => custid; set => custid = value; }
        public string Custname { get => custname; set => custname = value; }
        internal Address Ad { get => ad; set => ad = value; }
    }
    class Address
    {
        string add1;
        string city;
        int pincode;
        public Address()
        {

        }

        public Address(string add1, string city, int pincode)
        {
            this.Add1 = add1;
            this.City = city;
            this.Pincode = pincode;
        }

        public string Add1 { get => add1; set => add1 = value; }
        public string City { get => city; set => city = value; }
        public int Pincode { get => pincode; set => pincode = value; }
    }
    class Item
    {
        int itemid;
        string itemname;
        int price;
        public Item()
        {

        }

        public Item(int itemid, string itemname, int price)
        {
            this.Itemid = itemid;
            this.Itemname = itemname;
            this.Price = price;
        }

        public int Itemid { get => itemid; set => itemid = value; }
        public string Itemname { get => itemname; set => itemname = value; }
        public int Price { get => price; set => price = value; }
    }
    class TestOrder
    {
        static void Main(string[] args)
        {
            Order r1 = new Order();
            r1.Orderdate = "10/2/2022";
            r1.Ordr = 1;
            r1.Itm.Itemid = 5;
            r1.Itm.Itemname = "asd";
            r1.Itm.Price = 5600;
            r1.Cst.Custid = 2;
            r1.Cst.Custname = "XYZ";
            r1.Cst.Ad.Add1 = "rtyyg";
            r1.Cst.Ad.City = "Pune";
            Console.WriteLine($"{r1.Orderdate}");
            Console.WriteLine(r1.Ordr);
            Console.WriteLine(r1.Itm.Itemid);
            Console.WriteLine(r1.Itm.Itemname);
            Console.WriteLine(r1.Itm.Price);
            Console.WriteLine(r1.Cst.Custid);
            Console.WriteLine(r1.Cst.Custname);
            Console.WriteLine(r1.Cst.Ad.Add1);
            Console.WriteLine(r1.Cst.Ad.City);

            
        }
            
    }
    
        
   
}
