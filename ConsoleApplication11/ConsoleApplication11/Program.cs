using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        public static int checkPrime (int a)
        {
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
                    return a;
                }
            }
        }

        static void Main(string[] args)
        {
            FileStream fs1 = new FileStream(@"C:\Users\w\Desktop\folder\input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            FileStream fs2 = new FileStream(@"C:\Users\w\Desktop\folder\output.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs1);
            StreamWriter sw = new StreamWriter(fs2);
           
            string [] s = sr.ReadLine().Split(','); // read and split 
            int[] array = new int[s.Length]; //creates an array where n=lenth of s

            for (int i = 0; i < s.Length; i++) // probigaetsya po stroke
                {
                    array[i] = int.Parse(s[i]); // string to int and saves as array[i]
                }
            //----------
            int min = 10000000;
            for (int i = 0; i < array.Length; i++)
                {
                    if (checkPrime (array[i]) < min)
                    {
                        min = array[i];    
                    }   
                }
            sw.WriteLine("minimum is " + min);
            sr.Close();
            fs1.Close();
            Console.ReadKey();
        }
    }
}
