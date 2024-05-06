using Api.Deltafire.Models;

namespace Api.Deltafire.Interfaces;

public interface IStockManagementService
{
    void AddItemsToStock(List<Product> newProducts);
    void RemoveItemsFromStock(List<Product> soldProducts);
    void RemoveItemFromStock(Product product);
    List<Product> CheckExpiry();
}
