using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] simple = new int[] {5,8,89,7,77,55};
           /*
            simple[0]=22;
            simple[1]=79;
            simple[2]=789;

            Console.WriteLine(simple[0].ToString(),simple[2].ToString());
            Console.ReadLine();
            

            for(int i=0; i< 5; i++)
            {
                Console.WriteLine(simple[i].ToString());
            }
            Console.ReadLine();

            string[] str = new string[] { "ramesh", "Suresh", "Harish", "Ganesh" };

            foreach (string name in str )
            {
                Console.WriteLine(name);

            }
            Console.ReadLine();
            */

            string zig = "Hey mahn" + "This is a concatenation using + operator";

            Console.WriteLine(zig.ToString());

            char[] charArray = zig.ToCharArray();

            Array.Reverse(charArray);

            foreach(char zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();
        }
    }
}
