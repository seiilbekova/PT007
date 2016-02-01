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
            //string s3 = System.String.Empty;
            //string s4 = null;

            int index = s.IndexOf("wo");
            Console.WriteLine(index);
            Console.WriteLine(s2.Length);
            Console.WriteLine();
            const string s5 = "You can't get rid of me!";

            char[] letters = {'J', 'u', 's', 't', ' ', 'c', 'o', 'd', 'e', ' ', 'i', 't', '!'};
            string alphabet = new string(letters);

            Console.WriteLine("don't" + " " + s2 + " and " + s1 + "k! " + s5  );
            Console.WriteLine(alphabet);
            Console.WriteLine();

            string title = "\"In aplphabetic order\", ABC";
            string columns = "For A\tFor B\tFor C"; 
            string rows = "App\tBug\tConsole\r\nAdd\tBinary\tCreate\r\nAdder\tByte\tCoppy";

            Console.WriteLine(title);
            Console.WriteLine(columns);
            Console.WriteLine(rows);
            Console.WriteLine();

            string reverse = "Print backwards";
            for (int i = 0; i < reverse.Length; i++)
            {
                Console.Write(reverse[reverse.Length - i - 1]);
            }
            Console.WriteLine();

            string capslock = "hOW DOES mICROSOFT wORD DEAL WITH THE cAPS lOCK KEY?";
            StringBuilder asd = new StringBuilder(capslock);
            for (int j = 0; j < asd.Length; j++)
            {
                if (Char.IsLower(asd[j]) == true)
                    asd[j] = Char.ToUpper(asd[j]);
                else if (Char.IsUpper(asd[j]) == true)
                    asd[j] = char.ToLower(asd[j]); 
            }
            string corrected = asd.ToString();
            Console.WriteLine(corrected);

            Console.ReadKey();
        }
    }
}
