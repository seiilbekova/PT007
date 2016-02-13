using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Complex
    {
        public int a, b;  

        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public Complex cdivider(Complex c2)
        {
            int x = this.a * c2.b + c2.a * this.b;
            int y = this.b * c2.b;

            int z = 0;
            for (int i = 1; i <= Math.Min(x, y); i++)
               {
                     if (x % i == 0 && y % i == 0)
                         z = i;
               }
            x /= z;
            y /= z;

            Complex ans = new Complex(x, y);
            return ans;
        }

        public override string ToString()
            {
                return (a + "/" + b);
            }

        public static Complex operator +(Complex c1, Complex c2)
            {
                Complex sum = c1.cdivider(c2);
                return sum;
            }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex c = new Complex(1, 2);
            Complex d = new Complex(1, 2);

            Complex answer = c + d;
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
