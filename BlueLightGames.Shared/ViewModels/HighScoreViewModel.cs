using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueLightGames.Shared.ViewModels
{
    public class HighScoreViewModel
    {
        public Guid HighScoreId { get; set; }
        public Guid PersonId { get; set; }
        public float Score { get; set; }
        public DateTime DateAttained { get; set; }
    }
}
