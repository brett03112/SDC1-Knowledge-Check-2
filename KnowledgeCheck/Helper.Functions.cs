using System;
using System.Text.Json;


namespace KnowledgeCheck;


internal class HelperFunctions 
{
    private List<Food>? _foodList;

    private Dictionary<string, Meat>? _meat;

    private Dictionary<string, ProcessedFood>? _processedFood;

    private Dictionary<string, Vegetable>? _vegetable;

    
    
    /// <summary>
    /// This class is a helper class that provides a couple of important functions.
    /// The constructor initializes a list of food items, a dictionary of meats, a dictionary of processed foods, and a dictionary of vegetables.
    /// The foods are added to the respective dictionaries.
    /// The second function, NewOptions, is a static function that returns a JsonSerializerOptions object with the following settings:
    ///     - IncludeFields is set to true, which includes all fields when serializing.
    ///     - PropertyNameCaseInsensitive is set to true, which makes the property names case insensitive.
    ///     - WriteIndented is set to true, which makes the output of the serializer indented.
    ///     - PropertyNamingPolicy is set to JsonNamingPolicy.CamelCase, which makes the property names camel case.
    /// </summary>
    public HelperFunctions()
    {
        _foodList = new List<Food>();
        {
            new Meat
            {
                Name = " Ground Beef",
                Price = 5.99m,
                Description = "Ground Beef Chuck 80/20",
                Quantity = 15,
                FreshFrozenDeli = "Fresh",
            };

            new Vegetable
            {
                Name = "Whole Frozen Broccoli",
                Price = 1.99m,
                Description = "Broccoli",
                Quantity = 10,
                FreshFrozenCanned = "Frozen",
            };

            new ProcessedFood
            {
                Name = "Jiffy Peanut Butter",
                Price = 2.99m,
                Description = "Peanut Butter",
                Quantity = 5,
                ExpirationDate = DateTime.Now.AddDays(7),
            };

        };

        _meat = new Dictionary<string, Meat>();
        _processedFood = new Dictionary<string, ProcessedFood>();
        _vegetable = new Dictionary<string, Vegetable>();

        foreach (var item in _foodList)
        {
            if (item is Meat)
            {
                _meat.Add(item.Name!, (Meat)item);
            }
            else if (item is ProcessedFood)
            {
                _processedFood.Add(item.Name!, (ProcessedFood)item);
            }
            else if (item is Vegetable)
            {
                _vegetable.Add(item.Name!, (Vegetable)item);
            }
        }
    }
    public void AddFoodItem(Food _item)
    {
        if (_item is Meat)
        {
            _meat!.Add(_item.Name!, (Meat)_item);
        }
        else if (_item is ProcessedFood)
        {
            _processedFood!.Add(_item.Name!, (ProcessedFood)_item);
        }
            
        else if (_item is Vegetable)
        {
            _vegetable!.Add(_item.Name!, (Vegetable)_item);
        }

        else
        {
            _foodList!.Add(_item);
        }
    }

    /// <summary>
    /// Returns the full list of food items.
    /// </summary>
    public List<Food> GetFoodList()
    {
        return _foodList!;
    }
    
    
    /// <summary>
    /// Returns a food item of type T with the given name. If no item is found, returns null.
    /// </summary>
    /// <typeparam name="T">The type of food item to retrieve.</typeparam>
    /// <param name="name">The name of the food item to retrieve.</param>
    /// <returns>The food item of type T with the given name, or null if not found.</returns>
    public T GetFoodByName<T>(string name) where T : Food
    {
        try
        {
            return (T)_foodList!.Find(x => x.Name == name)!;
        }
        catch (NullReferenceException e)
        {
            Console.WriteLine(e);
            return null!;
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
            PropertyNameCaseInsensitive = true,
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        };

        return options;
    }   
}