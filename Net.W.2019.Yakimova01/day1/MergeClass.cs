using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Collections;

namespace day1
{
    public static class MergeClass
    {
        public static int[] Merge(int[] mass)
        {
            if (mass.Length == 1)
            {
                return mass;
            }

            int mid = mass.Length / 2;
            return Together(Merge(mass.Take(mid).ToArray()), Merge(mass.Skip(mid).ToArray()));
        }

        static int[] Together(int[] mass1, int[] mass2)
        {
            int compmerge = 0;
            int m1 = 0, m2 = 0;
            int[] merged = new int[mass1.Length + mass2.Length];
            for (int i = 0; i < merged.Length; i++)
            {
                compmerge++;
                if (m1 < mass1.Length && m2 < mass2.Length)
                {
                    if (mass1[m1] > mass2[m2] && m2 < mass2.Length)
                    {
                        merged[i] = mass2[m2++];
                    }
                    else
                    {
                        merged[i] = mass1[m1++];
                    }
                }
                else if (m2 < mass2.Length)
                {
                    merged[i] = mass2[m2++];
                }
                else
                {
                    merged[i] = mass1[m1++];
                }
            }
            return merged;


        }

    }
}
