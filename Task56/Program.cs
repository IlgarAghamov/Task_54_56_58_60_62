﻿ int[,] array = {
            {1, 4, 7, 2},
            {5, 9, 2, 3},
            {8, 4, 2, 4},
            {5, 2, 6, 7}
        };

        int minRow = FindRowWithMinSum(array);

        Console.WriteLine($"Строка с наименьшей суммой элементов: {minRow + 1} строка");

    static int FindRowWithMinSum(int[,] array)
    {
        int minSum = int.MaxValue;
        int minRowIndex = -1;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            int rowSum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                rowSum += array[i, j];
            }

            if (rowSum < minSum)
            {
                minSum = rowSum;
                minRowIndex = i;
            }
        }

        return minRowIndex;
    }