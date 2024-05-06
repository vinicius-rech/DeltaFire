using Api.Deltafire.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Api.Deltafire.Models;

namespace Api.Deltafire.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SalesController : ControllerBase
{
    private readonly ISalesManagementService _salesService;

    public SalesController(ISalesManagementService salesService)
    {
        _salesService = salesService;
    }

    [HttpPost]
    public IActionResult RegisterSale([FromBody] Sale sale)
    {
        try
        {
            _salesService.RegisterSale(sale);
            return Ok("Venda registrada com sucesso.");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao registrar venda: {ex.Message}");
        }
    }

    [HttpGet("{customerId}")]
    public IActionResult GetSalesByCustomer(int customerId)
    {
        var customer = new Customer { Id = customerId };
        var sales = _salesService.GetSalesByCustomer(customer);
        return Ok(sales);
    }

    [HttpGet("daily/{date}")]
    public IActionResult GetDailySalesReport(DateTime date)
    {
        try
        {
            var sales = _salesService.GetDailySalesReport(date);
            return Ok(sales);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao obter relatório de vendas diárias: {ex.Message}");
        }
    }
}
