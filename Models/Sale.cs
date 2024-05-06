namespace Api.Deltafire.Models;

public class Sale
{
    public int Id { get; set; }
    public Customer Customer { get; set; }
    public List<Product> Products { get; set; }
    public DateTime Date { get; set; }

    public Sale()
    {
        Customer = new Customer();
        Products = new List<Product>();
        Date = DateTime.Now;
    }
}

