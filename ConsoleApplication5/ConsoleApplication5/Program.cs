using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World 1");
            Console.Write("Hello World 2 ");
            string s = "world";
            string s1 = s.Substring(0,3);
            string s2 = s.Replace("ld", "ry");
            Console.WriteLine("don't" + " " + s2 + " and " + s1 + "k");

            int index = s.IndexOf("wo");
            Console.WriteLine(index);
            Console.WriteLine(s2.Length);

            Console.ReadKey();
        }
    }
}
