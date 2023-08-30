using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals_Task.Moduls
{
    internal abstract class Animal
    {
        private string nickname;
        public string Nickname
        {
            get { return nickname; }
            set
            {
                if (value != "")
                    nickname = value;
                else
                    Console.WriteLine("Nickname duzgun daxil etmediniz.");
            }
        }


        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0)
                    age = value;
                else
                    Console.WriteLine("Age duzgun daxil etmediniz.");
            }
        }


        private string gender;
        public string Gender
        {
            get { return gender; }
            set
            {
                if (gender != "")
                    gender = value;
                else
                    Console.WriteLine("Gender duzgun daxil etmediniz.");

            }
        }


        private float energy;
        public float Energy
        {
            get { return energy; }
            set
            {
                if (value >= 0 && value <= 100)
                    energy = value;
                else
                    Console.WriteLine("Energy duzgun daxil etmediniz.");
            }
        }


        private float price;
        public float Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                    price = value;
                else
                    Console.WriteLine("Price duzgun daxil etmediniz.");
            }
        }


        private float mealQuantity;
        public float MealQuantity
        {
            get { return mealQuantity; }
            set
            {
                if (value >= 0)
                    mealQuantity = value;
                else
                    Console.WriteLine("Meal Quantity duzgun daxil etmediniz.");
            }
        }
        
        public abstract void Eat();
        public abstract void Sleep();
        public abstract void Play();
        public abstract void Show();

        public Animal()
        {
            Nickname = "";
            Age = 0;
            Gender = "";
            Energy = 0;
            Price = 0;
            MealQuantity = 0;
        }
        public Animal(string nickname,int age,string gender,float energy,float price,float mealQuantity)
        {
            Nickname = nickname;
            Age = age;
            Gender =gender;
            Energy = energy;
            Price = price;
            MealQuantity = mealQuantity;
        }
    }
}


