using ControleFinanceiro.API.Models;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.EntityFrameworkCore;
using Swashbuckle;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ControleContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Controle"))
);

builder.Services.AddScoped<ControleContext, ControleContext>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(x =>
{
    x.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Controle Financeiro API", Version = "v1" });
});

var app = builder.Build();

// if (!app.Environment.IsDevelopment())
// {
//     app.UseExceptionHandler("/Error");
//     app.UseHsts();
// }

//app.UseHttpsRedirection();
//app.UseAuthorization();

app.MapControllers();

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("../swagger/v1/swagger.json", "Controle Financeiro API");
});

var option = new RewriteOptions();
option.AddRedirect("^$", "/swagger");
app.UseRewriter(option);

app.Run();