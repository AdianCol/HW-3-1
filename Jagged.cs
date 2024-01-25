public class JaggedArray
{
    private int[][] array;

    public JaggedArray(int length, bool fillWithUserInput = false)
    {
        array = new int[length][];
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
            array[i] = new int[random.Next(1, 10)];
            for (int j = 0; j < array[i].Length; j++)
            {
                array[i][j] = random.Next(-200, 200);
            }
        }
    }

    public void FillWithUserInput()
    {
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < array.Length; i++)
        {
            System.Console.Write("Length of line:");
            int nn = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Now elements:");
            array[i] = new int[nn];
            for (int j = 0; j < nn; j++)
            {
                array[i][j] = int.Parse(Console.ReadLine());
            }
        }


    }

    public void Print()
    {
        Console.WriteLine("Array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Row {i}: ");
            Console.WriteLine(string.Join(" ", array[i]));
        }
    }

    public double AverageValue()
    {
        double sum = 0;
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                sum += array[i][j];
                count++;
            }
        }
        return sum / count;
    }

    public double[] AverageValueInSubArrays()
    {
        double[] aver = new double[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            aver[i]= array[i].Average();
        }
        return aver;
    }

    public void ChangeEvenElements()
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                if (array[i][j] % 2 == 0)
                {
                    array[i][j] = array[i][j] * j;
                }
            }
        }
    }
}
