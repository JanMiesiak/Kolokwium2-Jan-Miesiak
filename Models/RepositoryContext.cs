using Microsoft.EntityFrameworkCore;
using Kolokwium2.Models;

namespace Kolokwium2.Models
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Musician> Musician { get; set; }
        // public DbSet<Album> Album { get; set; }
        // public DbSet<WyrobCukierniczy> WyrobCukierniczy { get; set; }
        // public DbSet<ZamowienieWyrobCukierniczy> ZamowienieWyrobCukierniczy { get; set; }
        // public DbSet<Zamowienie> Zamowienie { get; set; }
        public RepositoryContext(DbContextOptions options) : base(options)
         {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Musician>(e =>
            {
                e.ToTable("Musician");
                e.HasKey(e => e.IdMusician);

                e.Property(e => e.FirstName).HasMaxLength(30).IsRequired();
                e.Property(e => e.LastName).HasMaxLength(50).IsRequired();
                e.Property(e => e.NickName).HasMaxLength(20);

                e.HasData(
                    new Musician
                    {
                        IdMusician = 1,
                        FirstName = "Jan",
                        LastName = "Nowak",
                        NickName ="Nwk"
                    }
                );
            });

            modelBuilder.Entity<Track>(e =>
            {
                e.ToTable("Track");
                e.HasKey(e => e.IdTrack);

                e.Property(e => e.IdTrack).IsRequired();
                e.Property(e => e.TrackName).HasMaxLength(20).IsRequired();
                e.Property(e => e.Duration).IsRequired();
                //e.Property(e => e.IdMusicAlbum).IsRequired();

                e.HasData(
                    new Track
                    {
                        IdTrack = 1,
                        TrackName = "FirstTrack",
                        Duration = 3.45,
                        IdMusicAlbum = 1
                    }
                );
            });


        }
        
    }
}