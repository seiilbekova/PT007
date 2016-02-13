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
        static void Main(string[] args)
        {
            FileStream fs1 = new FileStream(@"C:\Users\w\Desktop\folder\input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs1);
           
            string [] s = sr.ReadLine().Split(','); // read and split 
            int[] array = new int[s.Length]; //creates an array where n=lenth of s

            for (int i = 0; i < s.Length; i++) // probigaetsya po stroke
                {
                    array[i] = int.Parse(s[i]); // string to int and saves as array[i]
                }

            int min = 10000000, max = -10000000;
            for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < min)
                    {
                        min = array[i];    
                    }   
                    
                    if (array[i] > max)
                    {
                        max = array[i];
                    } 
                }
            Console.WriteLine("maximum is " + max + " and minimum is " + min);

            sr.Close();
            fs1.Close();
            Console.ReadKey();
        }
    }
}
