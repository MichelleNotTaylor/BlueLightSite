using BlueLightGames.Domain.Entities;
using System.Data.Entity;

namespace BlueLightGames.Domain
{
    public class BlueLightContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<HighScore> HighScores { get; set; }
    }
}
