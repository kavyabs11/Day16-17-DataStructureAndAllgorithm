using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class Algo
    {
        public static void permutation(String fix, String s)
        {
            int l = s.Length;
            if (l == 1)
            {
                Console.WriteLine(fix + s);
            }
            else
            {
                for (int i = 0; i < l; i++)
                {
                    char[] mychar = s.ToCharArray();
                    char c = mychar[i];
                    String st = s.Substring(0, i) + s.Substring(i + 1);
                    permutation(fix + c, st);
                }
            }
        }
    }
}
