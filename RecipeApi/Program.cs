using Microsoft.EntityFrameworkCore;
using RecipeApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<RecipeDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("Recipe")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/recipes", async (RecipeDbContext db) =>
        await db.Recipes.AsNoTracking().Include(r => r.Ingredients).ToListAsync())
    .WithName("GetRecipes");

app.Run();
