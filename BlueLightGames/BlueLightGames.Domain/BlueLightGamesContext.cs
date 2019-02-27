using BlueLightGames.Domain.Entities;
using System.Data.Entity;

namespace BlueLightGames.Domain
{
    public class BlueLightGamesContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<HighScore> HighScores { get; set; }
    }
}
