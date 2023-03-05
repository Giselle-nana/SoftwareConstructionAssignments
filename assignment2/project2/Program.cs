using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    class Solution
    {
        public int max;
        public int min;
        public int average;
        public int sum;
        public Solution()
        {
            max = 0;
            min = 0;
            average = 0;
            sum = 0;
        }
        public void GetMax(int[]a,int len)
        {
            this.max = a[0];
            for(int i=1;i<len;i++)
            {
                if (a[i] > this.max)
                    this.max = a[i];
            }
        }
        public void GetMin(int[]a,int len)
        {
            this.min = a[0];
            for(int i=1;i<len;i++)
            {
                if (a[i] < this.min)
                   this.min = a[i];
            }
        }
        public void GetSum(int[] a, int len)
        {
            for (int i = 0; i < len; i++)
                this.sum += a[i];
        }
        public void GetAver(int[]a,int len)
        {
            int b = 0;
            for (int i = 0; i < len; i++)
                b += a[i];
            this.average = b / len;
           
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("请输入整数数组的长度：");
            int len = Int32.Parse(Console.ReadLine());
            int[] a;
            a = new int[len];
            System.Console.WriteLine("请输入数组内容：");
            for(int i=0;i<len;i++)
            {
                a[i] = Int32.Parse(Console.ReadLine());
            }
            Solution s = new Solution();
            s.GetMax(a, len);
            s.GetMin(a, len);
            s.GetAver(a, len);
            s.GetSum(a, len);
            System.Console.WriteLine("数组最大值为：" + s.max);
            System.Console.WriteLine("数组最小值为：" + s.min);
            System.Console.WriteLine("数组平均值为：" + s.average);
            System.Console.WriteLine("数组元素和为：" + s.sum);
        }
    }
}
