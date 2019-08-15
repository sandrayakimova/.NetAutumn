using System;
namespace nodlib
{
    /// <summary>
    /// организовали 4 метода нахождения нода
    /// </summary>
    public  static class NodLib
    {
        public static int DoubleNod(int a, int b)
        {
            while ((a != 0) && (b != 0))
            {
                if (a > b) { a = a % b; }
                else { b = b % a; }
            }
            return Math.Max(a, b);
        }
        public static int NodEvk(params int[] a)
        {
            int nod = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                nod = DoubleNod(nod, a[i]);
                if (nod == 1) { break; }

            }
            return nod;


        }
        public static int BinaryNod(int a, int b)
        {
            if (a == b)
                return a;
            if (a == 0)
                return b;
            if (b == 0)
                return a;
            if ((~a & 1) != 0)
            {
                if ((b & 1) != 0)
                    return BinaryNod(a >> 1, b);
                else
                    return BinaryNod(a >> 1, b >> 1) << 1;
            }
            if ((~b & 1) != 0)
                return BinaryNod(a, b >> 1);
            if (a > b)
                return BinaryNod((a - b) >> 1, b);
            return BinaryNod((b - a) >> 1, a);
        }
        public static int NodBin(params int[] a)
        {
            int nod = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                nod = BinaryNod(nod, a[i]);
                if (nod == 1) { break; }

            }
            return nod;


        }

    }
}
