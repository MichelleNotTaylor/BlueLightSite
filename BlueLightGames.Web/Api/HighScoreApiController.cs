using BlueLightGames.Shared.Orchestrators;
using BlueLightGames.Shared.ViewModels;
using System.Collections.Generic;
using System.Web.Http;

namespace BlueLightGames.Web.Api
{
    [Route("api/v1/highscores")]
    public class HighScoreApiController : ApiController
    {
        private readonly HighScoreOrchestrator _highScoreOrchestrator;

        public HighScoreApiController()
        {
            _highScoreOrchestrator = new HighScoreOrchestrator();
        }

        [HttpGet]
        public List<HighScoreViewModel> GetAllHighScores()
        {
            var highscores = _highScoreOrchestrator.GetAllHighScores();

            return highscores;
        }
        
    }
}
