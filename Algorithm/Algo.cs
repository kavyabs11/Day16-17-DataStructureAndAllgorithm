using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class Algo
    {
        public static void prime(int num)
        {
            int Count = 0;                              //counter for number of factors
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    Count++;
                    break;
                }
            }
            if (Count == 0)
                Console.WriteLine(num + " ");
        }
    }
}