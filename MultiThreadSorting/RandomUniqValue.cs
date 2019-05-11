using System;
using System.Collections.Generic;
using System.Text;

namespace MultiThreadSorting
{
    public static class RandomUniqValue
    {
        public static class StaticHesapNo
        {
            private static List<ulong> NumberList = new List<ulong>();
            private static ulong value;
            public static ulong GetRandomUniqueValue()
            {
                while (NumberList.Count != 99998)
                {
                    Random rnd = new Random();

                    value = Convert.ToUInt64(rnd.Next(10000, 99999));
                    if (!NumberList.Contains(value))
                    {
                        NumberList.Add(value);
                        break;
                    }

                }
                return value;
            }
        }
    }
}
