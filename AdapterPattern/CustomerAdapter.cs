using System.Collections.Generic;

namespace AdapterPattern
{
    //concrete implimentation 
    public class CustomerAdapter : ICustomerList
    {
        private List<Customer> Customers = new List<Customer>();

        public List<Customer> GetCustomers()
        {
            return Customers;
        }

        public void AddCustomer(CustomerDto customer)
        {
            Customers.Add(new Customer
            {
                CustomerId = customer.Id,
                Name = customer.FirstName + ' ' + customer.LastName,
                Address = customer.Address,
                Zip = customer.PostalCode,
                State = customer.State,
                City = customer.City

            });
        }
        
    }
}