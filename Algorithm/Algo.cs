using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    internal class Algo
    {
        public static string[] MergeSort(String[] a, int lb, int ub)
        {
            if (lb < ub)
            {
                int mid = (lb + ub) / 2;
                MergeSort(a, lb, mid);                        //first array
                MergeSort(a, mid + 1, ub);                  //second array
                merge(a, lb, mid, ub);                      //merging both the sorted arrays
            }
            return a;
        }
        public static void merge(String[] a, int lb, int mid, int ub)
        {
            string[] b = new string[a.Length];
            int i = lb;                      //index for the first part of the array
            int j = mid + 1;                //for the second part of the array
            int k = lb;                     //index number for the new array formed
            while (i <= mid && j <= ub)
            {
                if (a[i].CompareTo(a[j]) <= 0)                 //if second array has greater element than the first array element
                {
                    b[k] = a[i];
                    i++;
                }
                else                                         //if first array has greater element than the seconds array element
                {
                    b[k] = a[j];
                    j++;
                }
                k++;                                    //third array element index incemented
            }
            if (i > mid)                                //if first array has fully been copied but second hasn't
            {
                while (j <= ub)
                {
                    b[k] = a[j];
                    j++;
                    k++;
                }
            }
            else if (j > ub)                            //if second array has fully been copied but first hasn't
            {
                while (i <= mid)
                {
                    b[k] = a[i];
                    i++;
                    k++;
                }
            }
            for (int x = lb; x <= ub; x++)                 //coping data from b array to the first array
            {
                a[x] = b[x];
            }
        }
    }
}
