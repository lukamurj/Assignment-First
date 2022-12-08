using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[10];
            AddArrayNumbers(arr);
            SortArray(arr);
            RangeArray(arr);
            PrintArray(arr);
            SumArray(arr);
        }

        static void SumArray(int[] array)
        {
            int sum = array[0];
            for(int i = 1; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("The sum of the numbers in the array is " + sum);
        }

        static void PrintArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                //if(array[i] % 2 == 1)
                //{
                //    Console.Write(array[i] + " ");
                //}else if(array[i] % 3 == 0)
                //{
                //    Console.Write(array[i] + " ");
                //}
                if (array[i] % 2 == 0 && array[i] % 3 == 0) { 
                    Console.Write("luwia da samis jeradi" + array[i] + " "); 
                } else if (array[i] % 2 == 1) { 
                    Console.Write("Kentia" + array[i] + " "); 
                }
            }
            Console.WriteLine("\n");
        }

        static void RangeArray(int[] array)
        {
            int NumMin = array[0];
            int NumMax = array[0];
            for(int i = 1; i < array.Length; i++)
            {
                if(NumMin > array[i])
                {
                    NumMin = array[i];
                }
                if (NumMax < array[i])
                {
                    NumMax = array[i];
                }
            }
            Console.WriteLine("The range is " + (NumMax - NumMin));
            Console.WriteLine();
        }

        static void SortArray(int[] array)
        {
            int temp = 0;
            for (int j = 0; j < array.Length - 1; j++)
            {
                for(int i = j + 1; i < array.Length - 1; i++)
                {
                    if(array[j] > array[i])
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }

        static void AddArrayNumbers(int[] array)
        {
            Console.WriteLine("Enter 10 numbers:");
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(i + 1 + ". ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
        }
    }
}
