using System;
using System.Collections.Generic;

namespace conproj
{
    public class Datacompare: IComparer<Data>
    {
        public int Compare(Data d1,Data d2)
        {
            if(d1.year>d2.year) { return 1; }
            else
            {
                if (d1.year<d2.year) { return -1; }
                else
                {
                    if (d1.month > d2.month) { return 1; }
                    else
                    {
                        if (d1.month < d2.month) { return -1; }
                        else
                        {
                            if (d1.day > d2.day) { return 1; }
                            else
                            {
                                if (d1.day < d2.day) { return -1; }
                                else return -1;
                            }
                        }
                    }
                }
            }
        }

    }
}
