using System;

namespace ConsoleApp4
{
    class Program
    {
        public static void fac(int n)
        {
            int i;
            if (n <=1)
            {
                Console.WriteLine("无素数因子！");
                return;
            }
            Console.WriteLine("素数因子：");
            double sq = Math.Sqrt(n);
            for (i = 2; i <= sq; i += 1)
            {
                int j = 0;
                while (n % i == 0)
                {
                    n = n / i;
                    if (i != j)
                    {
                        Console.Write($"{i},");
                    }
                    j = i;//避免素数因子重复
                    
                }
            }
            if (n > sq)//判断是否有其他素数因子
            {
                Console.WriteLine($"{n}");
            }
        }
        public static int ReadInt()
        {
           
            Console.WriteLine("请输入操作数：");
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());
                return input;
            }
            catch 
            {
                Console.WriteLine("输入错误！");
                return 0;
            }
        }
        static void Main(string[] args)
        {
            int input = ReadInt();
            fac(input);
        }
    }
}
