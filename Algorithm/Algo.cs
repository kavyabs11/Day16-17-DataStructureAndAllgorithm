using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    
        public class Algo<T> where T : IComparable
        {
            public void sortAndCall(T[] sentence, T find)
        {
            Array.Sort(sentence);
            Algo<T>.search(sentence, find);
        }
        public static void search(T[] sen, T find)
        {
            int min = 0;
            int max = sen.Length - 1;
            int flag = 0;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (sen[mid].CompareTo(find) == 0)
                {
                    flag = 1;
                    Console.WriteLine("Found at " + mid + " position ");
                    break;
                }
                else if (sen[mid].CompareTo(find) > 0)
                {
                    max = mid - 01;
                }
                else
                {
                    min = mid + 1;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Not found");
            }
        }
        public static void insertionSort(T[] sentence)
        {
            for (int x = 1; x < (sentence.Length) - 1; x++)
            {
                int i = x;
                T t = sentence[x];
                while (sentence[i - 1].CompareTo(t) > 0)
                {
                    sentence[i] = sentence[i - 1];
                    i--;
                    if (i == 0)
                    {
                        break;
                    }
                }
                sentence[i] = t;
            }
            Console.WriteLine();
            for (int x = 0; x < sentence.Length; x++)
            {
                Console.Write(sentence[x] + " ");
            }

        }
    }
}