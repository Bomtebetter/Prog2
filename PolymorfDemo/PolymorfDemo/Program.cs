using System;
using System.Collections.Generic;

namespace PolymorfDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> cart = new List<Product>();

            Milk milk = new Milk();
            milk.FatPercentage = 1;
            milk.ProductNumber = 123;
            milk.StockStatus = 10;
            cart.Add(milk);

            Coffee coffee = new Coffee();
            coffee.Roastyness = "Dark roast";
            coffee.ProductNumber = 234;
            coffee.StockStatus = 15;
            cart.Add(coffee);

            Monster monster = new Monster();
            monster.Flavour = "Absoulute";
            monster.ProductNumber = 345;
            monster.StockStatus = 20;
            cart.Add(monster);

            foreach (var product in cart)
            {
                if (product.GetType() == typeof(Milk))
                {
                    Console.WriteLine(((Milk)product).FatPercentage);
                }
                else if (product.GetType() == typeof(Coffee))
                {
                    Console.WriteLine(((Coffee)product).Roastyness);
                }
                else if (product.GetType() == typeof(Monster))
                {
                    Console.WriteLine(((Monster)product).Flavour);
                }
            }

        }
    }
}
