namespace BlueLightGames.Domain.Migrations
{
    using BlueLightGames.Domain.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BlueLightGames.Domain.BlueLightContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BlueLightGames.Domain.BlueLightContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.People.AddOrUpdate(new Person
            {
                PersonId = Guid.Parse("4d440058-24ac-470c-9bfa-af126b452248"),
                FirstName = "Michelle",
                LastName = "Taylor",
                DateCreated = DateTime.Now,
                Email = "mmtaylor3@dmacc.edu"
            });
            context.HighScores.AddOrUpdate(new HighScore
            {
                HighScoreId = Guid.Parse("112d9f33-6ae1-4578-818f-7f5996c669eb"),
                PersonId = Guid.Parse("4d440058-24ac-470c-9bfa-af126b452248"),
                DateAttained = DateTime.Now,
                Score = 0f
            });
            context.HighScores.AddOrUpdate(new HighScore
            {
                HighScoreId = Guid.Parse("90a55270-bb18-41cd-a7f2-20badb2628f6"),
                PersonId = Guid.Parse("4d440058-24ac-470c-9bfa-af126b452248"),
                DateAttained = DateTime.Now,
                Score = 0f
            });
            context.HighScores.AddOrUpdate(new HighScore
            {
                HighScoreId = Guid.Parse("c0dd8581-0def-422c-8c2e-f86cec78b467"),
                PersonId = Guid.Parse("4d440058-24ac-470c-9bfa-af126b452248"),
                DateAttained = DateTime.Now,
                Score = 0f
            });
            context.HighScores.AddOrUpdate(new HighScore
            {
                HighScoreId = Guid.Parse("605c3801-033e-4a86-8194-c84b19a5b085"),
                PersonId = Guid.Parse("4d440058-24ac-470c-9bfa-af126b452248"),
                DateAttained = DateTime.Now,
                Score = 0f
            });
            context.HighScores.AddOrUpdate(new HighScore
            {
                HighScoreId = Guid.Parse("825ed095-cead-43c0-9c93-54dcad4a91c8"),
                PersonId = Guid.Parse("4d440058-24ac-470c-9bfa-af126b452248"),
                DateAttained = DateTime.Now,
                Score = 0f
            });
        }
    }
}
