using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  13. Найти натуральное число из интервала 
    от a до b с максимальной суммой делителей. */

namespace Lab_3_02_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 100;

            int max = 0;
            for (int i = a; i <= b; i++)
            {
                int sum = 0;                
                for (int j = 1; j <= b; j++)
                {
                    if  (i % j == 0)                    
                        sum += j;                                        
                }
                if (sum > max)
                {
                    max = sum;
                    Console.WriteLine($"i={i}, sum={sum}");
                }                    
            }
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
