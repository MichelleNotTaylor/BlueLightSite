using BlueLightGames.Domain;
using BlueLightGames.Shared.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace BlueLightGames.Shared.Orchestrators
{
    public class HighScoreOrchestrator
    {
        private readonly BlueLightContext _blueLightContext;

        public HighScoreOrchestrator()
        {
            _blueLightContext = new BlueLightContext();
        }

        public List<HighScoreViewModel> GetAllHighScores()
        {
            var highScores = _blueLightContext.HighScores.Select(x => new HighScoreViewModel
            {
                PersonId = x.PersonId,
                HighScoreId = x.HighScoreId,
                Score = x.Score
            }).ToList();

            return highScores;
        }

    }
}
