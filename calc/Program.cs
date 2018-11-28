using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Console.Read();
            int y = Console.Read();
            MyMath math = new MyMath();
            Console.WriteLine("Your Addition is: ");
            Console.WriteLine(math.Add(x, y));
            Console.ReadLine();
        }
    }
}
