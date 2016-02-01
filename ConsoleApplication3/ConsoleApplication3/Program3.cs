using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = Byte.MaxValue;
            byte num = 0xA;
            int i = 5;
            char c = 'Z';
            Console.WriteLine(b + " " + num + " " + i + " " + c + " " + FileMode);
            Console.ReadKey();
        }
        public enum FileMode
            {
            CreateNew = 1,
            Create = 2,
            Open = 3,
            OpenOrCreate = 4,
            Truncate = 5,
            Append = 6,        
        }
    }
}
