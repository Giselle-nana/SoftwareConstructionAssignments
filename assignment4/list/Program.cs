using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            for(int i=0;i<10;i++)
            {
                list.Add(i);
            }
            //输入每一个元素
           /* Action<Node<int>> printf = s => System.Console.WriteLine(s.Data);*/
            //求最大值
            int max = list.Head.Data;
            Action<Node<int>> getmax = s =>
            {
                if (s.Data > max)
                {
                    max = s.Data;
                }
            };
            //求最小值
            int min = list.Head.Data;
            Action<Node<int>> getmin = s =>
               {
                   if (s.Data < min)
                   {
                       min = s.Data;
                   }
               };
            //求和
            int sum = 0;
          /*  Action<Node<int>> getsum = s => sum += s.Data;*/
            list.ForEach(s=>System.Console.WriteLine(s.Data));//输出每一个元素
            list.ForEach(getmax);
            list.ForEach(getmin);
            list.ForEach(s=>sum+=s.Data);
            System.Console.WriteLine("max=" + max);
            System.Console.WriteLine("min=" + min);
            System.Console.WriteLine("sum=" + sum);
    }
}
}
