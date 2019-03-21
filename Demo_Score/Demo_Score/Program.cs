using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int cSharp = 80, java = 85, sql = 75;
            int diff = cSharp - sql;
            int avg = (cSharp + java + sql) / 3;
            System.Console.WriteLine("***************************************************************************");
            System.Console.WriteLine("\tC#\tJava\tSQL");
            System.Console.WriteLine("\t{0}\t{1}\t{2}", cSharp, java, sql);
            System.Console.WriteLine("***************************************************************************");
            System.Console.WriteLine("C#和SQL课程的成绩分差：{0}", diff);
            System.Console.WriteLine("三门课程的平均分为：{0}", avg);
            System.Console.ReadKey();
        }
    }
}
