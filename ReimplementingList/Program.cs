using System;
using System.Collections.Generic;
using System.Linq;

namespace ReimplementingList
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> data = Enumerable.Range(0, 20);

            MyList<int> list = new();
            foreach (int x in data) list.Add(x);
            list.ForEach(x => Console.Write($"{x,3}"));
            Console.WriteLine();

            int[] array = new int[15];
            int count = 0;

            foreach (var x in data)
            {
                if (count == array.Length)
                {
                    int[] newArray = new int[array.Length * 2];
                    Array.Copy(array, newArray, array.Length);
                    array = newArray;
                }

                array[count++] = x;
            }

            for (int i = 0; i < count; i++) Console.Write($"{array[i],3}");
            Console.WriteLine();
        }
    }
}
