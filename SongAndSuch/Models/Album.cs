namespace SongAndSuch.Models;

public class Album
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public int ArtistId { get; set; }
}