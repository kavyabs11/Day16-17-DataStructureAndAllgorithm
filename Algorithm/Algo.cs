using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class Algo
    {
        static List<String> words = new List<String>();
        string find;
        string Anagram;
        public Algo(String find, string Anagram)
        {
            this.find = find;
            this.Anagram = Anagram;
        }
        public void anagram(String fix, String s)
        {
            int l = s.Length;
            if (l == 1)
            {
                // Console.WriteLine(fix + s);
                if ((fix + s).CompareTo(find) == 0)
                {
                    Console.WriteLine(find + " is an anagram of " + Anagram);
                }
                else
                    Console.WriteLine(find + " is not an anagram of " + Anagram);
            }
            else
            {
                for (int i = 0; i < l; i++)
                {
                    char[] mychar = s.ToCharArray();
                    char c = mychar[i];
                    String st = s.Substring(0, i) + s.Substring(i + 1);
                    anagram(fix + c, st);
                }
            }
        }
    }
}