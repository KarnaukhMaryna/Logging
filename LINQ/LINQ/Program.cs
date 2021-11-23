using LINQ.Classes;
using NLog;
using System.Collections.Generic;
using System.IO;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = LogManager.GetCurrentClassLogger();
            logger.Debug("Debug is starting");

            int[] array1 = { 10, 5, 1 };
            int[] array2 = { 1, 2, 4 };
            int[] array3 = { 4, 2, 7, 5 };
            int[] array4 = { 2, 3, 0, 1 };

            List<int> oddList = new List<int>();
            List<int> evenList = new List<int>();
            List<int> equalList = new List<int>();
            char symbolTxt = ' ';
            string path = "D:\\Project1";

            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
            }
            DirectoryInfo directory = Directory.CreateDirectory(path);
            logger.Info($"Creating the directory with path: {directory}");

            var filename1 = OperationsWithFiles.WriteData(directory,symbolTxt, new List<int[]> { array1, array2, array3 });
            logger.Info($"Write the data to file '{filename1}'");
            var filename2 = OperationsWithFiles.WriteData(directory, symbolTxt, new List<int[]> { array2, array4, array1 });
            logger.Info($"Write the data to file '{filename2}'");

            OperationsWithFiles.ReadData(directory, filename1, symbolTxt, ref oddList, ref evenList, ref equalList);
            logger.Info($"Read the data from the file '{filename1}'");
            OperationsWithFiles.ReadData(directory, filename2, symbolTxt, ref oddList, ref evenList, ref equalList);
            logger.Info($"Read the data from the file '{filename2}'");

            using (StreamWriter streamWriterTxt = new StreamWriter($"{directory}\\output1.txt"))
                streamWriterTxt.AddMultiply(oddList, symbolTxt);
            logger.Info($"Rows with more odd numbers​ multiply and write to {directory}\\output1.txt");

            using (StreamWriter streamWriterTxt = new StreamWriter($"{directory}\\output2.txt"))
                streamWriterTxt.AddSum(evenList, symbolTxt);
            logger.Info($"Rows with more even numbers​ summarize and write to {directory}\\output2.txt");

            using (StreamWriter streamWriterTxt = new StreamWriter($"{directory}\\output3.txt"))
                streamWriterTxt.AddSortedArray(equalList, symbolTxt);
            logger.Info($"Rows where amount of odd and even numbers are equal​,​ sorted and write to {directory}\\output3.txt");
        }
    }
}
