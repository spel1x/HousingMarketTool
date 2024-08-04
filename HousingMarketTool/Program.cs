using HousingMarketTool.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IPropertyTransactionRepository, PropertyTransactionRepository>();

var app = builder.Build();

app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapDefaultControllerRoute();

app.Run();
