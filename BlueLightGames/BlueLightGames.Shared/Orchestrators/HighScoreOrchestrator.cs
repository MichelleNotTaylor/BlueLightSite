using BlueLightGames.Domain;
using BlueLightGames.Shared.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var highscores = _blueLightGamesContext.HighScores.Select(x => new HighScoreViewModel
            {
                HighScoreId = x.HighScoreId,
                PersonId = x.PersonId,
                Score = x.Score,
                DateAttained = x.DateAttained
            }).ToList();

            return highscores;
        }
    }
}
