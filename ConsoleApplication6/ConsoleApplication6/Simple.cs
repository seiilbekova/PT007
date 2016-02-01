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
            string s = Console.ReadLine();
            string[] array = s.Split(',');
            //int[] a = new int[s.Length];

            
            for (int i = 0; i < array.Length; i++)
            {
                int a = int.Parse(array[i]);
                for (int k = 2; k*k <= a; k++)
                
                    if (a % k == 0)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(array[i]);
                    }
                
                Console.ReadKey();

            }
        }
    }
}
