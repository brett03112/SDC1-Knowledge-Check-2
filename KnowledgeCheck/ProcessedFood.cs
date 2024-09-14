using System;


namespace KnowledgeCheck;
internal class ProcessedFood : Food
{
    public DateTime ExpirationDate { get; set; }

    public ProcessedFood()
    {
        string name = Name!;
        decimal price = Price!;
        string description = Description!;
        int quantity = Quantity!;
        DateTime expirationDate = ExpirationDate!;
    }   
}
