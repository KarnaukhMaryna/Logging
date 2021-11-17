using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LINQ.Classes
{
    class OperationsWithFiles
    {
        public static string WriteData(DirectoryInfo directory, char symbolTxt, List<int[]> array)
        {
            string timeStamp = DateTime.Now.ToFileTime().ToString();
            string filename = "input_" + timeStamp;

            using (StreamWriter streamWriterTxt = new StreamWriter($"{directory}{filename}.txt"))
            {
                foreach (var ar in array)
                {
                    streamWriterTxt.AddData(ar, symbolTxt);
                }
            }

            return filename;
        }

        public static void ReadData(DirectoryInfo directory, string filename, char symbolTxt, ref List<int> oddList, ref List<int> evenList, ref List<int> equalList)
        {
            using (StreamReader streamReaderTxt = new StreamReader($"{directory}{filename}.txt"))
            {
                DefineTypeOfNumbers.TypeOfNumbers(streamReaderTxt, symbolTxt, ref oddList, ref evenList, ref equalList);
            }
        }
    }
}
