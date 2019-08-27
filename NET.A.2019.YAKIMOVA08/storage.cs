using System;
using System.Collections.Generic;
using System.IO;
namespace bank
{
    public  class storage
    {

       public  List<account> counts = new List<account>();//архив всех аккаунтов
      /// <summary>
      /// для создания счета вас попросят указать свою имя и фамилию и тип карты
      /// на счету изначально нет денег и чтобы добавить придется воспользоваться функцией addmoney
      /// </summary>
        public  void AddAccount()
        {
            Console.WriteLine("введите свое имя");
            string Name = Console.ReadLine();
            Console.WriteLine("введите фамилию");
            string LN = Console.ReadLine();
            uint s = 0;
            int b = 0;
            Console.WriteLine("Введите какoй типа карты выхотите 1->Base /n 2->Gold 3->Platinum");
           int k=Convert.ToInt32(Console.ReadLine());
            type t = (type)k;
            int i = counts.Count;
            Console.WriteLine("ваш ID:" + i);
            account acc = new account(i,Name, LN, s, b, t);
            counts.Add(acc);
        }
        /// <summary>
        /// удаление происходит по вводимому ID c перепроверкой имени владельца
        /// </summary>
        public  void RemoveAccount()
        {
            Console.WriteLine("введите ID своей карты");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите свое имя");
            string n = Console.ReadLine();
            if (counts[id].Name == n)
            {

                counts.Remove(counts[id]);
            }
            else
            {
                Console.WriteLine("ваши реквизиты не совпадают!проверьте вводимые данные");
            }
        }
        public static string fail = "/Users/sandrayakimova/Projects";
        static FileStream destFile = new FileStream(fail, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        BinaryWriter writer = new BinaryWriter(destFile);
        public void save()
        {
            foreach (account b in counts)
            {
                writer.Write(b.ID);
                writer.Write(b.Name);
                writer.Write(b.Lastname);
                writer.Write(b.Sum);
                writer.Write(b.Bonus);
            }
            writer.Close();
            destFile.Close();
        }
    }
}
