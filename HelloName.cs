using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please enter a name!");
            String name = Console.ReadLine();
            Console.WriteLine("Hi " + name);
            Console.ReadLine();
            
            
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();


        }
    }
}


