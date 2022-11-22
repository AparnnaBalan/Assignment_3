using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
   internal class First
    {
        public class Student
        {
            private string name;
            private int student_id;



            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public int Id
            {
                get { return student_id; }
                set { student_id = value; }
            }



            public void showdetails()
            {
                Console.WriteLine("Name:" + name);
                Console.WriteLine("StudentId:" + student_id);
            }
        }

        static void Main(string[] args)
        {
            Student obj = new Student();
            obj.Name = "Aparnna";
            obj.Id = 19;
            obj.showdetails();
            Console.WriteLine("\npress enter to exit....");
            Console.ReadLine();
        }
    }
}
