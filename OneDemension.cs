using System;

public class OneDimensionalArray
{
    private int[] array;

    public OneDimensionalArray(int length, bool fillWithUserInput = false)
    {
        array = new int[length];
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
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-200, 200);
        }
    }

    public void FillWithUserInput()
    {
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

    }

    public void Print()
    {
        Console.WriteLine("Array:");
        Console.WriteLine(string.Join(" ", array));
    }

    public double AverageValue()
    {
        return array.Average();
    }

    public void RemoveElementsGreaterThan100()
    {
        int[] newArray = new int[array.Length];
        int newIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (Math.Abs(array[i]) <= 100)
            {
                newArray[newIndex] = array[i];
                newIndex++;
            }
        }
        array = new int[newIndex];
        for (int i = 0; i < newIndex; i++)
        {
            array[i]= newArray[i];
        }
    }

    public void RemoveDuplicates()
    {
        int n = array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            for (int it = 0; it < array.Length; it++)
            {
                if (array[i] == array[it] && it != i && it > i)
                {
                    n--;
                }
            }
        }
        int[] newArray = new int[n];
        int newIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            bool isDuplicate = false;
            for (int it = 0; it < i; it++)
            {
                if (array[i] == array[it])
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (!isDuplicate)
            {
                newArray[newIndex] = array[i];
                newIndex++;
            }
        }
        array = newArray;
    }
}