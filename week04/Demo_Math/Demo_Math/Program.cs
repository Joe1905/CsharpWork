using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Random r = new Random();
            x = r.Next(1, 10);
            y = r.Next(1, 10);
            int z = x + y;
            Console.WriteLine("x为：{0},y为：{1}", x, y);
            Console.WriteLine("那么{0}+{1}=?", x, y);
            string str = Console.ReadLine();
            if (!string.IsNullOrEmpty(str))
            {
                if (Convert.ToInt32(str)==z)
                    Console.WriteLine("你答对了，真棒！");
                else
                    Console.WriteLine("答错了，还要加油啊！");
            }
            Console.ReadKey();
        }
    }
}
