using Api.Deltafire.Interfaces;
using Api.Deltafire.Services;
using Api.Deltafire.Models;
using NUnit.Framework;

namespace Api.Deltafire.Tests;

[TestFixture]
public class SalesManagementServiceTests
{
    private ISalesManagementService _salesService;

    [SetUp]
    public void Setup()
    {
        _salesService = new SalesManagementService(new StockManagementService());
    }


    [Test]
    public void GetSalesByCustomer_ExistingCustomerId_ReturnsCorrectSales()
    {
        var customer = new Customer { Id = 1, Name = "John Doe" };

        var sale1 = new Sale
        {
            Id = 1,
            Customer = customer,
            Products = new List<Product>(),
            Date = DateTime.Now
        };

        var sale2 = new Sale
        {
            Id = 2,
            Customer = customer,
            Products = new List<Product>(),
            Date = DateTime.Now
        };

        _salesService.RegisterSale(sale1);
        _salesService.RegisterSale(sale2);

        var result = _salesService.GetSalesByCustomer(customer);

        Assert.That(result.Contains(sale1), Is.True);
        Assert.That(result.Contains(sale2), Is.True);
    }

    [Test]
    public void GetSalesByCustomer_NonExistingCustomerId_ReturnsEmptyList()
    {
        var customer = new Customer { Id = 999, Name = "Non-existing customer" };

        var result = _salesService.GetSalesByCustomer(customer);

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void GetDailySalesReport_SalesExistForDate_ReturnsCorrectSales()
    {
        var date = DateTime.Now;

        var sale1 = new Sale
        {
            Id = 1,
            Customer = new Customer { Id = 1, Name = "John Doe" },
            Products = new List<Product>(),
            Date = date
        };

        var sale2 = new Sale
        {
            Id = 2,
            Customer = new Customer { Id = 2, Name = "Jane Smith" },
            Products = new List<Product>(), Date = date
        };

        _salesService.RegisterSale(sale1);
        _salesService.RegisterSale(sale2);

        var result = _salesService.GetDailySalesReport(date);

        Assert.That(result.Contains(sale1), Is.True);
        Assert.That(result.Contains(sale2), Is.True);
    }

    [Test]
    public void GetDailySalesReport_NoSalesExistForDate_ReturnsEmptyList()
    {
        var date = DateTime.Now.AddDays(-1);

        var result = _salesService.GetDailySalesReport(date);

        Assert.That(result, Is.Empty);
    }
}
