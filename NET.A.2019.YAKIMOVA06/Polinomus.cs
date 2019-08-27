using System;
namespace day6z1
{
    public class Polinomus
    {
       public  int degree;
       public int[] coef;

    
        public override string ToString() //<example> degree=3 coef={4,5,6,7} polin="4x^3+5x^2+6x+7
        {
            string polin=null;
            for (int i = 0; i<degree-1;i++)
                {
                if (coef[i]==0) { continue; }
                polin += Convert.ToString(coef[i]) + "x^" + Convert.ToString(degree - i)+"+";

            }
            polin += Convert.ToString(coef[degree-1])+"x+" + Convert.ToString(coef[degree]);

            return polin;
        }
        public static bool operator ==(Polinomus pol1,Polinomus pol2) //we compare there degree and coefitients 
        {
            if (pol1.degree!=pol2.degree) { return false; }
            else
            {
                for (int i=0;i<=pol2.degree;i++)
                {
                    if (pol1.coef[i]!=pol2.coef[i]) { return false; }
                }
                return true;
            }
        }
        public static bool operator !=(Polinomus pol1, Polinomus pol2)
        {
            if (pol1.degree != pol2.degree) { return true; }
            else
            {
                for (int i = 0; i <= pol2.degree; i++)
                {
                    if (pol1.coef[i] != pol2.coef[i]) { return true; }
                }
                return false;
            }

        }
        public static Polinomus operator + (Polinomus pol1, Polinomus pol2) //when you sum 2 polinoms you create new polinom with sum of their coeffitients
        {
            Polinomus otv = new Polinomus();
            if (pol1.degree > pol2.degree)
            {
                for (int i = 0; i <= pol1.degree; i++)
                {
                    if (i <= pol2.degree)
                    {
                        otv.coef[i] = pol1.coef[i] + pol2.coef[i];
                    }
                    else { otv.coef[i] = pol1.coef[i]; }
                }
            } else
            {
                for (int i = 0; i <= pol2.degree; i++)
                {
                    if (i <= pol1.degree)
                    {
                        otv.coef[i] = pol1.coef[i] + pol2.coef[i];
                    }
                    else { otv.coef[i] = pol2.coef[i]; }
                }
            }
            return otv;
        }

    }
}
