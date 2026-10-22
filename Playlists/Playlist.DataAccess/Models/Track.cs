namespace Playlist.DataAccess.Models;

public class Track
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Artist { get; set; } = string.Empty;
    public int DurationSeconds { get; set; }
    public int PlaylistId { get; set; }
    public Playlist? Playlist { get; set; }
}
