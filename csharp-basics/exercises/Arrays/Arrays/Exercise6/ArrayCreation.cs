using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Exercise6
{
    public class ArrayCreation
    {        public ArrayCreation()
        {
        }

        public static int [] CreateArray()
        {
            var myArray = new int[10];

            return myArray;
        }

        public static int [] FillArrayWith10RandomsInRange1To100(int [] newArray)
        {
            Random r = new Random();
            var testArr = newArray;
            for (int i = 0; i < 10; i++)
            {
                testArr[i] = r.Next(0, 100);
            }

            return testArr;
        }

        public static int[] CopyArray(int[] array)
        {
            int[] arr = new int[10];
            Array.Copy(array, 0, arr, 0, 10);
            return arr;
        }

        public static void SetLastValueToMinus7(int[] array)
        {
           array[9] = -7;
        }

        public static string DisplayArrayContents(int[] array, int[] array2)
        {
            var stringArr = string.Join(",", array);
            var stringArr2 = string.Join(",", array2);

            return "Array 1: " + stringArr + "\n" + "Array 2: " + stringArr2;
        }
    }
}
