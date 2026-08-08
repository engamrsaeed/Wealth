using Microsoft.EntityFrameworkCore;
using Wealth.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<WealthDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("WealthDatabase")));

var app = builder.Build();

app.UseHttpsRedirection();

app.Run();