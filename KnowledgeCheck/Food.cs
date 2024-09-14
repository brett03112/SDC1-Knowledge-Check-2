using System.ComponentModel.DataAnnotations;

namespace KnowledgeCheck;

public class Food
{
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public int Quantity { get; set; } = 0;
    
}

