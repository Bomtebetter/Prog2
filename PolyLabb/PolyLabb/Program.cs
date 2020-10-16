using System;

namespace PolyLabb
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            Banana banana = new Banana();
            banana.Curvature = "very curved";
            banana.StockStatus = 5;

            Apple apple = new Apple();
            apple.Sweetness = "very sweet";
            apple.StockStatus = 8;

            Orange orange = new Orange();
            orange.Clefts = 13;
            orange.StockStatus = 12;

            int orderAmount;

            while (true)
            {
                Console.WriteLine("How many bananas do you want?");
                orderAmount = Convert.ToInt32(Console.ReadLine());
                if (orderAmount <= banana.StockStatus)
                {
                    banana.Amount = orderAmount;
                    customer._cart.Add(banana);
                    banana.StockStatus = banana.StockStatus - orderAmount;
                    orderAmount = 0;
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry we dont have that many bananas, we only have: " + banana.StockStatus);
                    orderAmount = 0;
                    continue;
                }
            }
            
            while (true)
            {
                Console.WriteLine("How many apples do you want?");
                orderAmount = Convert.ToInt32(Console.ReadLine());
                if (orderAmount <= apple.StockStatus)
                {
                    apple.Amount = orderAmount;
                    customer._cart.Add(apple);
                    apple.StockStatus = apple.StockStatus - orderAmount;
                    orderAmount = 0;
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry we dont have that many apples, we only have: " + apple.StockStatus);
                    orderAmount = 0;
                    continue;
                }
            }
            
            while (true)
            {
                Console.WriteLine("How many oranges do you want?");
                orderAmount = Convert.ToInt32(Console.ReadLine());
                if (orderAmount <= orange.StockStatus)
                {
                    orange.Amount = orderAmount;
                    customer._cart.Add(orange);
                    orange.StockStatus = orange.StockStatus - orderAmount;
                    orderAmount = 0;
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry we dont have that many oranges, we only have: " + orange.StockStatus);
                    orderAmount = 0;
                    continue;
                }
            }

            Console.WriteLine("Here is what you ordered: ");
            foreach (var product in customer._cart)
            {
                if (product.GetType() == typeof(Banana))
                {
                    if (banana.Amount > 0)
                    {
                        Console.WriteLine("You ordered " + ((Banana)product).Amount + " bananas");
                        Console.WriteLine("The bananas are " + ((Banana)product).Curvature);
                    }
                   
                }
                else if (product.GetType() == typeof(Apple))
                {
                    if (apple.Amount > 0)
                    {
                        Console.WriteLine("You ordered " + ((Apple)product).Amount + " apples");
                        Console.WriteLine("The apples are " + ((Apple)product).Sweetness);
                    }
                    
                }
                else if (product.GetType() == typeof(Orange))
                {
                    if (orange.Amount > 0)
                    {
                        Console.WriteLine("You ordered " + ((Orange)product).Amount + " oranges");
                        Console.WriteLine("The oranges have " + ((Orange)product).Clefts + " clefts");
                    }
                    
                }
            }


        }
    }
}
