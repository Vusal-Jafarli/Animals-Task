using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Animals_Task.Moduls
{
    internal class Fish : Animal
    {
        public Fish() : base() { }
        public Fish(string nickname, int age, string gender, float energy, float price, float mealQuantity)
        : base(nickname, age, gender, energy, price, mealQuantity) { }

        public override void Eat()
        {
            if (Energy > 55)
                Energy = 100;
            else
                Energy += 45;
            Console.WriteLine($"{Nickname} yemek yedi.");
            Console.WriteLine("Energy 45% yukseldi.");
            Console.Write($"Energy:");
            if (Energy <= 20)
                Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Energy}%");
            Console.ForegroundColor = ConsoleColor.White;
            Price += 0.85f;
            MealQuantity += 5;
        }

        public override void Play()
        {
            Console.WriteLine($"{Nickname} hal hazirda uzur.");
        }

        public override void Show()
        {
            Console.WriteLine($"Nickname: {Nickname}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Energy: {Energy}%");
            Console.WriteLine($"Price: {Price}$");
            Console.WriteLine($"Meal Quantity: {MealQuantity}qr");
        }

        public override void Sleep()
        {
            Console.WriteLine($"{Nickname} yatir.");
        }
    }
}
