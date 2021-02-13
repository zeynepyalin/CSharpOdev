using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //yeni nesne oluşturma yolu 1:
            Customer customer1 = new Customer { Id = 1, FirstName = "Zeynep Nida", LastName = "Yalın", City = "Eskişehir" };

            //yeni nesne oluşturma yolu 2:
            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Marvel";
            customer2.LastName = "Comics";
            customer2.City = "New York Shitty";

            //yeni nesne oluşturma yolu 3:
            Customer customer3 = new Customer(3, "Min Ho", "Lee", "Gimpo");
            //bu şekilde oluşturmak için yapıcı blok isminin yanında parametre olarak eklenmesi gerekir.
            //her iki türlü aynı anda çalışması için overloading yapılır (bir parametreli bir parametresiz yapıcı blok)

            Console.WriteLine(customer3.FirstName); // çalışabilmesi için contructor içinde eşleştirme yapıldı.
        }
    }
    class Customer
    {
        // new ile nesne oluşturulduğu zaman ilk ve bir defalık bu blok çalışır.
        // parametresi olmayan constructor default!!
        public Customer()
        {
            Console.WriteLine("yapıcı blok çalıştı");
        }
        // parametreli constructor için istenen değerin gelebilmesi için içeride eşleştirilmesi lazım.
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;

            Console.WriteLine("ikinci yapıcı blok çalıştı");
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
