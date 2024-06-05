
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

        for (int i = 0; i < 3; i++)
        {
            secondArray[0][i] = firstArray[0, i];           
        }
        for (int i = 0; i < 2; i++)
        {
            secondArray[1][i] = firstArray[1, i + 1];
        }
        for (int i = 0; i < 1; i++)
        {
            secondArray[2][i] = firstArray[2, i + 2];       
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