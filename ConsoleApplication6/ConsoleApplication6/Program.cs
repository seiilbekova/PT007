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
            int[] a = new int[s.Length];

            int n = 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ',')
                    n++;
            }
            
            for (int j = 0; j < n; j++)
            {
                for (int k = 2; k * k <= int.Parse(array[j]); k++)
                {
                    if (int.Parse(array[j]) % k != 0)
                        Console.WriteLine(array[j]);
                }
            }
            Console.ReadKey();


        }
    }
}
