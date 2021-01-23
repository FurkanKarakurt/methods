using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product meyve1 = new Product ();
            meyve1.Adi = "elma";
            meyve1.Fiyati = 30;
            meyve1.Aciklama = "kırmızı elma kg si";

            Product sebze = new Product();
            sebze.Adi = "marul";
            sebze.Fiyati = 10;
            sebze.Aciklama = "kıvırcık marul";

            Product[] products = new Product[] { meyve1, sebze };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine("---------------------");


            }

            Console.WriteLine("--------methods--------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(sebze);
            sepetManager.Ekle(meyve1);









        }
    }
}
