int[,] array = {
            {1, 4, 7, 2},
            {5, 9, 2, 3},
            {8, 4, 2, 4}
        };

        SortArrayDescending(array);

        Console.WriteLine("Упорядоченный массив:");

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

    static void SortArrayDescending(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 1; j < array.GetLength(1); j++)
            {
                int key = array[i, j];
                int k = j - 1;

                 while (k >= 0 && array[i, k] < key)
                 {
                    array[i, k + 1] = array[i, k];
                    k--;
                 }

                array[i, k + 1] = key;
            }
        }
    }

