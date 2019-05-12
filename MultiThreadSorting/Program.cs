﻿using System;
using System.Linq;
using System.Threading;

namespace MultiThreadSorting
{
    class Program
    {

        static void Main(string[] args)
        {
           // int[] myArray = new int[90];
            int[] myArray,sortedArrayP1,sortedArrayP2,sortedArrayP3;
            myArray = RandomUniqValue.GetRandomUniqueValue(90); //Unique Value

            Thread thread = new Thread(o => { sortedArrayP1 = Sort.Bubble((int[])o); }); //Thread 1 Part 0-30
            thread.Start(myArray.Take(30).ToArray());

            Thread thread2 = new Thread(o => { sortedArrayP2 = Sort.Bubble((int[])o); }); //Thread 2 Part 31-60
            thread2.Start(myArray.Skip(30).Take(30).ToArray());

            Thread thread3 = new Thread(o => { sortedArrayP3 = Sort.Bubble((int[])o); }); //Thread 3 Part 61-90
            thread.Start(myArray.Skip(60).Take(30).ToArray());

            thread.Join();
            thread2.Join();
            thread3.Join();

            Console.Read();





            // Thread thread3 = new Thread(
            //        o =>
            //        {
            //            sortedArrayP1 = Sort.Bubble((int[])o);
            //        });
            //Format
            //Start Code        thread.Start(myArray.Skip(60).Take(30).ToArray());

        }

    }
}
