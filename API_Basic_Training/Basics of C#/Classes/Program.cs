using System;


class Cat
{
    #region Public Properties
    public string name;
    public int age;
    #endregion

    #region Public Methods
    public void Meow()
    {
        Console.WriteLine($"{this.name} says meowwww!!");
    }
    #endregion
}

class Dog
{
    #region Public Properties
    public string name;
    public int foodInKg, remainingFood;
    #endregion

    static int TotalDogs;
    static int maxFoodInKg;

    #region Public Methods
    public Dog()
    {
        Console.WriteLine("This is Dog Constructor");
        maxFoodInKg = 10;

        TotalDogs++;
    }

    public void Eat()
    {
        this.remainingFood = maxFoodInKg - (this.foodInKg + 1);
        Console.WriteLine($"{this.name} has remaining {this.remainingFood} Kg of food");
    }

    public void ShowTotalDogs()
    {
        Console.WriteLine($"{TotalDogs} dogs are there");
    }

    public static void BuyFood()
    {
        maxFoodInKg = 10;
        Console.WriteLine("Food stores are now full");
    }
    #endregion
}


namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat charlie = new Cat();
            charlie.name = "Charlie";
            charlie.age = 2;
            charlie.Meow();
            Cat luna = new Cat();
            luna.name = "Luna";
            luna.age = 2;
            luna.Meow();


            Dog tuffy = new Dog();
            tuffy.name = "tuffy";
            tuffy.foodInKg = 1; //generally eats 1kg of food at a time
            tuffy.Eat();
            Dog oreo = new Dog();
            oreo.name = "oreo";
            oreo.foodInKg = 2;
            oreo.Eat();

            oreo.ShowTotalDogs();

            Dog.BuyFood(); //Cakling a Static method


        }
    }
}

