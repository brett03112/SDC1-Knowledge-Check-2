using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnowledgeCheck
{
    public class Meat : Food
    {
        public string? FreshFrozenDeli { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Description: {Description}, Category: {Category}, Quantity: {Quantity}, FreshFrozenDeli: {FreshFrozenDeli}";
        }
    }
}