using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models;

public class Song
{
    public int Id { get; set; }
    public string? Title { get; set; }
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    public string? MusicGenre { get; set; }
    public string? Singer { get; set; }
}