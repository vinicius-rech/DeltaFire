
# API Deltafire

### Funcionalidades Principais
* NUnit para testes unitários
* Relatórios de vendas diárias
* Gerenciamento de estoque
* Tecnologias Utilizadas
* Cadastro de clientes
* Registro de vendas
* ASP.NET Core
* C# 8.0

<hr>

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

<hr>

## Executando o projeto
Para executar abra um terminal na pasta raiz do projeto e execute o seguinte comando:
```shell
dotnet run
```
## Documentação e Execução de endpoints com Swagger
A documentação pode ser acessada através do link:
```shell
localhost:PORT/swagger/index.html
```
Substitua PORT pela porta exibida no console.
