using System;

namespace day6z2
{
    class MainClass
    {
         public struct Fl
            /*сформировали структуру  чтобы потом сформировать импровизированную
             * таблицу из номера строки ,суммы строки ,максимального элемента  и тд */
        {
            public int index;
            public int sum;
            public int max;
             public int min;
           

        }
        public static Fl []  FormFlags(int[] [] temp)
        {
            //сформируем эту таблицу
            
            int t = temp.GetLength(0);
            Fl[] s = new Fl[t];
            for (int i = 0; i < temp.GetLength(0); i++)
            {
                
                int sum = 0;
                int max=temp[i][0];
                int min=temp[i][0];

                for (int j = 0; j < temp[i].Length; j++)
                {

                    sum += temp[i][ j];
                    if (max<temp[i][j])
                    {
                        max = temp[i][ j];
                    }
                    if (min>temp[i][j])
                    {
                        min = temp[i][j];
                    }
                }
                

                s[i].index = i;
                
                s[i].sum = sum;
                
                s[i].max = max;
           
                s[i].min = min;
                Console.Write(s[i].index + " " + s[i].sum + " " + s[i].max + " " + s[i].min);
                Console.WriteLine();


            }
            return s;
            
        }
        
        public static void FormOrderedArray(int[][]temp , Fl[] s)
        {
            //после того когда мы нашу импровизированную таблицу отсортировали по нужному параметру нам нужно воссоздать по ней матрицу
            int[][] otv = new int[temp.Length] [];

            for (int i = 0; i < temp.GetLength(0); i++)
            {
                
                for (int j = 0; j < temp[s[i].index].Length; j++)
                    
                {
                    int ind = s[i].index;
                    Console.Write(temp[ind][j]+" ");
                    
                }
                Console.WriteLine();
            }
          
        }
      /*  public static int[][] OrderbysumGr(int[][] temp,Fl[] s)
        {
            //сортировка по возрастанию по сумме

            
            Fl sw;
            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i].sum > s[j].sum)
                    {
                        sw = s[i];
                        s[i] = s[j];
                        s[j] = sw;
                    }
                }
            }
            return FormOrderedArray(temp, s);
        }

        public static int[][] OrderbysumLw(int[][] temp, Fl[] s)
        {
            //сортировке по убыванию по сумме

            Fl sw;
            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i].sum < s[j].sum)
                    {
                        sw = s[i];
                        s[i] = s[j];
                        s[j] = sw;
                    }
                }
            }
            return FormOrderedArray(temp, s);
        }
        */
        public static void OrderbyMaxGr(int[] [] temp, Fl[] s)
        {
            //сортировка по возрастанию по макс элементу
            Fl sw;
            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i].max > s[j].max)
                    {
                        sw = s[i];
                        s[i] = s[j];
                        s[j] = sw;
                    }
                }
            }
            /*for (int i = 0; i < s.Length;i++)
            {
                Console.Write(s[i].index + " " + s[i].sum + " " + s[i].max + " " + s[i].min);
                Console.WriteLine();
            }
            OutputArray(temp);
            */
            FormOrderedArray(temp, s);
        }
       /* public static int[][] OrderbyMaxLw(int[][] temp, Fl[] s)
        {
            //сортировка по убыванию по макс элементу
            Fl sw;
            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i].max < s[j].max)
                    {
                        sw = s[i];
                        s[i] = s[j];
                        s[j] = sw;
                    }
                }
            }
            return FormOrderedArray(temp, s);
        }
        public static int[][] OrderbyMinGr(int[][] temp, Fl[] s)
        {
            //сортировка по мин элементу по возрастанию
            Fl sw;
            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i].min > s[j].min)
                    {
                        sw = s[i];
                        s[i] = s[j];
                        s[j] = sw;
                    }
                }
            }
            return FormOrderedArray(temp, s);
        }

        public static int[][] OrderbyMinLw(int[][] temp, Fl[] s)
        {
            //сортировка по мин элементу по убыванию
            Fl sw;
            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i].min < s[j].min)
                    {
                        sw = s[i];
                        s[i] = s[j];
                        s[j] = sw;
                    }
                }
            }
            return FormOrderedArray(temp, s);
        } */
         public static void OutputArray(int[] [] Temp)
        {
            for (int i = 0; i < Temp.GetLength(0); i++)
            {
                for (int j = 0; j < Temp[i].Length; j++)
                {
                    Console.Write(Temp[i][ j] + " ");

                }
                Console.WriteLine();
            }
        }

   
        public static void Main(string[] args)
        {
            int[][] nums = new int[3][];
            nums[0] = new int[4] { 1, 2,8,9 };          
            nums[1] = new int[3] { 0, 7, 4 };       
            nums[2] = new int[5] { 3, 2, 3, 4, 5 };
            Console.WriteLine("Исходный массив:");
            OutputArray(nums);
            Fl[] flags = FormFlags(nums);
            Console.WriteLine("сортировка по возрастанию по сумме:");
            OrderbyMaxGr(nums, flags);



        }
    }
}
