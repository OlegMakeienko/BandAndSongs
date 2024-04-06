namespace BandsAndSongs;

public class Song
{
    public int Id { get; set; }
    public string Song_Name { get; set; }
    public int BandId { get; set; } // This should match with your Songs table in the database
    public virtual Band Band { get; set; } // This should be singular as it refers to a single Band
}