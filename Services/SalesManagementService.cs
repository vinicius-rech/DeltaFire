using Api.Deltafire.Interfaces;
using Api.Deltafire.Models;

namespace Api.Deltafire.Services;

public class SalesManagementService(IStockManagementService stockService)
    : ISalesManagementService
{
    private readonly IStockManagementService _stockService = stockService;
    private readonly List<Sale> _sales = new();

    public void RegisterSale(Sale sale)
    {
        _sales.Add(sale);
        UpdateStock(sale.Products);
    }

    public List<Sale> GetSalesByCustomer(Customer customer)
    {
        var customerSales = new List<Sale>();
        foreach (var sale in _sales)
        {
            if (sale.Customer.Id == customer.Id)
            {
                customerSales.Add(sale);
            }
        }
        return customerSales;
    }

    public List<Sale> GetDailySalesReport(DateTime date)
    {
        var dailySales = new List<Sale>();
        foreach (var sale in _sales)
        {
            if (sale.Date.Date == date.Date)
            {
                dailySales.Add(sale);
            }
        }
        return dailySales;
    }

    private void UpdateStock(List<Product> soldProducts)
    {
        foreach (var product in soldProducts)
        {
            _stockService.RemoveItemFromStock(product);
        }
    }
}
