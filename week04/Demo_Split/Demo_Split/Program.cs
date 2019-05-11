using System;

namespace Demo_Split
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "男人，女人，好人，坏人，圣人，";
            int[] x = { 1, 2, 3 };
            for (int i = 0; i < x.Length; i++)
                Console.WriteLine(x[i]);
            string subStr1;
            /*subStr1 = str.Substring(3);
            string subStr2;
            subStr2 = str.Substring(6, 2);
            Console.WriteLine(subStr1);
            Console.WriteLine(subStr2); */

            string inStr;
            inStr = str.Insert(7, "不");
            Console.WriteLine(inStr);

            /*string[] sList = str.Split('，');

            for (int i = 0; i < sList.Length; i++)
                Console.Write(sList[i] + "   ");
            Console.WriteLine();
            for (int i = 0; i < sList.Length; i++)
                Console.WriteLine(sList[i].Replace("人", ""));*/


            Console.ReadKey();

        }
    }
}
