using System.Collections.Generic;
using System.IO;

namespace LINQ.Classes
{
    class DefineTypeOfNumbers
    {
        public static void TypeOfNumbers(StreamReader streamReader, char symbol, ref List<int> oddList, ref List<int> evenList, ref List<int> equalList)
        {
            int oddNumbers = 0;
            int evenNumbers = 0;
            while (!streamReader.EndOfStream)
            {
                var line = streamReader.ReadLine();
                var substring = line.Split(symbol);
                for (int i = 0; i < substring.Length; i++)
                {
                    if (int.Parse(substring[i]) % 2 == 0)
                    {
                        evenNumbers++;
                    }
                    else oddNumbers++;
                }
                if ((evenNumbers < oddNumbers) && (evenNumbers != oddNumbers))
                {
                    for (int i = 0; i < substring.Length; i++)
                    {
                        oddList.Add(int.Parse(substring[i]));
                    }
                }
                if ((evenNumbers < oddNumbers) && (evenNumbers != oddNumbers))
                {
                    for (int i = 0; i < substring.Length; i++)
                    {
                        evenList.Add(int.Parse(substring[i]));
                    }
                }
                if (evenNumbers == oddNumbers)
                {
                    for (int i = 0; i < substring.Length; i++)
                    {
                        equalList.Add(int.Parse(substring[i]));
                    }
                }
                oddNumbers = 0;
                evenNumbers = 0;
            }
        }
    }
}
