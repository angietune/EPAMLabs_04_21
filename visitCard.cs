using System;

namespace EPAMLabs_04_21
{
    public class visitCard : PrintingProduct
    {
        public int Amount { get; set; }
        public int unitPrice { get; set; }
        public void PrintVisitCard()
        {
            Console.WriteLine($"Name: {Name} amount: {Amount} unitPrice: {unitPrice}");
        }
    }
}