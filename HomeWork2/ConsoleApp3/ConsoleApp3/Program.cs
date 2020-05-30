using System;

namespace ConsoleApp3
{
    class Program
    {
        public static void numOperation(int n,int[] num)
        {
            int max = num[0];
            int min = num[0];
            double average = 0;
            double sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
                if (max < num[i])
                    max = num[i];
                if (min > num[i])
                    min = num[i];
            }
            average = sum / num.Length;
            Console.WriteLine($"max={max},min={min},average={average},sum={sum}");
        }
        static void Main(string[] args)
        {
            int[] num= { 10,20,27,1,17,38,77,65,33,9};
            numOperation(10, num);
          
        }
       
        
    }
}
