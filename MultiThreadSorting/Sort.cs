using System;
using System.Collections.Generic;
using System.Text;

namespace MultiThreadSorting
{
    public class Sort
    {
        public static void Bubble(int[] myArray)
        {
            int i = 1, j, value;
            int arrayCount = myArray.Length;
            while (i < arrayCount)
            {
                j = arrayCount - 1;
                while (j >= 1)
                {
                    if (myArray[j - 1] > myArray[j])
                    {
                        value = myArray[j];
                        myArray[j] = myArray[j - 1];
                        myArray[j - 1] = value;
                    }
                    j--;
                }
                i++;
            }
        }
    }
}
