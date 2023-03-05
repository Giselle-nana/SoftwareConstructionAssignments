using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project4
{
    class Solution
    {

        public Solution()
        {
          
        }
        public bool IsToeplitz(int[,] a, int m, int n)
        {
            //先判断第一行元素对角线上元素
            for(int i=0;i<m;i++)
            {
                for(int j=1;(i+j<m)&&(i+j<n);j++)
                {
                    if (a[ j, i + j] != a[0, i])
                        return false;
                }
            }
            //判断第一列除了a[0,0]外的其他元素
            for(int j=1;j<n;j++)
            {
                for(int i=1;(i+j<m)&&(i+j<n);i++)
                {
                    if (a[j + i,  i] != a[j, 0])
                        return false;
                }
            }
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            if(s.IsToeplitz(new int[,] { { 1, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } }, 3, 4))
                System.Console.WriteLine("该矩阵为托普利茨矩阵");
            if(!s.IsToeplitz(new int[,] { { 1, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } }, 3, 4))
                System.Console.WriteLine("该矩阵不是托普利茨矩阵");

        }
    }
}
