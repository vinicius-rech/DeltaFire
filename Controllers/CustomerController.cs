using Microsoft.AspNetCore.Mvc;
using Api.Deltafire.Interfaces;
using Api.Deltafire.Models;

namespace Api.Deltafire.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController(ICustomerService customerService)
    : ControllerBase
{
    [HttpPost]
    public IActionResult AddCustomer([FromBody] Customer customer)
    {
        try
        {
            customerService.AddCustomer(customer);
            return Ok("Cliente adicionado com sucesso.");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao adicionar cliente: {ex.Message}");
        }
    }

    [HttpGet("{id}")]
    public IActionResult GetCustomerById(int id)
    {
        var customer = customerService.GetCustomerById(id);

        if (customer == null)
        {
            return NotFound("Cliente não encontrado.");
        }

        return Ok(customer);
    }

    [HttpGet]
    public IActionResult GetAllCustomers()
    {
        try
        {
            var customers = customerService.GetAllCustomers();
            return Ok(customers);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro ao obter clientes: {ex.Message}");
        }
    }
}
