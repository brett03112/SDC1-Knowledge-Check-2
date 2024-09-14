using System;
using System.Text.Json;


namespace KnowledgeCheck;


internal class HelperFunctions 
{
    private static List<Dictionary<string, object>>? _foodList;

    private static Dictionary<string, Meat>? _meatDictionary;

    private static Dictionary<string, ProcessedFood>? _processedFoodDictionary;

    private static Dictionary<string, Vegetable>? _vegetableDictionary;
    
    
    
        /// <summary>
        /// Adds a food item to the appropriate dictionary based on its type
        /// </summary>
        /// <param name="item">The food item to add</param>
        /// <exception cref="ArgumentException">If the item is null</exception>
        /// <exception cref="ArgumentNullException">If the item is null</exception>
    public static void AddFoodItem(Food? item, List<Object> foodList)
    {
        if (item is Meat)
        {
            foodList.Add(item);
        }
        else if (item is ProcessedFood)
        {
            foodList.Add(item as ProcessedFood);
        }
        else if (item is Vegetable)
        {
            foodList.Add(item as Vegetable);
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