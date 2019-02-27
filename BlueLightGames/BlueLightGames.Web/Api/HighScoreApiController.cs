using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BlueLightGames.Shared.Orchestrators;
using BlueLightGames.Shared.ViewModels;

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
        public List<HighScoreViewModel> GetAllPeople()
        {
            var highscores = _highScoreOrchestrator.GetAllHighScores();

            return highscores;
        }
    }
}
