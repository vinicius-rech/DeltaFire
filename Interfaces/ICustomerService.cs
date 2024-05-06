using Api.Deltafire.Models;

namespace Api.Deltafire.Interfaces;

public interface ICustomerService
{
    void AddCustomer(Customer customer);
    Customer GetCustomerById(int id);
    List<Customer> GetAllCustomers();
}
