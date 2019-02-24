using System;

namespace BlueLightGames.Domain.Entities
{
    public class HighScore
    {
        public Guid HighScoreId { get; set; }
        public Guid PersonId { get; set; }
        public float Score { get; set; }
        public DateTime? DateAttained { get; set; }
    }
}
