using Api.Deltafire.Interfaces;
using Api.Deltafire.Models;

namespace Api.Deltafire.Services;

public class CustomerService : ICustomerService
{
    private readonly List<Customer> _customers = new List<Customer>();

    public void AddCustomer(Customer customer)
    {
        _customers.Add(customer);
    }

    public Customer GetCustomerById(int id)
    {
        return _customers.FirstOrDefault(customer => customer.Id == id);
    }

    public List<Customer> GetAllCustomers()
    {
        return _customers;
    }
}
