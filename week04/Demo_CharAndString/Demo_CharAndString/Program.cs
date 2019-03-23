using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CharAndString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            /*Test t1 = new Test();
            Test t2 = t1;
            Console.WriteLine("t1.x={0},t1.y={1}", t1.x, t1.y);
            Console.WriteLine("t2.x={0},t2.y={1}", t2.x, t2.y);
            t2.x = 23;
            t2.y = 34;
            Console.WriteLine("t1.x={0},t1.y={1}", t1.x, t1.y);//t2改变，t1也随之改变
            Console.WriteLine("t2.x={0},t2.y={1}", t2.x, t2.y);

            string name = "屁孩";
            string sex = "male";
            double score = 89.5;
            
            str1 = name;
            Console.WriteLine("姓名为：{0}，性别为：{1}，成绩是:{2}",name,sex,score);
            Console.WriteLine("str1为：{0}", str1);
            str1 = "留院";
            Console.WriteLine("改变str1之后：");//str1改变，name不变
            Console.WriteLine("姓名为：{0}，性别为：{1}，成绩是:{2}", name, sex, score);
            Console.WriteLine("str1为：{0}", str1);*/

            string s1 = null, s2 = "";
            string str2;
            str2 = s1 == s2 ? "相等" : "不相等";
            Console.WriteLine("str2的值为：{0}", str2);
            //if (s1 == null)
            if (s2.Equals(string.Empty))
            {
                Console.WriteLine("条件为真");
            }

            str1 = "abc";
            str2 = "Abc";

            if (str1.ToLower() == str2.ToLower())
                Console.WriteLine("相等");
            else
                Console.WriteLine("不相等");

            if (string.Compare(str1, str2, true) == 0)
                Console.WriteLine("相等");
            else
                Console.WriteLine("不相等");

            if (str1.ToLower().CompareTo(str2.ToLower()) == 0)
                Console.WriteLine("相等");
            else
                Console.WriteLine("不相等");

            Console.ReadKey();

        }
    }
    class Test
    {
       public int x = 10;
       public int y = 10;
    }
}
