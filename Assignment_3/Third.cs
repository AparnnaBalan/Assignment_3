using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Third
    {
        
        static void Main(string[]args)
        {
            Console.WriteLine("Enter strings:-");
            string str = Console.ReadLine();
            int ctr = 0;

            for (int i = 0; i <str.Length; i++)
            { 
                if(str[i]==' ')
                { 
                    ctr++;
        }
         
                }
    Console.WriteLine("space between  strings:-"+ctr);
            Console.ReadLine();

        }
    }
}
