using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Second
    {
        public string name;
        public int price;

        public virtual void Details()
        {
            Console.WriteLine("My phone is " +  name  + " " +  "and price is "  +  price);
        }
    }
    class SoftwareDetails : Second
    {
        public string androidversion;
        public SoftwareDetails(String name, int price, string androidversion)
        {
            this.name = name;
            this.price = price;
            this.androidversion = androidversion;

        }
        public override void Details()
        {
            Console.WriteLine("my phone is "  +  name +  " " +  " and price is "  +  price  + " " + "  with androidversion " + "  " +  androidversion);

        }
    }
    class HardwareDetails : Second
    {
        public string glassversion;

        public HardwareDetails(string name, int price, string glassversion)
        {
            this.name =  name;
            this.price = price;
            this.glassversion = glassversion;
        }
        public override void Details()
        {
            Console.WriteLine(" My phone  is "    +  name  + "" + " and price is " + price + "" + " with glass as" + "" + glassversion) ;
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            Second obj =  new Second();
            obj.name  =  "iPHONE";
            obj.price =  100000;
            obj.Details();

            obj = new SoftwareDetails("iPHONE", 100000, "A10");
            obj.Details();
            obj = new HardwareDetails("iPHONE", 100000, "Gorila");
            obj.Details();
            Console.ReadKey();
        }

    }
}
