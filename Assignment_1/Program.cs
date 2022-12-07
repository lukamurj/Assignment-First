using System;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            InputTenNum(arr);
            SortOutNum(arr);
            FindTheRange(arr);
            PrintNum(arr);
            SumOfNum(arr);
        }

        static void SumOfNum(int[] array)
        {
            int sum = array[0];
            for(int a = 1; a < array.Length; a++)
            {
                sum += array[a];
            }
            Console.WriteLine("The sum of the numbers in the array is " + sum);
        }

        static void PrintNum(int[] array)
        {
            Console.Write("Odd numbers and even numbers, which divide by 3, are: ");
            for(int a = 0; a < array.Length; a++)
            {
                if(array[a] % 2 == 1)
                {
                    Console.Write(array[a] + " ");
                }else if(array[a] % 3 == 0)
                {
                    Console.Write(array[a] + " ");
                }
            }
            Console.WriteLine("\n");
        }

        static void FindTheRange(int[] array)
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

        static void SortOutNum(int[] array)
        {
            for(int a = 0; a < array.Length - 1; a++)
            {
                for(int i = a + 1; i < array.Length - 1; i++)
                {
                    if(array[a] > array[i])
                    {
                        int Num = array[a];
                        array[a] = array[i];
                        array[i] = Num;
                    }
                }
            }
        }

        static void InputTenNum(int[] array)
        {
            Console.WriteLine("Enter 10 numbers:");
            for(int a = 0; a < array.Length; a++)
            {
                Console.Write(a + 1 + ". ");
                array[a] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }
    }
}
