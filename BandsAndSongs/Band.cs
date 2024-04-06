namespace BandsAndSongs;

public class Band
{
    public int Id { get; set; }
    public string Band_Name { get; set; }
    public int Year { get; set; }
    public virtual ICollection<Song> Songs { get; set; }
}