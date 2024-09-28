using System;
using System.Text.Json;

namespace KnowledgeCheck;

internal class UILogic : HelperFunctions
{
    public static void UISwitchLogic(List<Object> recordList, int input)
    {
        while (true)
        {
            switch (input)
            {
                // Add a Meat item
                case 1:
                    var newMeatItem = new Meat();
                    
                    Console.WriteLine("What is the name of the Meat item?\n");
                    newMeatItem.Name = Console.ReadLine()!;
                    Console.WriteLine("\n");

                    Console.WriteLine("Give a description of the Meat item?\n");
                    newMeatItem.Description = Console.ReadLine()!;
                    Console.WriteLine("\n");

                    Console.WriteLine("What is the price of the Meat item?\n");
                    newMeatItem.Price = decimal.Parse(Console.ReadLine()!);
                    Console.WriteLine("\n");

                    Console.WriteLine("What is the quantity of the Meat item?\n");
                    newMeatItem.Quantity = int.Parse(Console.ReadLine()!);
                    Console.WriteLine("\n");

                    Console.WriteLine("Is the Meat item fresh, frozen, or from the deli?\n");
                    newMeatItem.FreshFrozenDeli = Console.ReadLine()!;
                    Console.WriteLine("\n");

                    AddFoodItem(newMeatItem, recordList);
                    break;
                    

                // Add a Vegetable item
                case 2:
                    var newVegetableItem = new Vegetable();
                    
                    Console.WriteLine("What is the name of the Vegetable item?\n");
                    newVegetableItem.Name = Console.ReadLine()!;
                    Console.WriteLine("\n");

                    Console.WriteLine("Give a description of the Vegetable item?\n");
                    newVegetableItem.Description = Console.ReadLine()!;
                    Console.WriteLine("\n");

                    Console.WriteLine("What is the price of the Vegetable item?\n");
                    newVegetableItem.Price = decimal.Parse(Console.ReadLine()!);
                    Console.WriteLine("\n");

                    Console.WriteLine("What is the quantity of the Vegetable item?\n");
                    newVegetableItem.Quantity = int.Parse(Console.ReadLine()!);
                    Console.WriteLine("\n");

                    Console.WriteLine("Is the Vegetable item fresh, frozen, or canned?\n");
                    newVegetableItem.FreshFrozenCanned = Console.ReadLine()!;
                    Console.WriteLine("\n");

                    AddFoodItem(newVegetableItem, recordList);
                    break;
                    

                // Add a Processed Food item
                case 3:
                    var newProcessedFoodItem = new ProcessedFood();
                    
                    Console.WriteLine("What is the name of the Processed Food item?\n");
                    newProcessedFoodItem.Name = Console.ReadLine()!;
                    Console.WriteLine("\n");

                    Console.WriteLine("Give a description of the Processed Food item?\n");
                    newProcessedFoodItem.Description = Console.ReadLine()!;
                    Console.WriteLine("\n");

                    Console.WriteLine("What is the price of the Processed Food item?\n");
                    newProcessedFoodItem.Price = decimal.Parse(Console.ReadLine()!);
                    Console.WriteLine("\n");

                    Console.WriteLine("What is the quantity of the Processed Food item?\n");
                    newProcessedFoodItem.Quantity = int.Parse(Console.ReadLine()!);
                    Console.WriteLine("\n");

                    Console.WriteLine("What is the expiration date of the Processed Food item?\n");
                    newProcessedFoodItem.ExpirationDate = DateTime.Parse(Console.ReadLine()!);
                    Console.WriteLine("\n");

                    AddFoodItem(newProcessedFoodItem, recordList);
                    break;
                    
                
                // Keep the loop going until the user enters a valid input    
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    Console.WriteLine("Press 1 to add a Meat item");
                    Console.WriteLine("Press 2 to add a Vegetable item");
                    Console.WriteLine("Press 3 to add a Processed Food item");
                    try
                    {
                        input = int.Parse(Console.ReadLine()!);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Invalid input.");
                        Console.WriteLine(e);
                        input = 0;
                    }
                    continue;
            }

            break;
        }
    }
}