using LINQ.Classes;
using System.Collections.Generic;
using System.IO;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 10, 5, 1 };
            int[] array2 = { 1, 2, 4 };
            int[] array3 = { 4, 2, 7, 5 };
            int[] array4 = { 2, 3, 0, 1 };

            List<int> oddList = new List<int>();
            List<int> evenList = new List<int>();
            List<int> equalList = new List<int>();
            char symbolTxt = ' ';
            string path = "D:\\Project1";

            if (!Directory.Exists(path))
            {
                DirectoryInfo directory = Directory.CreateDirectory(path);
            }

            var filename1 = OperationsWithFiles.WriteData(symbolTxt, new List<int[]> { array1, array2, array3 });
            var filename2 = OperationsWithFiles.WriteData(symbolTxt, new List<int[]> { array2, array4, array1 });

            OperationsWithFiles.ReadData(filename1, symbolTxt, ref oddList, ref evenList, ref equalList);
            OperationsWithFiles.ReadData(filename2, symbolTxt, ref oddList, ref evenList, ref equalList);

            using (StreamWriter streamWriterTxt = new StreamWriter($"{path}\\output1.txt"))
                streamWriterTxt.AddMultiply(oddList, symbolTxt);

            using (StreamWriter streamWriterTxt = new StreamWriter($"{path}\\output2.txt"))
                streamWriterTxt.AddSum(evenList, symbolTxt);

            using (StreamWriter streamWriterTxt = new StreamWriter($"{path}\\output3.txt"))
                streamWriterTxt.AddSortedArray(equalList, symbolTxt);
        }
    }
}
