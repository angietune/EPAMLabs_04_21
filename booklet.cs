using System;

namespace EPAMLabs_04_21
{
    public class booklet : photoAlbum
    {
        public int foldAmount { get; set; }
        public void PrintBooklet()
        {
            Console.WriteLine($"CoverType: {coverType} FoldAmount: {foldAmount}");
        }
    }
}