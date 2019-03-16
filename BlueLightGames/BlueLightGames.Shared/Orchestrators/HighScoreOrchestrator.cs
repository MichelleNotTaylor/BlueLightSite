using BlueLightGames.Domain;
using BlueLightGames.Shared.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BlueLightGames.Shared.Orchestrators
{
    public class HighScoreOrchestrator
    {
        private readonly BlueLightGamesContext _blueLightGamesContext;

        public HighScoreOrchestrator()
        {
            _blueLightGamesContext = new BlueLightGamesContext();
        }

        public List<HighScoreViewModel> GetAllHighScores()
        {
            var highscores = _blueLightGamesContext.HighScores.Select(h => new HighScoreViewModel
            {
                HighScoreId = h.HighScoreId,
                PersonId = h.PersonId,
                Score = h.Score,
                DateAttained = h.DateAttained
            }).ToList();

            return highscores;
        }
    }
}
