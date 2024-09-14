using System;


namespace KnowledgeCheck
{
    public class ProcessedFood : Food
    {
        public DateTime ExpirationDate { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Description: {Description}, Category: {Category}, Quantity: {Quantity}, ExpirationDate: {ExpirationDate}";
        }
    }
}