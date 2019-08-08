using System;
namespace day1
{
    public static class MainClass
    {
        static void Zap(int[] mass)
        {
            Random rand = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rand.Next(0, 500);
            }

        }
        static void OutputArray(int[] Temp)
        {
            for (int i = 0; i < Temp.GetLength(0); i++)
            {


                Console.Write(Temp[i] + " ");

            }
            Console.WriteLine();

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Для запуска нажмите любую клавишу");
            Console.ReadKey();
            int[] mass = new int[20];
            Zap(mass);
            Console.WriteLine("Исходник:");
            OutputArray(mass);
            Console.WriteLine("быстрая сортировка:");
            int[] mass1 = mass;
            QuicksortClass.quicksort(mass1, 0, mass.Length - 1);
            OutputArray(mass1);
            Console.WriteLine("сортировка слиянием:");
            OutputArray(MergeClass.Merge(mass));

        }


    }
}
