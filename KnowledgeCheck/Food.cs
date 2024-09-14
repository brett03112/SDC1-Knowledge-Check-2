namespace KnowledgeCheck;

public class Food
{
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public string? Description { get; set; }
    public string? Category { get; set; }
    public int Quantity { get; set; } = 0;


    public override string ToString()
    {
        return $"Name: {Name}, Price: {Price}, Description: {Description}, Category: {Category}, Quantity: {Quantity}";
    }
}

