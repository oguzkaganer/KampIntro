namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Oğuz", LastName = "er", City = "istanbul" };

            Customer customer2 = new Customer(2, "Harun", "er", "tokat");

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Ahmet";
            customer3.LastName = "er";
            customer3.City = "Ankara";

            Console.WriteLine(customer2.FirstName);

            Console.ReadKey();
        }
    }

    class Customer
    {
        //default constructor
        public Customer()
        {

        }
        public Customer(int id,string firstName,string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}