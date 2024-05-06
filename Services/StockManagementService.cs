using Api.Deltafire.Interfaces;
using Api.Deltafire.Models;

namespace Api.Deltafire.Services;

public class StockManagementService : IStockManagementService
{
    private readonly List<Product> _stock;

    public StockManagementService()
    {
        _stock = new List<Product>();
    }

    public void AddItemsToStock(List<Product> newProducts)
    {
        _stock.AddRange(newProducts);
    }

    public void RemoveItemsFromStock(List<Product> soldProducts)
    {
        foreach (var soldProduct in soldProducts)
        {
            var existingProduct = _stock.Find(p => p.Id == soldProduct.Id);
            if (existingProduct != null)
            {
                _stock.Remove(existingProduct);
            }
        }
    }

    public void RemoveItemFromStock(Product product)
    {
        var existingProduct = _stock.Find(p => p.Id == product.Id);
        if (existingProduct != null)
        {
            _stock.Remove(existingProduct);
        }
    }

    public List<Product> CheckExpiry()
    {
        var expiredProducts = new List<Product>();
        foreach (var product in _stock)
        {
            if (product.ExpiryDate <= DateTime.Today)
            {
                expiredProducts.Add(product);
            }
        }
        return expiredProducts;
    }
}
