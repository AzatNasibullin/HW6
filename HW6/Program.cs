using System;
using System.Collections.Generic;

class Program
{
    static bool FindSumOfThree(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length - 2; i++)
        {
            int currentSum = target - arr[i];
            HashSet<int> set = new HashSet<int>();

            for (int j = i + 1; j < arr.Length; j++)
            {
                int remainingSum = currentSum - arr[j];
                if (set.Contains(remainingSum))
                {
                    Console.WriteLine($"Три числа: {arr[i]}, {arr[j]}, {remainingSum}");
                    return true;
                }
                else
                {
                    set.Add(arr[j]);
                }
            }
        }

        return false;
    }

    static void Main(string[] args)
    {
        int[] arr = { 1, 4, 11, 6, 10, 8 };
        int target = 22;

        if (!FindSumOfThree(arr, target))
        {
            Console.WriteLine("Такие три числа не найдены");
        }
    }
}