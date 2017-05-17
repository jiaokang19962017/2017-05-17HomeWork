using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    //enum Weekday { Sunday, Monday = 2, Tuesday, Wednesday, Thursday, Friday, Staturday };

    public struct Employee
    {
        public int id;
        public string name;
        public int age;
        public char sex;
        public string phone;
    }
    class Program
    {
        static void Main(string[] args)
        {

            #region 1.星期枚举
            /* int flag = Convert.ToInt32(Console.ReadLine());
         Weekday week = (Weekday)flag;
         switch (week)
         {
             case Weekday.Sunday:
                 Console.WriteLine("sunday");
                 break;
             case Weekday.Monday:
                 Console.WriteLine("monday");
                 break;
             case Weekday.Tuesday:
                 Console.WriteLine("tuesday");
                 break;
             case Weekday.Wednesday:
                 Console.WriteLine("wednesday");
                 break;
             case Weekday.Thursday:
                 Console.WriteLine("thursday");
                 break;
             case Weekday.Friday:
                 Console.WriteLine("friday");
                 break;
             case Weekday.Staturday:
                 Console.WriteLine("staturday");
                 break;
         } */


            /* foreach (string item in Enum.GetNames(typeof(Weekday)))
             {
                 Console.WriteLine(item);
             } */


            /* foreach (int item in Enum.GetValues(typeof(Weekday)))
             {
                 Console.WriteLine(item);
             }*/
            #endregion


            #region 2.结构

            /*   Employee emp;
               emp.id = 1;
               emp.name = "jiaokang";
               emp.age = 21;
               emp.sex = '男';
               emp.phone = "17853753772";

               Console.WriteLine(emp.id);
               Console.WriteLine(emp.name);
               Console.WriteLine(emp.age);
               Console.WriteLine(emp.sex);
               Console.WriteLine(emp.phone);*/
            #endregion


            #region 3.数组交换位置
            //  string[] str = new string[] { "3", "a", "8", "haha" };
            /* Array.Reverse(str);
             foreach (string item in str)
             {
                 Console.WriteLine(item);
             }*/
            /*  string temp;
              for (int i = 0; i < str.Length/2; i++)
              {
                  temp = str[i];
                  str[i] = str[str.Length - 1 - i];
                  str[str.Length - 1 - i] = temp;
              }
              foreach (string item in str)
              {
                  Console.Write(item+" ");
              }*/

            #endregion

            #region 10.1-2+3-4
            /* int flag = Convert.ToInt32(Console.ReadLine());
             int sum = 1;
             for (int i = 2; i <= flag; i++)
             {
                 if (i % 2 == 0)
                 {
                     sum += i;
                 }
                 else
                 {
                     sum -= i;
                 }

             }
             Console.WriteLine(sum);*/

            #endregion



            #region 11.数组
            /*  int[] array = new int[5];
                     for (int i = 0; i < array.Length; i++)
                     {
                         array[i] = Convert.ToInt32(Console.ReadLine());
                     }
                     for (int i = 0; i < array.Length; i++)
                     {
                         Console.Write(array[i]+" ");
                     }*/
            #endregion

        }
    }
}
