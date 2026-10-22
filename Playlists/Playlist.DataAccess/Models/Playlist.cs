namespace Playlist.DataAccess.Models;

public class Playlist
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<Track> Tracks { get; set; } = [];
}
