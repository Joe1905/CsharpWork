using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Struct
{
    class Program
    {
        public struct StructStudent
        {
            public string Name;
            public string Sex;
            public int Age;
            public string Addr;
            public StructStudent(string name,string sex,int age,string addr)
            {
                Name = name;
                Sex = sex;
                Age = age;
                Addr = addr;
            }
 
            public void Show()
            {
                Console.WriteLine("Show()方法显示内容-->Name:{0},Sex:{1},Age:{2},Addr:{3}",Name,Sex,Age,Addr);
            }
        }
        static void Main(string[] args)
        {
             StructStudent stu;
 
            stu.Name = "刘媛";
            stu.Sex = "女";
            stu.Age = 15;
            stu.Addr = "江西南昌";
 
            stu.Show();
 
            Console.WriteLine("Main()方法中显示内容-->Name:{0},Sex:{1},Age:{2},Addr:{3}",stu.Name,stu.Sex,stu.Age,stu.Addr);
 
            StructStudent stu2 = new StructStudent("彭海","male",53,"中国赣州");
            stu2.Show();
 
            Console.WriteLine("Main()方法中显示内容-->Name:{0},Sex:{1},Age:{2},Addr:{3}", stu2.Name, stu2.Sex, stu2.Age, stu2.Addr);
 
 
            Console.ReadKey();
        }
    }
}
