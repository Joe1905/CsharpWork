using System;

namespace Demo_obj
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5; //值类型
            object obj;//引用类型
            obj = i;//装箱
            int x = (int)obj;//拆箱

            System.Console.WriteLine("x={0}", x);
            System.Console.ReadKey();
        }
    }
}
