using System;
namespace bank
{
    public class account
    {
        
        int id;
        string name;
        string lastname;
        uint sum;
        int bonus;
        type tip;
        /// <summary> 
        /// закроем от людей изменение некоторых полей
        /// </summary>
      public string Name
        {
            get { return name; }
        }
        public string Lastname
        {
            get { return lastname; }
        }
        public uint Sum
        {
            get { return sum ; }
        }
        public int Bonus
        {
            get { return bonus; }
        }
        public type Tip
        {
            get { return tip; }
        }
        public int  ID
        {
            get { return id; }
        }

        public account(int id,string name,string lastname,uint sum,int bonus,type tip)//конструктор
        {
            this.id = id;
            this.name = name;
            this.lastname = lastname;
            this.sum = sum;
            this.bonus = bonus;
            this.tip = tip;
        }
    
        public void AddMoney()
        {
            Console.WriteLine("сколько деняк?");
            uint k = Convert.ToUInt32(Console.ReadLine());
            sum += k;
            
            double bon=0.1*k*(int)tip;
            bonus += (int)bon;
            Console.WriteLine("пополнение счета выполнено /n вам начисленоо {0} бонусов", (int)bon);
        }
        public void TakeMoney()
        {
            Console.WriteLine("укажите сумму которую выхотите снять");
            uint k = Convert.ToUInt32(Console.ReadLine());
            sum += k;
            if (k > sum)
            {
                Console.WriteLine("недостаточно средств");
                TakeMoney();

            }
            else
            {
                double bon = 0.05 * k * (int)tip;
                bonus += (int)bon;
                Console.WriteLine("операция прошла успешно /n вам начисленоо {0} бонусов", (int)bon);
            }
        }
        public override string ToString()
        {
            return "ФИ владельца: " + name + lastname +
                "/n На счету средств:" + sum +
                " и бонусов:" + bonus;
        }

    }
    }
}
