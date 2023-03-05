using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("请输入第一个操作数：");
            int a = Int32.Parse(Console.ReadLine());
            System.Console.Write("请输入第二个操作数:");
            int b = Int32.Parse(Console.ReadLine());
            System.Console.Write("输入操作符：");
            char c = (char)Console.Read();
            switch (c)
            {
                case '+':
                    System.Console.Write(a + b);
                    break;
                case '-':
                    System.Console.Write(a - b);
                    break;
                case '*':
                    System.Console.Write(a * b);
                    break;
                case '/':
                    System.Console.Write(a / b);
                    break;
                default:
                    System.Console.Write("error");
                    break;

            }
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("Enter");
            }

            Console.Read();
        }
    }
}
