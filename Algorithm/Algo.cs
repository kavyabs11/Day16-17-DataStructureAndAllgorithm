using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class Algo
    {
        public static void sortAndCall(String sentence, String find)         //find specifies the word to be searched
        {
            String[] words = sentence.Split(' ');          //storing the string in an array of strings
            Array.Sort(words);
            Algo.search(words, find);                    //calling the searching function
        }
        public static void search(String[] sen, String find)         //Binary Search
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
    }
}
