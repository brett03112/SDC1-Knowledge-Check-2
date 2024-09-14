using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnowledgeCheck;

internal class Meat : Food
{
    public string? FreshFrozenDeli { get; set; }

    public Meat()
    {
        string name = Name!;
        decimal price = Price!;
        string description = Description!;
        int quantity = Quantity!;
        string freshFrozenDeli = FreshFrozenDeli!;
    }    
}
