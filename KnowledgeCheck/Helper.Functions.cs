using System;


namespace KnowledgeCheck;


public class HelperFunctions
{
    /// <summary>
    /// Returns an empty list of Food objects.
    /// </summary>
    /// <returns>An empty list of Food objects.</returns>
    public static List<Food> GetFoodList()
    {
        return new List<Food>();
    }

    /// <summary>
    /// Add a new <see cref="Food"/> object to the list.
    /// </summary>
    /// <param name="foodList">The list to add the new object to.</param>
    public static void AddFoodToList(List<Food> foodList)
    {
        // Add a new food object to the list
        foodList.Add(new Food());
    }

    /// <summary>
    /// Prints the list of <see cref="Food"/> objects to the console.
    /// </summary>
    /// <param name="foodList">The list of <see cref="Food"/> objects to print.</param>
    public static void PrintList(List<Food> foodList)
    {
        foreach (var item in foodList)
        {
            Console.WriteLine(item);
        }
    }
}