
using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int[,] firstArray = new int[3, 3]
            {
                {1,2,3},
                {2,3,4},
                {3,4,5},
            };

        int[][] secondArray = [new int[3], new int[2], new int[1]];

        for (int i = 0; i < secondArray.Length; i++)
        {
            for (int j = 0; j < secondArray[i].Length; j++)
            {
                secondArray[i][j] = firstArray[i, j + i];
            }
        }

        foreach (var item in secondArray)
        {
            foreach(var number in item)
            {
                Console.Write(number);
                    
            }
            Console.WriteLine();
        }

    }
}