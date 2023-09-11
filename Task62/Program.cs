int n = 4;
        int[,] spiralArray = new int[n, n];

        int num = 1;
        int startRow = 0, endRow = n - 1, startCol = 0, endCol = n - 1;

        while (startRow <= endRow && startCol <= endCol)
        {
            for (int i = startCol; i <= endCol; i++)
            {
                spiralArray[startRow, i] = num++;
            }
            startRow++;

            for (int i = startRow; i <= endRow; i++)
            {
                spiralArray[i, endCol] = num++;
            }
            endCol--;

            if (startRow <= endRow)
            {
                for (int i = endCol; i >= startCol; i--)
                {
                    spiralArray[endRow, i] = num++;
                }
                endRow--;
            }

            if (startCol <= endCol)
            {
                for (int i = endRow; i >= startRow; i--)
                {
                    spiralArray[i, startCol] = num++;
                }
                startCol++;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{spiralArray[i, j]:D2} ");
            }
            Console.WriteLine();
        }