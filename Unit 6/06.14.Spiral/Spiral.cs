/*Write a program that reads a positive integer number N (N < 20) from console and outputs in 
 the console the numbers 1 ... N numbers arranged as a spiral.
 Example for N = 4
*/

using System;

class Spiral
{
    static void Main()
    {
        Console.WriteLine("Enter a number N:");
        int numberN = int.Parse(Console.ReadLine());

        int[,] array = new int[numberN, numberN];
        int counter = 1;
        int rowNum = 0;
        int colNum = 0;
        int maxRowNum = numberN - 1;
        int maxColNum = numberN - 1;

        do
        {

            for (int i = colNum; i <= maxColNum; i++)
            {
                array[rowNum, i] = counter;                               
                counter++;
            }

            rowNum++;

            for (int i = rowNum; i <= maxRowNum; i++)
            {
                array[i, maxColNum] = counter;                             
                counter++;
            }

            maxColNum--;

            for (int i = maxColNum; i >= colNum; i--)
            {
                array[maxRowNum, i] = counter;                             
                counter++;
            }

            maxRowNum--;

            for (int i = maxRowNum; i >= rowNum; i--)
            {
                array[i, colNum] = counter;                                
                counter++;
            }

            colNum++;
        }

        while (counter <= numberN * numberN);

        for (int rows = 0; rows < array.GetLength(0); rows++)
        {

            for (int cols = 0; cols < array.GetLength(1); cols++)
            {

                Console.Write(array[rows, cols] + " ");

            }

            Console.WriteLine();
        }
    }
}

