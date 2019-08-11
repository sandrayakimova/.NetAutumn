using System;

namespace day2z4
{
    class MainClass
    {
        public static void FilterDigit (int [] temp,int dig)
        {
            string digch =Convert.ToString(dig);
            for (int i=0;i<temp.Length;i++)
            {
                string numstr = Convert.ToString(temp[i]);
                if (numstr.IndexOf(digch)!=-1)
                {
                    Console.WriteLine(numstr);
                }
            }
        }
        public static void Main(string[] args)
        {
            int[] mass = { 70, 12, 4, 76, 7 };
            FilterDigit(mass, 7);

        }
    }
}
