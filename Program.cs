using Api.Deltafire.Interfaces;
using Api.Deltafire.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("appsettings.json");

builder.Services.AddScoped<ISalesManagementService, SalesManagementService>();
builder.Services.AddScoped<IStockManagementService, StockManagementService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
