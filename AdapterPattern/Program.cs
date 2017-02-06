using System;

namespace AdapterPattern
{
    class Program
    {

        private static ICustomerList CustomerList;

        static void Main(string[] args)
        {
            Console.WriteLine("Adapter pattern - Structural Pattern - ");
            Console.WriteLine("");
            Console.WriteLine("a good example is Dto's or third party objects");
            Console.WriteLine("Provide and interface the adapter will impliment");
            Console.WriteLine("Adapter class does the conversion and impliments the interface");

            CustomerList = new CustomerAdapter();
            
            CustomerDto customerDto = new CustomerDto
            {
                Id = "1",
                FirstName = "Allen",
                LastName = "Crane",
                Address = "123",
                City = "hometown",
                PostalCode = "321",
                State = "Tx"
            };

            CustomerList.AddCustomer(customerDto);

            Console.WriteLine(CustomerList.GetCustomers().Count);
            Console.WriteLine("you added a customer");
            System.Threading.Thread.Sleep(5000);

        }
    }
}
