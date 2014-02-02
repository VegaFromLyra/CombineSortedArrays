using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Given two sorted arrays, A and B, where A has a large enough buffer at the 
// end to hold B. Write a method to merge B into A in sorted order

namespace CombineSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            a[0] = 1;
            a[1] = 3;
            a[2] = 5;
            int countA = 3;

            int[] b = { 2, 4 };
            int countB = 2;

            Merge(a, b, countA, countB);

            foreach (int num in a)
            {
                Console.Write("{0}  ", num);
            }

            Console.WriteLine();

        }

        static void Merge(int[] a, int[] b, int countA, int countB)
        {
            int lastA = countA - 1;
            int lastB = countB - 1;

            int lastMerged = countA + countB - 1;

            while (lastA >= 0 && lastB >= 0)
            {
                if (a[lastA] > b[lastB])
                {
                    a[lastMerged] = a[lastA];
                    lastMerged--;
                    lastA--;
                }
                else
                {
                    a[lastMerged] = b[lastB];
                    lastMerged--;
                    lastB--;
                }
            }

            while (lastB >= 0)
            {
                a[lastMerged] = b[lastB];
                lastMerged--;
                lastB--;
            }
        }
    }
}
