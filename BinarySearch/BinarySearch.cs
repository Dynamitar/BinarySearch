using System;

namespace BinarySearch
{
    class BinarySearch
    {
        private static int BinarySearch_WithWhileLoop(int[] array, int item)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                var middle = (left + right) / 2;

                if (array[middle] == item)
                    return middle;

                if (item < array[middle])
                    right = middle - 1;
                else
                    left = middle + 1;
            }

            return -1;
        }

        static void Main()
        {
            int[] numbers = new[] { 1, 5, 0, 69, 15, 34, 3, 9, 777, 87};
            Array.Sort(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{i} - {numbers[i]}");
            }

            int result = BinarySearch_WithWhileLoop(numbers, 3);
            Console.WriteLine(result);
            Console.WriteLine(numbers[result]);

            result = BinarySearch_WithWhileLoop(numbers, 777);
            Console.WriteLine(result);
            Console.WriteLine(numbers[result]);

            result = BinarySearch_WithWhileLoop(numbers, 2);
            Console.WriteLine(result);

            result = BinarySearch_WithWhileLoop(numbers, 16);
            Console.WriteLine(result);
        }
    }
}
