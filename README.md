
# API Deltafire

### Funcionalidades Principais
* Cadastro de clientes
* Registro de vendas
* Gerenciamento de estoque
* Relatórios de vendas diárias
* Tecnologias Utilizadas
* ASP.NET Core 3.1
* C# 8.0
* NUnit para testes unitários

# Endpoints
## Customer
* POST /api/customer: Adiciona um novo cliente.
* GET /api/customer/{id}: Retorna um cliente pelo seu ID.
* GET /api/customer: Retorna todos os clientes cadastrados.

## Sales
* POST /api/sales: Registra uma nova venda.
* GET /api/sales/{customerId}: Retorna as vendas de um cliente pelo seu ID.
* GET /api/sales/daily/{date}: Retorna o relatório de vendas diárias para uma determinada data.

## Stock
* POST /api/stock: Adiciona produtos ao estoque.
* DELETE /api/stock: Remove produtos do estoque.


