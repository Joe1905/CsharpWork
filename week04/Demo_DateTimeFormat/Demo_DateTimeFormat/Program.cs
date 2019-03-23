using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_DateTimeFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("dt = {0}", dt);
            Console.WriteLine("dt:d = {0:d}", dt);
            Console.WriteLine("dt:D = {0:D}", dt);
            Console.WriteLine("dt:t = {0:t}", dt);
            Console.WriteLine("dt:T = {0:T}", dt);
            Console.WriteLine("dt:f = {0:f}", dt);
            Console.WriteLine("dt:F = {0:F}", dt);
            Console.WriteLine("dt:g = {0:g}", dt);
            Console.WriteLine("dt:G = {0:G}", dt);
            Console.WriteLine("dt:y = {0:y}", dt);
            Console.WriteLine("dt:Y = {0:Y}", dt);
            Console.WriteLine("dt:m = {0:m}", dt);
            Console.WriteLine("dt:M = {0:M}", dt);

            Console.ReadKey();
        }
    }
}
