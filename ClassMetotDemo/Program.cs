using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri
            {
                Id = 1,
                FirstName = "Chan",
                LastName = "Bang",
                CreditCardNumber = 4587962
            };
            Musteri musteri2 = new Musteri
            {
                Id = 2,
                FirstName = "Felix",
                LastName = "Lee",
                CreditCardNumber = 8524631
            };

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.FirstName);
                Console.WriteLine(musteri.LastName);
                Console.WriteLine(musteri.CreditCardNumber);
                Console.WriteLine("------------------");
            }

            Console.WriteLine("----------Metotlar----------");

            // instance / örnek oluşturma
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(3,"Seungmin","Kim",5221515);
            musteriManager.Delete(musteri2);
            musteriManager.List(musteri1);

        }
    }
}
