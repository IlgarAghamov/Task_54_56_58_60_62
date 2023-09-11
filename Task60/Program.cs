int[,,] array = GenerateUniqueTwoDigitArray(2, 2, 2);

        Console.WriteLine("Трехмерный массив:");

        for (int x = 0; x < array.GetLength(0); x++)
        {
            for (int y = 0; y < array.GetLength(1); y++)
            {
                for (int z = 0; z < array.GetLength(2); z++)
                {
                    Console.WriteLine($"{array[x, y, z]}({x},{y},{z})");
                }
            }
        }

    static int[,,] GenerateUniqueTwoDigitArray(int sizeX, int sizeY, int sizeZ)
    {
        int[,,] array = new int[sizeX, sizeY, sizeZ];
        bool[] used = new bool[90]; 

        Random random = new Random();

        for (int x = 0; x < sizeX; x++)
        {
            for (int y = 0; y < sizeY; y++)
            {
                for (int z = 0; z < sizeZ; z++)
                {
                    int num;
                    do
                    {
                        num = random.Next(10, 100); 
                    } while (used[num - 10]); 

                    array[x, y, z] = num;
                    used[num - 10] = true;
                }
            }
        }

        return array;
    }
