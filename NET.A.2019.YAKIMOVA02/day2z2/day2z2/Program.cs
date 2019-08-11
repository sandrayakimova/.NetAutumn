using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;
namespace day2z2
{
    class MainClass
    { 
       
        public static int [] Selection(int i)
        {
            
            int [] arr = i.ToString().ToCharArray().Select(x => x - '0').ToArray();
            return arr;
        }
        public static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        


public static int FindNextBiggerNumber(int num)
        {
            if (num < 10)//в случае однозначного числа выбиваем -1
            {
                return -1;
            }
            else
            {
                if (num < 100)//в случае двузначого либо свапаем и получаем большее число либо выбиваем -1
                {
                    if ((num % 10) <= (num / 10)) { return -1; }
                    else
                    {
                        int a = num % 10;
                        num = num / 10;
                        return a * 10 + num;

                    }

                }
                else
                {
                    int d = (num % 100) / 10;
                    int e = num % 10;
                    if (d < e)
                    {
                        num /= 100;
                        num *= 100;
                        num += e * 10;
                        num += d;
                        return num;
                    }
                    else

                    {
                        int[] array = Selection(num);//разобьем числов в массив его цифр

                        int i = array.Length - 1;//поставим "курсор" в конец
                        while (array[i] <= array[i - 1] && (i > 1)) //идем из конца в начало и смотрим  если увеличиваются цифры 
                        {
                            i--;

                        }
                        if ((i == 1) && array[0] >= array[1]) { return -1; }
                        else
                        {
                            int marker = array[i -1];
                            int markeri = i - 1;
                            if (marker < array[array.Length - 1])
                            {
                                swap(ref array[markeri], ref array[array.Length - 1]);
                                for (int j = i; j < array.Length; j++)
                                {
                                    if (j > array.Length - j + i - 1) { break; }
                                    swap(ref array[j], ref array[array.Length - j + i - 1]);


                                }
                            }
                            else
                            if (marker == array[array.Length - 1])
                            {
                                int k = array.Length - 2;
                                while (marker==array[k])
                                {
                                    k--;
                                }
                                swap(ref array[markeri], ref array[k]);
                                for (int j = i; j < array.Length; j++)
                                {
                                    if (j > array.Length - j + i - 1) { break; }
                                    swap(ref array[j], ref array[array.Length - j + i - 1]);


                                }
                            }
                            else
                            {
                                while (marker > array[i])
                                {
                                    i++;
                                }
                                swap(ref array[markeri], ref array[i - 1]);
                                for (int j = markeri + 1; j < array.Length; j++)
                                {
                                    if (j > array.Length - j + i - 1) { break; }
                                    swap(ref array[j], ref array[array.Length - j + i - 1]);
                                }
                            }
                            int otv = array[0];
                            for (i = 1; i < array.Length; i++)
                            {
                                otv = otv * 10 + array[i];
                            }
                            return otv;

                        }



                    }
                }
            }
           
        }
        public static void Main(string[] args)
        {
            int i = 100100;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.WriteLine(FindNextBiggerNumber(i));
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine(elapsedTime, "RunTime");        }
    }
}

