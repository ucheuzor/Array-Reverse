using System;

namespace Array_copy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers();
            int[] reverse = Reverse(numbers);

            PrintResult(reverse);

            Console.ReadLine();
        }

        //Method that creates the Array
        static int[] GenerateNumbers()
        {
            int[] array1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            return array1;
        }

        //A method that reverses the array
        static int[] Reverse(int[] arr) 
        {
            for (int i = 0; i < arr.Length/2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temp;
            }
            return arr;
        }

        static void PrintResult(int[] result)
        {
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
        }
    }
}
