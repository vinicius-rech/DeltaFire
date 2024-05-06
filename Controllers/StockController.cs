using Api.Deltafire.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Api.Deltafire.Models;

namespace Api.Deltafire.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StockController(IStockManagementService stockService)
    : ControllerBase
{
    [HttpPost]
    public IActionResult AddItemsToStock([FromBody] List<Product> products)
    {
        try
        {
            stockService.AddItemsToStock(products);
            return Ok("Produtos adicionados ao estoque com sucesso.");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao adicionar produtos ao estoque: {ex.Message}");
        }
    }

    [HttpDelete]
    public IActionResult RemoveItemsFromStock([FromBody] List<Product> products)
    {
        try
        {
            stockService.RemoveItemsFromStock(products);
            return Ok("Produtos removidos do estoque com sucesso.");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao remover produtos do estoque: {ex.Message}");
        }
    }

    [HttpGet("expiry")]
    public IActionResult CheckExpiry()
    {
        try
        {
            var expiredProducts = stockService.CheckExpiry();
            return Ok(expiredProducts);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao verificar produtos vencidos: {ex.Message}");
        }
    }
}
