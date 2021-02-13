using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Zepp";
            Console.WriteLine(customer1.FirstName);
        }
    }
    class Customer
    {
        public int Id { get; set; }
        private string _firstName;
        public string FirstName
        { 
            //extra işlem gerekirse kullanılır ama bir şey yazmasak da olur.
            get
            {
                return "Miss" + _firstName;
            }

            set
            {
                _firstName = value;
            }
        }
    }
}
