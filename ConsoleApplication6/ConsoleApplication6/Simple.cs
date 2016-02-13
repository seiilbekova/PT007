using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert set of numbers with , between them ");
            string[] array = Console.ReadLine().Split(',');

            for (int i = 0; i < array.Length; i++)
                {
                    int s = 0;
                    int a = int.Parse(array[i]);
                    for (int k = 1; k <= a; k++)
                         {
                             if (a % k == 0)
                                 {
                                   s++;
                                 }
                }
                if (s == 2)
                    {
                        Console.WriteLine(a);
                    }
                }
            Console.ReadKey();

        }
    }
}