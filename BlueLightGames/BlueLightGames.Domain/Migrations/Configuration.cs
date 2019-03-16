namespace BlueLightGames.Domain.Migrations
{
    using BlueLightGames.Domain.Entities;
    using System;
    using System.Data.Entity.Migrations;

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
            context.People.AddOrUpdate(new Person()
            {
                PersonId = Guid.Parse("c0dcc7d1-787d-4f27-8c4d-919f949a7486"),
                FirstName = "Michelle",
                LastName = "Taylor",
                DateCreated = DateTime.Now,
                Email = "mmtaylor3@dmacc.edu"
            });
            context.HighScores.AddOrUpdate(new HighScore()
            {
                HighScoreId = Guid.Parse("0d5ea68c-baa1-420f-866a-ed04d68e3f6f"),
                PersonId = Guid.Parse("c0dcc7d1-787d-4f27-8c4d-919f949a7486"),
                Score = 1000,
                DateAttained = DateTime.Now
            });
            context.HighScores.AddOrUpdate(new HighScore()
            {
                HighScoreId = Guid.Parse("2ea3eeb4-7937-41a2-b26e-56a94d216589"),
                PersonId = Guid.Parse("c0dcc7d1-787d-4f27-8c4d-919f949a7486"),
                Score = 2000,
                DateAttained = DateTime.Now
            });
            context.HighScores.AddOrUpdate(new HighScore()
            {
                HighScoreId = Guid.Parse("10aa172a-c592-4181-9fe1-f806e03ef414"),
                PersonId = Guid.Parse("c0dcc7d1-787d-4f27-8c4d-919f949a7486"),
                Score = 3000,
                DateAttained = DateTime.Now
            });
            context.HighScores.AddOrUpdate(new HighScore()
            {
                HighScoreId = Guid.Parse("0095dc6a-b2ab-47d7-be0a-1fe332a1b345"),
                PersonId = Guid.Parse("c0dcc7d1-787d-4f27-8c4d-919f949a7486"),
                Score = 4000,
                DateAttained = DateTime.Now
            });
            context.HighScores.AddOrUpdate(new HighScore()
            {
                HighScoreId = Guid.Parse("88b2eaae-154d-4270-9084-811b5da040c9"),
                PersonId = Guid.Parse("c0dcc7d1-787d-4f27-8c4d-919f949a7486"),
                Score = 5000,
                DateAttained = DateTime.Now
            });
        }
    }
}
