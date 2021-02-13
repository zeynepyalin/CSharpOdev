using System;

namespace ReferansTipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Engin";

            person2 = person1;
            person1.FirstName = "Derin";
            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "1234567890";

            Employee employee = new Employee();
            employee.FirstName = "Veli";

            Person person3 = new Person();
            customer.FirstName = "Ahmet";
            //  Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            // Add ile employee, person, customer yani hepsi kullanılabilir.
            // aynı kodu farklı nesneler ile kullanabilmeyi sağlıyoruz kalıtım ile.
            personManager.Add(employee);
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    // base class : Person
    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }
    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
