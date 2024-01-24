using System;
public class MultiDimensionalArray
{
    private int[,] array;

    public MultiDimensionalArray(int rows, int columns, bool fillWithUserInput = false)
    {
        array = new int[rows, columns];
        if (fillWithUserInput)
        {
            FillWithUserInput();
        }
        else
        {
            FillWithRandomValues();
        }
    }

    public void FillWithRandomValues()
    {
        var random = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(-200,200);
            }
        }
    }

    public void FillWithUserInput()
    {
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine();
        }

    }

    public void Print()
    {
        Console.WriteLine("Array:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"Row {i}: ");
                Console.WriteLine(string.Join(" ", array[i,j]));
            }
        }
    }

    public void PrintEvenRowsReversed()
    {
        Console.WriteLine("Rows in reverse order:");
        int s = array.GetLength(0);
        int c = array.GetLength(1);
        int j = 0;
        for (int i = 0; i < s; i++)
        {
            if (i % 2 == 0)
            {
                j = c-1;
                for (; j >-1; j--)
                {
                    Console.Write(array[i, j] + " ");
                }
            }
            else
            {
                j = 0;
                for (; j < c; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
            }
            Console.WriteLine();
        }

    }

    public double AverageValue()
    {
        double sum = 0;
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j];
                count++;
            }
        }
        return sum / count;
    }
}
