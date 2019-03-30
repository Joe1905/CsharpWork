using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_add
{
    class Program
    {
        static void Main(string[] args)
        {
            int add1 = 0, add2 = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i%2==0)
                {
                    add1 = add1 + i;
                }
                else
                {
                    add2 = add2 + i;
                }
             
            }
            
            Console.WriteLine("奇数和为："+add1);
            Console.WriteLine("偶数和为：" + add2);
            Console.ReadKey();
        }
    }
}
