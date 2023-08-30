using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_Task.Moduls
{
    internal class Cat : Animal
    {
        public Cat() : base() { }
        public Cat(string nickname, int age, string gender, float energy, float price, float mealQuantity)
        : base(nickname, age, gender, energy, price, mealQuantity) { }

        public override void Eat()
        {
            if (Energy > 80)
                Energy = 100;
            else
                Energy += 20;
            Console.WriteLine($"{Nickname} yemek yedi.");
            Console.WriteLine("Energy 20% yukseldi.");
            Console.Write($"Energy:");
            if (Energy <= 20)
                Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Energy}%");
            Console.ForegroundColor = ConsoleColor.White;
            Price += 5;
            MealQuantity += 100;
        }

        public override void Play()
        {

            if (Energy < 15)
            {
                Console.WriteLine($"{Nickname} enerjisi yeterince deyil.Hal hazirda oynamaq istemir.");
                Console.WriteLine($"{Nickname} yatmalidir.");
            }
            else
            {
                Console.WriteLine($"{Nickname} hal hazirda oynayir.");
                Energy -= 15;
            }
        }

        public override void Show()
        {
            Console.WriteLine($"Nickname: {Nickname}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Gender: {Gender}");
            if (Energy <= 20)
                Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Energy: {Energy}%");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Price: {Price}$");
            Console.WriteLine($"Meal Quantity: {MealQuantity}qr");
        }

        public override void Sleep()
        {
            if (Energy > 20)
                Energy = 100;
            else
                Energy += 80;
            Console.WriteLine($"{Nickname} yatir.");
            Console.WriteLine("Energy 80% yukseldi.");
            Console.WriteLine($"Energy: {Energy}");
        }
    }
}

