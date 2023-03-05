using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project3
{
    class Program
    {
        class Solution
        {
            public ArrayList prime;//记录素数的数组
            public Solution()
            {
                prime = new ArrayList();
            }
            public void GetPrime()
            {
                bool[] isprime = new bool[101];
                for (int i = 0; i < 101; i++)//全部初始化为true
                    isprime[i] = true;
                //从二开始判断 二为素数
                for (int i = 2; i < 101; i++)
                {
                    if (isprime[i] == true)
                    {
                        for (int j = 2 * i; j < 101; j += i)//删除i的倍数
                            isprime[j] = false;
                    }
                    if (isprime[i] == true)
                        prime.Add(i);
                }

            }
        }
        static void Main(string[] args)
        {
            Solution s = new Solution();
            s.GetPrime();
            System.Console.WriteLine("2到100的素数为：");
            for (int i = 0; i < s.prime.Count; i++)
                System.Console.WriteLine(s.prime[i]);
          
        }
    }
    

}
