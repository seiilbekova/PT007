using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = 'C';
            var limit = 3;
            int[] source = { 0, 1, 2, 3, 4, 5 };
            int sum = 0;
            for (int i = 0; i < 6; i++)
            {
                sum += source[i];
            }

            Console.WriteLine(firstLetter + " " + limit + " " + sum);
            Console.WriteLine(GetName(2));
            Console.ReadKey();
        }
        public static string GetName(int ID) //static, if not should create exemplar
        {
            if (ID < names.Length)
                return names[ID];
            else
                return String.Empty;
        }
        private static string[] names = { "Aibek", "Aigerim", "Alisher", "Amanzhol" };
    }
}