using Microsoft.EntityFrameworkCore;
using ProductsAPI.Database;
using ProductsAPI.Extensions;
using ProductsAPI.Validators;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.AddScoped<ProductPatchValidator>();
builder.Services.AddDbContext<ProductsDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Database"));
});

builder.AddSwagger();
builder.AddApiVersioning();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.AddVersioningToSwagger();
    app.RunMigrations();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();