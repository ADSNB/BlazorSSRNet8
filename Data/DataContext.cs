using BlazorSSR.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorSSR.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=videogame.sqlite");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<VideoGameModel>().HasData(
                new VideoGameModel { Id = 1, Title = "Cyberpunk 2027", Publisher = "CD Project", ReleaseYear = 2020 },
                new VideoGameModel { Id = 2, Title = "Elden Ring", Publisher = "FromSoftware", ReleaseYear = 2022 },
                new VideoGameModel { Id = 3, Title = "The Legend of Zelda: Ocarina of Time", Publisher = "Nintendo", ReleaseYear = 1998 }
                );
        }

        public DbSet<VideoGameModel> VideoGame { get; set; }
    }
}
