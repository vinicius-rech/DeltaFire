namespace Api.Deltafire.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public string Supplier { get; set; }
    public DateTime ExpiryDate { get; set; }

    public Product()
    {
        Name = string.Empty;
        Description = string.Empty;
        Supplier = string.Empty;
        ExpiryDate = DateTime.MinValue;
    }
}
