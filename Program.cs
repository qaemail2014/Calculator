using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "";
            string b = ""; 
            string c = "";
            int n = 0;
            int m = 0;
            double aConv = 0;
            double bConv = 0;
            double res = 0;
            Console.WriteLine("Вас приветствует калькулятор с четырмя основными действиями!");
            for (int i = 0; i == n; i++)
            {
                try
                {
                    Console.WriteLine("Введите первое число и нажмите Enter");
                    a = Console.ReadLine();
                    aConv = Convert.ToDouble(a);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Введенные данные не являются числом!");
                    n++;
                }
            }
                Console.WriteLine("Введите действие и нажмите Enter (доступные действия: +, -, *, /)");
                c = Console.ReadLine();
                if (c != "+" && c != "-" && c != "*" && c != "/")
                {
                    do
                    {
                        Console.WriteLine("Вы ввели неправильное действие! (доступные действия: +, -, *, /)");
                        Console.WriteLine("Введите действие ещё раз и нажмите Enter");
                        c = Console.ReadLine();
                    } while (c != "+" && c != "-" && c != "*" && c != "/");
                }
                for (int j = 0; j == m; j++)
                {
                    try
                    {
                        Console.WriteLine("Введите второе число и нажмите Enter");
                        b = Console.ReadLine();
                        bConv = Convert.ToDouble(b);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Введенные данные не являются числом!");
                        m++;
                    }
                }
                Console.Write(a + c + b + "= ");
                if (c == "+")
                {
                    res = aConv + bConv;
                }
                if (c == "-")
                {
                    res = aConv - bConv;
                }
                if (c == "*")
                {
                    res = aConv * bConv;
                }
                if (c == "/")
                {
                    res = aConv / bConv;
                }
                Console.WriteLine(res);
                Console.ReadLine();
        }
    }
}
