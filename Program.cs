using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Accessing an element using an index
        int firstElement = numbers[0]; // Time complexity: O(1)
        int thirdElement = numbers[2]; // Time complexity: O(1)
        int secondElement = numbers[1]; // Time complexity: O(1)
        // Looping through the array
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        // Time complexity: O(n), where n is the number of elements in the array
        // Space complexity: O(1), as we are not using any additional memory proportional to the input size

        // Retrieving data based on a condition 

        int count = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
         if (numbers[i] > 0)
         {
          count++;
         }
       }

        Console.WriteLine("Count: " + count);
        // Time complexity: O(n), where n is the number of elements in the array
        // Space complexity: O(1), as we are not using any additional memory proportional to the input size
    }
}
