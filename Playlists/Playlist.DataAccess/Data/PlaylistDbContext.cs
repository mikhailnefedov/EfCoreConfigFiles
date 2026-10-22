using Microsoft.EntityFrameworkCore;
using Playlist.DataAccess.Models;

namespace Playlist.DataAccess.Data;

public class PlaylistDbContext(DbContextOptions<PlaylistDbContext> options) : DbContext(options)
{
    public DbSet<Models.Playlist> Playlists => Set<Models.Playlist>();
    public DbSet<Track> Tracks => Set<Track>();
}
