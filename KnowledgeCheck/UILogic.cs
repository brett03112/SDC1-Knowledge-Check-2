using System;
using System.Text.Json;

namespace KnowledgeCheck;

internal class UILogic : HelperFunctions
{
    public static void UISwitchLogic(int input)
    {
        
        List<Food> _foodList = new List<Food>();
        while (true)
        {
            Console.ReadLine();

            switch (input)
            {
                // Add a Meat item
                case 1:
                    var newMeatItem = new Meat();
                    var options = NewOptions();
                    Console.WriteLine("What is the name of the Meat item?");
                    newMeatItem.Name = Console.ReadLine()!;

                    Console.WriteLine("Give a description of the Meat item?");
                    newMeatItem.Description = Console.ReadLine()!;

                    Console.WriteLine("What is the price of the Meat item?");
                    newMeatItem.Price = decimal.Parse(Console.ReadLine()!);

                    Console.WriteLine("What is the quantity of the Meat item?");
                    newMeatItem.Quantity = int.Parse(Console.ReadLine()!);

                    Console.WriteLine("Is the Meat item fresh, frozen, or from the deli?");
                    newMeatItem.FreshFrozenDeli = Console.ReadLine()!;

                    _foodList.AddFoodItem(newMeatItem);

                    JsonSerializer.Serialize(value: newMeatItem, options: options);
                    break;

                // Add a Vegetable item
                case 2:
                    var newVegetableItem = new Vegetable();
                    var options2 = NewOptions();

                    Console.WriteLine("What is the name of the Vegetable item?");
                    newVegetableItem.Name = Console.ReadLine()!;

                    Console.WriteLine("Give a description of the Vegetable item?");
                    newVegetableItem.Description = Console.ReadLine()!;

                    Console.WriteLine("What is the price of the Vegetable item?");
                    newVegetableItem.Price = decimal.Parse(Console.ReadLine()!);

                    Console.WriteLine("What is the quantity of the Vegetable item?");
                    newVegetableItem.Quantity = int.Parse(Console.ReadLine()!);

                    Console.WriteLine("Is the Vegetable item fresh, frozen, or canned?");
                    newVegetableItem.FreshFrozenCanned = Console.ReadLine()!;

                    JsonSerializer.Serialize(value: newVegetableItem, options: options2);
                    break;

                // Add a Processed Food item
                case 3:
                    var newProcessedFoodItem = new ProcessedFood();
                    var options3 = NewOptions();

                    Console.WriteLine("What is the name of the Processed Food item?");
                    newProcessedFoodItem.Name = Console.ReadLine()!;

                    Console.WriteLine("Give a description of the Processed Food item?");
                    newProcessedFoodItem.Description = Console.ReadLine()!;

                    Console.WriteLine("What is the price of the Processed Food item?");
                    newProcessedFoodItem.Price = decimal.Parse(Console.ReadLine()!);

                    Console.WriteLine("What is the quantity of the Processed Food item?");
                    newProcessedFoodItem.Quantity = int.Parse(Console.ReadLine()!);

                    Console.WriteLine("What is the expiration date of the Processed Food item?");
                    newProcessedFoodItem.ExpirationDate = DateTime.Parse(Console.ReadLine()!);

                    JsonSerializer.Serialize(value: newProcessedFoodItem, options: options3);
                    break;
                
                // Keep the loop going until the user enters a valid input    
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    continue;
            }
        }
    }

    public static void DisplayChoiceMenu()
    {
        Console.WriteLine("Press 1 to add a Meat item");
        Console.WriteLine("Press 2 to add a Vegetable item");
        Console.WriteLine("Press 3 to add a Processed Food item");
    }
}