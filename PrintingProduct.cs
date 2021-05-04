using System;

namespace EPAMLabs_04_21
{
    public class PrintingProduct
    {
        public string Name { get; set; }
        
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            visitCard visitcard = new visitCard { Name = "visitka", Amount = 34, unitPrice = 2 };
            visitcard.PrintVisitCard();
            postCard postcard = new postCard { Name = "postcard", batchingType = "horizontal"};
            postcard.PrintPostCard();
            photoAlbum graduate = new photoAlbum { Name = "graduate", coverType = "hard"};
            graduate.PrintAlbum();
            booklet booklet = new booklet { Name = "booklet", coverType = "soft", foldAmount = 3};
            booklet.PrintAlbum();
            booklet.PrintBooklet();
        }
    }
}
