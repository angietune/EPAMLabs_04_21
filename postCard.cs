using System;

namespace EPAMLabs_04_21
{
    public class postCard : PrintingProduct
    {
        public string batchingType { get; set; }
        public void PrintPostCard()
        {
            Console.WriteLine($"Name: {Name} batchingType: {batchingType}");
        }
    }
}