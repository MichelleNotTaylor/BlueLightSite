namespace BlueLightGames.Domain.Migrations
{
    using BlueLightGames.Domain.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BlueLightGames.Domain.BlueLightGamesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BlueLightGames.Domain.BlueLightGamesContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.People.AddOrUpdate(new Person
            {
                PersonId = Guid.Parse("568f1750-d791-44b2-992a-1e3bf7fe61bf"),
                FirstName = "Michelle",
                LastName = "Taylor",
                DateCreated = System.DateTime.Now,
                Email = "mmtaylor3@dmacc.edu"
            });
            context.HighScores.AddOrUpdate(new HighScore
            {
                HighScoreId = Guid.Parse("b8da7af7-14da-4a21-bfa1-52cd0d2f4b8b"),
                PersonId = Guid.Parse("568f1750-d791-44b2-992a-1e3bf7fe61bf"),
                Score = 100f,
                DateAttained = System.DateTime.Now
            });
            context.HighScores.AddOrUpdate(new HighScore
            {
                HighScoreId = Guid.Parse("a0a7b50c-3b83-46ed-8cb8-70eeabcf450c"),
                PersonId = Guid.Parse("568f1750-d791-44b2-992a-1e3bf7fe61bf"),
                Score = 200f,
                DateAttained = System.DateTime.Now
            });
            context.HighScores.AddOrUpdate(new HighScore
            {
                HighScoreId = Guid.Parse("0156c7b2-58b0-44be-9c07-bb00a32ac1a8"),
                PersonId = Guid.Parse("568f1750-d791-44b2-992a-1e3bf7fe61bf"),
                Score = 300f,
                DateAttained = System.DateTime.Now
            });
            context.HighScores.AddOrUpdate(new HighScore
            {
                HighScoreId = Guid.Parse("55e6e289-5481-4f63-a778-72ad40b1c33a"),
                PersonId = Guid.Parse("568f1750-d791-44b2-992a-1e3bf7fe61bf"),
                Score = 400f,
                DateAttained = System.DateTime.Now
            });
            context.HighScores.AddOrUpdate(new HighScore
            {
                HighScoreId = Guid.Parse("f3531282-230f-408e-a0df-3b2ae3afc3c3"),
                PersonId = Guid.Parse("568f1750-d791-44b2-992a-1e3bf7fe61bf"),
                Score = 500f,
                DateAttained = System.DateTime.Now
            });
        }
    }
}
