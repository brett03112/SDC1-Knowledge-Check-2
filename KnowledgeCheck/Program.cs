using System;
using System.Text.Json;
using KnowledgeCheck;

var groceryList = new List<Object>();
Console.WriteLine("How many items do you want to add to the grocery list? ");
var numberOfGroceryItems = int.Parse(Console.ReadLine()!);


for (int i = 0; i < numberOfGroceryItems; i++)
{
	// In this loop, populate the object's properties using Console.ReadLine()
	Console.WriteLine("Press 1 to add a Meat item");
	Console.WriteLine("Press 2 to add a Vegetable item");
	Console.WriteLine("Press 3 to add a Processed Food item");

	int input;
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

	
	UILogic.UISwitchLogic(groceryList, input);
	Console.Clear();	
}



// Print out the list of records using Console.WriteLine()

var options = HelperFunctions.NewOptions();
foreach (var item in groceryList)
{
	string json = JsonSerializer.Serialize(item, options: options);
	Console.WriteLine(json);
}
Console.WriteLine("\n");
Console.WriteLine($"The total price of your items comes to ${HelperFunctions.GetTotalPrice(groceryList)}");
Console.WriteLine("Thank you for using the grocery list app. Goodbye!");