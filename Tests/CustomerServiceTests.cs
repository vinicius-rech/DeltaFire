using Api.Deltafire.Interfaces;
using Api.Deltafire.Services;
using Api.Deltafire.Models;
using NUnit.Framework;

namespace Api.Deltafire.Tests;

[TestFixture]
public class CustomerServiceTests
{
    private ICustomerService _customerService;

    [SetUp]
    public void Setup()
    {
        _customerService = new CustomerService();
    }

    [Test]
    public void AddCustomer_ValidCustomer_SuccessfullyAdded()
    {
        var customer = new Customer
        {
            Id = 1,
            Name = "Maria Carmo",
            Address = "Rua de exemplo",
            Phone = "5498173817346"
        };

        _customerService.AddCustomer(customer);

        Assert.That(_customerService.GetAllCustomers(), Has.Member(customer));
    }

    [Test]
    public void GetCustomerById_ExistingCustomerId_ReturnsCorrectCustomer()
    {
        var customer = new Customer
        {
            Id = 1,
            Name = "Carlos Santos",
            Address = "Caxias do Sul",
            Phone = "54981736132"
        };

        _customerService.AddCustomer(customer);

        var result = _customerService.GetCustomerById(1);

        Assert.Equals(customer, result);
    }

    [Test]
    public void GetCustomerById_NonExistingCustomerId_ReturnsNull()
    {
        var result = _customerService.GetCustomerById(999);

        Assert.That(result, Is.True);
    }

    [Test]
    public void GetAllCustomers_NoCustomers_ReturnsEmptyList()
    {
        var result = _customerService.GetAllCustomers();

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void GetAllCustomers_MultipleCustomers_ReturnsAllCustomers()
    {
        var customer1 = new Customer
        {
            Id = 1,
            Name = "Marcio Jones",
            Address = "Carlos Barbosa",
            Phone = "540182311783"
        };

        var customer2 = new Customer
        {
            Id = 2,
            Name = "Jonathan Carlos",
            Address = "Farroupilha",
            Phone = "549128326734"
        };

        _customerService.AddCustomer(customer1);
        _customerService.AddCustomer(customer2);

        var result = _customerService.GetAllCustomers();

        Assert.That(result.Count, Is.EqualTo(2));
        Assert.That(result, Has.Member(customer1));
        Assert.That(result, Has.Member(customer2));
    }
}
