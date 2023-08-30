using Animals_Task.Moduls;
Animal[] RemoveByNickname(Animal[] animal, string nickname)
{
    int index = -1;
    for (int i = 0; i < animal.Length; i++)
    {
        if (nickname == animal[i].Nickname)
        {
            index = i; break;
        }
    }
    if (index != -1)
    {
        Animal[] new_arr = new Animal[animal.Length - 1];

        for (int i = 0; i < index; i++)
            new_arr[i] = animal[i];
        for (int i = index + 1; i < animal.Length; i++)
            new_arr[i - 1] = animal[i];

        return new_arr;
    }
    return animal;
}

float TotalMeal(Animal[] animal)
{
    float total_meal = 0;
    foreach (var item in animal)
    {
        total_meal += item.MealQuantity;
    }
    return total_meal;
}

float TotalPrice(Animal[] animal)
{
    float total_price = 0;
    foreach (var item in animal)
    {
        total_price += item.Price;
    }
    return total_price;
}


Animal[] cats = new Cat[3];
cats[0] = new Cat("Lop", 1, "Male", 10, 500, 100);
cats[1] = new Cat("Pol", 2, "Male", 0, 234, 120);
cats[2] = new Cat("Elicy", 0, "Female", 80, 500, 90);

Animal[] dogs = new Dog[4];
dogs[0] = new Dog("Erik", 3, "Male", 10, 600, 400);
dogs[1] = new Dog("Ruka", 2, "Female", 40, 1000, 600);
dogs[2] = new Dog("Gimi", 0, "Female", 50, 500, 350);
dogs[3] = new Dog("Laky", 0, "Male", 20, 500, 400);

Animal[] birds = new Bird[3];
birds[0] = new Bird("Banjo", 1, "Female", 90, 100, 10);
birds[1] = new Bird("Flossy", 1, "Female", 85, 80, 50);
birds[2] = new Bird("Ozzy", 0, "Female", 70, 120, 10);

Animal[] fishes = new Fish[3];
fishes[0] = new Fish("Blue", 0, "Male", 40, 10, 5);
fishes[1] = new Fish("Oscar", 0, "Female", 100, 8, 10);
fishes[2] = new Fish("Nemo", 0, "Male", 100, 15, 10);



Animal[][] animals = new Animal[4][];
animals[0] = cats;
animals[1] = dogs;
animals[2] = birds;
animals[3] = fishes;



#region Remove By Nickname
Animal[] new_dogs = RemoveByNickname(animals[1], "Erik");

foreach (var item in new_dogs)
{
    item.Show();
    Console.WriteLine();
}
#endregion

#region Total Meal

float total_meal = TotalMeal(animals[0]);
Console.WriteLine($"Total Meal: {total_meal}");
#endregion

#region Total Price
float total_price = TotalMeal(animals[2]);
Console.WriteLine($"Total Price: {total_price}");
#endregion

//ByVC