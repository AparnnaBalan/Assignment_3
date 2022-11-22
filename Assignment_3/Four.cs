using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment_3
{
    class Four
    {
        static void Main(string[] args)
        {
            
            Stack stack = new Stack();


            int n = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < n; j++)
            {
                stack.Push(Console.ReadLine());
            }
            Console.WriteLine("count before display:"+stack.Count);
            foreach(var item in  stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("count after display:"+stack.Count);
            while(stack.Count > 0)
            {
             Console.WriteLine(stack.Pop());
            }
            Console.WriteLine("count after Pop:" + stack.Count);

            

            
            Console.ReadKey();
        }


    }
}
