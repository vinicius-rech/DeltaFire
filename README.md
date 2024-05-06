
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

## Instalação sdk
Para instalar o sdk, abra um powershell do windows com privilégios administrativos <br>
e então execute o seguinte comando
```shell
winget install Microsoft.DotNet.SDK.8
```

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

## Convenção de commits
* **feat:** *(Feature) - Nova funcionalidade ou recurso.*
* **fix:** *(Fix) - Correção de um erro ou problema.*
* **refactor:** *(Refatoração) - Melhoria ou reestruturação de código existente, sem adicionar nova funcionalidade ou resolver bugs.*
* **perf:** *(Performance) - Melhorias de desempenho no código.*
* **style:** *(Estilo) - Alterações relacionadas à formatação, estilo ou convenções de código, geralmente sem alterar seu comportamento.*
* **docs:** *(Documentação) - Atualização ou criação de documentação, como README, guias de uso ou comentários de código.*
* **build:** *(Construção) - Alterações relacionadas ao processo de construção (build) do projeto, como configurações de compilação.*
* **ops:** *(Operações) - Mudanças relacionadas à infraestrutura ou operações de sistema.*
* **chore:** *(Tarefa) - Tarefas de rotina, manutenção ou pequenas alterações que não se enquadram em outras categorias.*
* **wip:** *(Trabalho em Progresso) - Indicação de que o commit ainda está em desenvolvimento e não está pronto para ser finalizado.*
