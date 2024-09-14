using System;


namespace KnowledgeCheck
{
    public class Vegetable : Food
    {
        public string? FreshFrozenCanned { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Description: {Description}, Category: {Category}, Quantity: {Quantity}, FreshFrozenCanned: {FreshFrozenCanned}";
        }
    }
}