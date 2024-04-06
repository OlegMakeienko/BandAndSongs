
using BandsAndSongs;
using Microsoft.EntityFrameworkCore;

using (var context = new MyDbContext())
{
    // // This will apply any pending migrations
    // context.Database.Migrate();
    // CREATE
    // Add the band
    var band = new Band()
    {
        Band_Name = "Scorpions",
        Year = 1965 // The year Scorpions was formed
    };
    context.Bands.Add(band);
    context.SaveChanges();

    // Add songs to the band
    var songs = new List<Song>
    {
        new Song { Song_Name = "Wind of Change", BandId = band.Id },
        new Song { Song_Name = "Still Loving You", BandId = band.Id },
        new Song { Song_Name = "Rock You Like A Hurricane", BandId = band.Id },
        new Song { Song_Name = "Big City Nights", BandId = band.Id },
        new Song { Song_Name = "No One Like You", BandId = band.Id }
    };
    context.Songs.AddRange(songs);
    context.SaveChanges();
    
    // // UPDATE
    // var bandToUpdate = context.Bands.First(b => b.Band_Name == "NRG");
    // bandToUpdate.Year = 1999;
    // bandToUpdate.Band_Name = "Scorpions";
    // context.SaveChanges();

    // // DELETE
    // var bandToDelete = context.Bands.First(b => b.Band_Name == "NRG");
    // context.Bands.Remove(bandToDelete);
    // context.SaveChanges();
    
    // READ Bands
    Console.WriteLine("Bands:");
    foreach (var b in context.Bands)
    {
        Console.WriteLine($"Band Name: {b.Band_Name}, Year: {b.Year}");
    }
    
    // READ Songs
    Console.WriteLine("\nSongs:");
    foreach (var s in context.Songs.Include(s => s.Band)) // Include the Band data
    {
        Console.WriteLine($"Song Name: {s.Song_Name}, Band Name: {s.Band.Band_Name}");
    }
}