using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Cargo_ship: Vessel
    {
        public int load_capacity = 20000;
        int fuel = 2000;
        protected string name = "Вантажне судно";
        public Cargo_ship()
        {
            speed = 60;
            typeoffuel = "residual fuel";
        }
        public override void Move()
        {
            if (fuel > 0)
            {
                Console.WriteLine(name + " рухається");
            }
            fuel = fuel - 100;
            if (fuel == 0)
            {
                Console.WriteLine(name + " треба дозаправити. Хочете це зробити?\n 1 - так, 2 - нi");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    FuelCount();
                }
                else if (choice == "2")
                    Console.WriteLine("Немає пального.");
            }
        }
        public override void FuelCount()
        {
            Console.WriteLine($"Введiть кiлькiсть лiтрiв, щоб дозаправити {name} (не бiльше нiж 2000).");
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
                    Console.WriteLine("Бак буде переповнений.Введiть меншу кiлькiсть лiтрiв.");
                    fuel = fuel - k;
                    FuelCount();
                }
                else
                    Console.WriteLine(name + " дозаправлено. Кiлькiсть лiтрiв пального: " + fuel);
            }
            else
            {
                Console.WriteLine("Кiлькiсть лiтрiв завелика. Спробуйте знову.");
                FuelCount();
            }
        }

        public override string ToString()
        {
            return $"Вантажне судно\nТип пального: {typeoffuel}";
        }
    }
}
