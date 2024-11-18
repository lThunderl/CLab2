using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleAppLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("* Задание #2                                                        *");
            Console.WriteLine("* Вариант #3                                                        *");
            Console.WriteLine("* Выполнил: Бурков Виталий Андреевич | МКМб-22-1                    *");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                          *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по *");
            Console.WriteLine("* исходным значениям, находящимся в массиве (от 1 до 10)            *");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                  *");
            Console.WriteLine("* Массив значений от 1 до 10                                        *");
            Console.WriteLine("* Math.Pow(i, 2) - Math.Pow(i, 3)) - ((Math.Pow(Math.Cos(i), 3) + 7 *");
            Console.WriteLine("* Math.Pow(i, 2))/((Math.Pow(i, 3)-15*i)))/(Math.Pow(Math.Cos(i),2))*");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                         *");
            Console.WriteLine("*********************************************************************");
            int start = 0;
            int stop = 10;
            string s = "";
            ClassLab1 cl = new ClassLab1();
            double[] res = cl.Solve(start, stop);
            for(int i = 1; i < stop-start+1; i++)
            {
                s += string.Concat(res[i]);
                s += "\n";
 
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
