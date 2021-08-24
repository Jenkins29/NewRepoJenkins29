using System;
using System.Linq;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArray = ArrayCreation.CreateArray();

            var randomArr = ArrayCreation.FillArrayWith10RandomsInRange1To100(firstArray);
            var randomArr2 = ArrayCreation.CopyArray(randomArr);

            ArrayCreation.SetLastValueToMinus7(randomArr);

            var result = ArrayCreation.DisplayArrayContents(randomArr, randomArr2);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
