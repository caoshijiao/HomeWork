using System;

namespace ConsoleApp5
{
    class Program
    {
    
        public static void sieveOfEratosthenes(int n,int[] num)
        {
            num[2] = 0;
            int k = 2, t = 0;
            while (t <= Math.Sqrt(n))
            {
                for(int i = 2; i < n+1; i++)//将不是素数的数筛出
                {
                    if (i % k == 0 && i != k)
                    {
                        num[i] = 1;
                    }
                }
                for(int i = 2; i <= Math.Sqrt(n); i++)//将筛选后的第一个数当做新的筛子
                {
                    if (i > k && num[i] == 0)
                    {
                        k = i;
                        break;
                    }
                }
                t++;
            }
            Console.WriteLine($"{n}以内的素数为：");
            for(int i = 2; i < n+1; i++)
            {
                if (num[i] == 0)
                {
                    Console.Write($"{i},");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入操作数：");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int[] num1 = new int[n1+1];
            sieveOfEratosthenes(n1, num1);
        }
    }
}
