using System.Collections.Generic;

namespace AdapterPattern
{
    public interface ICustomerList
    {
        List<Customer> GetCustomers();
        void AddCustomer(CustomerDto customer);
    }
}