using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Solution
    {
        public ArrayList arr;
        public Solution()
        {
            arr = new ArrayList();
        }
        public void GetPrime(int a)
        {
            bool flag = true;//用于判断i是否为素数
            for (int i = 1; i < a; i++)
            {
                if (a % i != 0)//若不是a的因子，继续下一次循环
                    continue;
                //判断是i是否为素数
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                //i是素数
                if (flag)
                {
                    arr.Add(i);
                }

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("请输入一个数：");
            int a = Int32.Parse(Console.ReadLine());
            Solution s = new Solution();
            s.GetPrime(a);
            System.Console.Write("其素数因子为：");
            for (int i = 0; i < s.arr.Count; i++)
            {
                Console.Write(s.arr[i]);
                Console.Write(" ");
            }
        }
    }
}
