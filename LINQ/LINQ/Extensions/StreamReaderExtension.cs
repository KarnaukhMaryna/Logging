using System.Collections.Generic;
using System.IO;

namespace LINQ.Classes
{
    public static class StreamReaderExtension
    {
        public static void ReadData(this StreamReader streamReader, char symbol, ref List<int> outList)
        {          
            while (!streamReader.EndOfStream)
            {
                var line = streamReader.ReadLine();
                var substring = line.Split(symbol);
                for (int i = 0; i < substring.Length; i++)
                {
                    outList.Add(int.Parse(substring[i]));
                }
            }
        }       
    }
}
