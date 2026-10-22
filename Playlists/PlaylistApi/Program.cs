using Microsoft.EntityFrameworkCore;
using Playlist.DataAccess.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<PlaylistDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("Playlist")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/playlists", async (PlaylistDbContext db) =>
        await db.Playlists.AsNoTracking().Include(p => p.Tracks).ToListAsync())
    .WithName("GetPlaylists");

app.Run();
