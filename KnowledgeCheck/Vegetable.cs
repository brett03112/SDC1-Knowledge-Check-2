using System;


namespace KnowledgeCheck;

internal class Vegetable : Food
{
    public string? FreshFrozenCanned { get; set; }

    public Vegetable()
    {
        string name = Name!;
        decimal price = Price!;
        string description = Description!;
        int quantity = Quantity!;
        string freshFrozenCanned = FreshFrozenCanned!;
    }    
}
