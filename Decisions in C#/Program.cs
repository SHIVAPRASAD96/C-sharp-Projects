using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hey Dude Write Something here:");
            //string name;
            //name = Console.ReadLine();
            //Console.WriteLine("Welcome To C# Mr/Mrs:" + name);
            //Console.ReadLine();

            Console.WriteLine("Hey Bro Type numebers 1 ,2 or 3 To Win Some car;");
            string enter;
            enter = Console.ReadLine();

            string message;

            if (enter == "1")
                message = "You won Lamborgini Garlado";
            else if (enter == "2")
                message = "You won Maruthi 800";
            else if (enter == "3")
                message = "You won i20 by Huyandi";
            else
                message = "Sorry !! Bro you didnt Win Any Gift try Next time";

            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
