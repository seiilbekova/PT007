using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class TestArraysClass
    {
        static void Main()
        {
            int[] array1 = new int[5]; //объявление одномерного массива
            Console.WriteLine("Input array of 5 elements");
            for (int i = 0; i < 5; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + " element is " + array1[i]);
                Console.ReadKey();
            }
            int[] array2 = new int[] { 1, 2, 3, 4, 5 }; // объявление одномерного массива и эллементов массива
            for (int j = 0; j < 5; j++)
                Console.WriteLine(array2[j]);
            Console.WriteLine("\n");
            Console.ReadKey();

            int[] array3 = { 6, 5, 4, 3, 2, 1 }; //  -/-
            for (int k = 0; k < 6; k++)
                Console.WriteLine(array3[k]);
            Console.WriteLine("\n");
            Console.ReadKey();

            int[,] multiDimensionalArray1 = new int[2, 3]; // объявление двумерного массива
            Console.WriteLine("Input array of 2 lines by 3 elements");
            for (int m = 0; m < 2; m++)
            {
                for (int p = 0; p < 3; p++)
                    multiDimensionalArray1[m, p] = int.Parse(Console.ReadLine());
            }
            for (int m = 0; m < 2; m++)
            {
                for (int p = 0; p < 3; p++)
                    Console.WriteLine(multiDimensionalArray1[m, p]);
            }
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } }; // объявление двумерного массива и эллементов массива
            int[][] jaggedArray = new int[6][]; // объявление ступенчатого массива
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 }; // переменные для первой(0ой) ступени ступенчатого массива
            Console.WriteLine();
        }
    }
}
