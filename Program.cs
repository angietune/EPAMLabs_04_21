using System;

namespace EPAMLabs_04_21
{
    class Photobook {
        public string Format { get; set; }
        public int Pages { get; set; }

        public Photobook (int pages) {
            Pages = pages;
        }
        public Desciption (string format) {
            Format = format;
        }

        public void Print () {
            Console.WriteLine ("Format: " + Format, "Pages: " + Pages);
        }
    }
    class Order : Photobook {
        public int price;

        public Order (int price, int pages) : base (pages) {
            this.price = price * pages;
        }
    }
    class MainClass {
        public static void Main(string[] args)
        {
            Order book = new Order (10, 28);
            Console.WriteLine("Price: " + price);

            Photobook description = new Photobook ("20x20", 28);
            description.Print();
        }
    }
}
