using System;

namespace day2z1
{
    class MainClass
    {
        public static int CountOnes0(int n)
        {
            int res = 0;
            while (n!=0)
            {
                res ++;
                n >>= 1;
            }
            return res;
        }
        public static int InsertNumber(int sourse,int sum,int i, int j)
        {
           
            int countsum = CountOnes0(sum);
             for (int k=0;k<countsum;k++)
            {
                if (k>=i&&k<=j) { continue; }
                sum=sum & ~(1 << k);
            }
            return sourse | sum;
           
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(InsertNumber(8,15,0,0));
        }
    }
}
