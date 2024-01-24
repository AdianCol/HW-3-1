using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("One-dimensional array:");
        OneDimensionalArray oneDimensionalArray = new OneDimensionalArray(4);
        oneDimensionalArray.Print();
        Console.WriteLine($"Average value: {oneDimensionalArray.AverageValue()}");
        oneDimensionalArray.RemoveElementsGreaterThan100();
        oneDimensionalArray.Print();
        oneDimensionalArray.RemoveDuplicates();
        oneDimensionalArray.Print();

        Console.WriteLine("Two-dimensional array:");
        MultiDimensionalArray twoDimensionalArray = new MultiDimensionalArray(4, 4);
        twoDimensionalArray.Print();
        Console.WriteLine($"Average value: {twoDimensionalArray.AverageValue()}");
        twoDimensionalArray.PrintEvenRowsReversed();

        Console.WriteLine("Jagged array:");
        JaggedArray jaggedArray = new JaggedArray(4);
        jaggedArray.Print();
        Console.WriteLine($"Average value: {jaggedArray.AverageValue()}");
        Console.WriteLine($"Average value in sub-arrays: {jaggedArray.AverageValueInSubArrays()}");
        jaggedArray.ChangeEvenElements();
        jaggedArray.Print();
    }
}