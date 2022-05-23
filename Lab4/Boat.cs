using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Boat: Vessel 
    {
        int fuel = 2000;
        public Boat()
        {
            speed = 70;
            typeoffuel = "distillate fuel";
        }
        public override void Move()
        {
            fuel = fuel - 100;
            if (fuel > 0)
            {
                Console.WriteLine("Катер рухається");
            }
            fuel = fuel - 100;
            if(fuel == 0)
            {
                Console.WriteLine("Катер треба дозаправити. Хочете це зробити?\n 1 - так, 2 - нi");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    FuelCount();
                }
                else if (choice == "2")
                    Console.WriteLine("В катерi немає пального.");
            }
        }
        public override void FuelCount()
        {
            Console.WriteLine("Введiть кiлькiсть лiтрiв, щоб дозаправити катер (не бiльше нiж 2000).");
            int k = Convert.ToInt32(Console.ReadLine());
            if (k > 0 && k < 2000)
            {
                if (fuel == 2000)
                {
                    Console.WriteLine("Запрвка неможлива. Бак повний.");
                }
                fuel = k + fuel;
                if (fuel > 2000)
                {
                    Console.WriteLine("Бак буде переповнений.Введiть меншу кількість літрів.");
                    fuel = fuel - k;
                    FuelCount();
                }
                else
                    Console.WriteLine("Катер дозаправлено. Кількість літрів пального: " + fuel);
            }
            else
            {
                Console.WriteLine("Кiлькiсть лiтрiв завелика. Спробуйте знову.");
                FuelCount();
            }
        }
        public override string ToString()
        {
            return $"Катер\nТип пального: {typeoffuel}";
        }
    }
}
