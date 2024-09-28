using System;
using System.Text.Json;


namespace KnowledgeCheck;


internal class HelperFunctions 
{    
    /// <summary>
    /// Adds the food item to the food list. If the item is a subtype of Food, it is added
    /// to the list. If the item is not a subtype of Food, it is not added to the list.
    /// </summary>
    /// <param name="item">The item to add to the list.</param>
    /// <param name="foodList">The list to which the item is added.</param>
    public static void AddFoodItem(Food? item, List<Object> foodList)
    {
        if (item is Meat meat)
        {
            foodList.Add(meat);
        }
        else if (item is ProcessedFood processedFood)
        {
            foodList.Add(processedFood);
        }
        else if (item is Vegetable vegetable)
        {
            foodList.Add(vegetable);
        }
    }
    
    /// <summary>
    /// Returns a JsonSerializerOptions object with the following settings:
    ///     - IncludeFields is set to true, which includes all fields when serializing.
    ///     - PropertyNameCaseInsensitive is set to true, which makes the property names case insensitive.
    ///     - WriteIndented is set to true, which makes the output of the serializer indented.
    ///     - PropertyNamingPolicy is set to JsonNamingPolicy.CamelCase, which makes the property names camel case.
    /// </summary>
    public static JsonSerializerOptions NewOptions()
    {
        JsonSerializerOptions options = new()
        {
            IncludeFields = true, // Includes all fields.
            PropertyNameCaseInsensitive = false,
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        };

        return options;
    }
    public static decimal GetTotalPrice(List<Object> foodList)
    {
        decimal totalPrice = 0;
        foreach (var item in foodList)
        {
            if (item is Food food)
            {
                totalPrice += food.Price * food.Quantity;
            }
        }
        return totalPrice;
    }
}