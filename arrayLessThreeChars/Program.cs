using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace arrayLessThreeChars
{
    internal class Program
    {
        static string[] GenerateArray(int size) 
        {
            string[] array = new string[size];
            Console.WriteLine("enter the array elements separated by an ENTER");
            for (int i = 0; i < size; i++)
            {
                string el = Console.ReadLine();
                array[i] = el;
            }
            return array;
        }

        static int FindElWithThreeChars(string[] array)
        {
            int len = 0;
            foreach (string str in array)
            {
                if (str.Length <= 3) len++;
            }
            return len;
        }

        static string[] CreateThreeCharsArray(string[] arr)
        {
            int len = FindElWithThreeChars(arr);
            string[] threeChars = new string[len];
            int index = 0;
            foreach (string str in arr)
            {
                if (str.Length <= 3)
                {
                    threeChars[index] = str;
                    index++;
                }
            }
            return threeChars;
        }
        static void PrintArray(string[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}");
                if (i != array.Length - 1) Console.Write(", ");
            }
            Console.Write("]");
        }

        static void Main(string[] args)
        {
            Console.Write("How many elements in array? ");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] arr = GenerateArray(size);
            string[] threeChars = CreateThreeCharsArray(arr);
            PrintArray(arr);
            Console.Write(" -> ");
            PrintArray(threeChars);
        }
    }
}
