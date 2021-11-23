using System.Collections.Generic;
using System.IO;

namespace LINQ.Classes
{
    public static class StreamWriterExtension
    {
        public static void AddData(this StreamWriter streamWriter, int[] array, char symbol)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                streamWriter.Write(array[i]);
                if (!(i == array.Length - 1))
                {
                    streamWriter.Write(symbol);
                }
            }
            streamWriter.WriteLine();
            streamWriter.Flush();
        }

        public static void AddMultiply(this StreamWriter streamWriter, List<int> array, char symbol)
        {
            foreach (var number in array)
                streamWriter.Write($"{ number}{ symbol}");            
            streamWriter.Write("-->");
            streamWriter.Write(OperationsWithNumbers.Multiply(array));
            streamWriter.Flush();
        }

        public static void AddSum(this StreamWriter streamWriter, List<int> array, char symbol)
        {
            foreach (var number in array)
                streamWriter.Write($"{ number}{ symbol}");
            streamWriter.Write("-->");
            streamWriter.Write(OperationsWithNumbers.SumOfNumbers(array));
            streamWriter.Flush();
        }

        public static void AddSortedArray(this StreamWriter streamWriter, List<int> array, char symbol)
        {
            foreach (var number in array)
                streamWriter.Write($"{ number}{ symbol}");
            streamWriter.Write("-->");
            foreach( var number in OperationsWithNumbers.SortedNumbers(array))
                streamWriter.Write($"{ number}{ symbol}");
            streamWriter.Flush();
        }

    }
}
