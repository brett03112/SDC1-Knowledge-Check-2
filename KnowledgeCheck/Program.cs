using System;
using KnowledgeCheck;

Console.WriteLine("How many items do you want to add to the grocery list? ");
var numberOfGroceryItems = int.Parse(Console.ReadLine()!);

var groceryList = new List<Food>();
for (int i = 0; i < numberOfGroceryItems; i++)
{
	// In this loop, populate the object's properties using Console.ReadLine()
	var myFood = new Food();

	Console.WriteLine("Enter the value for ");
	myClass.myProperty = Console.ReadLine();

	recordList.Add(myClass);
}

// Print out the list of records using Console.WriteLine()