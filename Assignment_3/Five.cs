using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment_3
{
    class Book
    {
        public int BOOKNO;
        public string BOOKTITLE;
        public float PRICE;



        public void INPUT()
        {
            Console.Write(" Book No: ");
            BOOKNO = int.Parse(Console.ReadLine());
            Console.Write(" Book Title: ");
            BOOKTITLE = Console.ReadLine();
            Console.Write(" Price: ");
            PRICE = int.Parse(Console.ReadLine());
        }



        public float TOTALCOST(int n)
        {
            return PRICE * n;
        }



        public void PURCHASE()
        {
            Console.Write(" Number of copies to be purchased: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Total cost to be paid: {0}", TOTALCOST(n));
        }



        public void DISPLAY()
        {
            Console.WriteLine("Book No: {0}", BOOKNO);
            Console.WriteLine("Book Title: {0}", BOOKTITLE);
            Console.WriteLine("Price: {0}", PRICE);
        }



        static void Main(string[] args)
        {
            Book b = new Book();
            b.INPUT();
            b.PURCHASE();
            b.DISPLAY();
            Console.ReadLine();
        }
    }
}