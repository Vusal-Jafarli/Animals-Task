using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Animals_Task.Moduls
{
    internal class Dog : Animal
    {
        public Dog() : base() { }
        public Dog(string nickname, int age, string gender, float energy, float price, float mealQuantity)
        : base(nickname, age, gender, energy, price, mealQuantity) { }

        public override void Eat()
        {
            if (Energy > 70)
                Energy = 100;
            else
                Energy += 30;
            Console.WriteLine($"{Nickname} yemek yedi.");
            Console.WriteLine("Energy 30% yukseldi.");
            Console.Write($"Energy:");
            if (Energy <= 20)
                Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Energy}%");
            Console.ForegroundColor = ConsoleColor.White;
            Price += 10;
            MealQuantity += 400;
        }

        public override void Play()
        {
            Console.WriteLine($"{Nickname} hal hazirda qacir.");
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
