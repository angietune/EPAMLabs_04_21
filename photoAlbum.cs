using System;

namespace EPAMLabs_04_21
{
    public class photoAlbum : PrintingProduct
    {
        public string coverType { get; set; }
        public void PrintAlbum()
        {
            Console.WriteLine($"Name: {Name} coverType: {coverType}");
        }
    }
}