using System.ComponentModel.DataAnnotations;

namespace KnowledgeCheck;

public abstract class Food
{
    [Required]
    protected static readonly List<Food> _foodList = new();
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public int Quantity { get; set; } = 0;


    
}

