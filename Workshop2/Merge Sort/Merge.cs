using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Merge_Sort
{
    public class Merge<T> where T : IComparable
    {
        private static T[] aux;
        public static void Sort(T[] arr)
        {
            aux = new T[arr.Length];
            Sort(arr, 0, arr.Length - 1);
        }

        private static void MergeSort(T[] arr, int lo, int mid, int hi)
        {
            if (IsLess(arr[mid],arr[mid+1]))
            {
                return;
            }
            else
            {
                for (int i = lo; i < hi + 1; i++)
                {
                    aux[i] = arr[i];
                }
            }

            var k = lo;
            var j = mid + 1;

            for (int i = lo; i <=hi; i++)
            {
                if (k > mid)
                {
                    arr[i] = aux[j++];
                }
                else if (j > hi)
                {
                    arr[i] = aux[k++];
                }
                else if (IsLess(aux[k],aux[j]))
                {
                    arr[i] = aux[k++];
                }
                else
                {
                    arr[i] = aux[j++];
                }
            }
        }
        private static bool IsLess(T current, T other)
        {
            return current.CompareTo(other)<0;
        }
        private static void Sort(T[] arr,int lo,int hi)
        {
            if (lo>=hi)
            {
                return;
            }
            int mid = lo + (hi - lo) / 2;
            Sort(arr, lo, mid);
            Sort(arr, mid + 1, hi);
            MergeSort(arr, lo, mid, hi);
        }
    }
}
