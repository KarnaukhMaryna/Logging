using System.Collections.Generic;
using System.Linq;

namespace LINQ.Classes

{
    class OperationsWithNumbers
    {
        public static int Multiply(List<int> oddList)
        {
           return oddList.Where(number => number != 0).Aggregate((number1, number2) => number1 *= number2);
        }

        public static int SumOfNumbers(List<int> evenList)
        {
            return evenList.Aggregate((number1, number2) => number1 += number2);
        }

        public static IEnumerable<int> SortedNumbers(List<int> equalList)
        {
            return equalList.OrderBy(number=>number);
        }
    }
}