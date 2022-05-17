using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArrays
{
    class Program
    {
        public static void ShowArray(int [] arr)
        {
            for(int i = 0; i < arr.Length; ++i)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int size = 0;
            Console.Write("Set size of array : ");
            size = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[] array = new int[size];
            for(int i = 0; i < array.Length; ++i)
            {
                array[i] = rnd.Next(-10, 10);
            }
            ShowArray(array);
            int[] arr2 = new int[size];
            for (int i = 0; i < array.Length; ++i)
            {
                int unique = array[i];
                for(int j = 1; j < array.Length; ++j)
                {
                    if(array[j] == unique)
                    {
                        unique = -500;
                        break;
                    }
                    else 
                    {
                        arr2[i] = array[j];
                    }
                }
            }
            for(int i = 0; i < arr2.Length; ++i)
            {
                Console.WriteLine(arr2[i] + "\n");
            }
        }
    }
}
