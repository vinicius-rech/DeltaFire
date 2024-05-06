using Api.Deltafire.Models;

namespace Api.Deltafire.Interfaces;

public interface ISalesManagementService
{
    void RegisterSale(Sale sale);
    List<Sale> GetSalesByCustomer(Customer customer);
    List<Sale> GetDailySalesReport(DateTime date);
}
