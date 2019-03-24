using System;

namespace BlueLightGames.Web.Models
{
    public class UpdatePersonModel
    {
        public Guid PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Email { get; set; }
    }
}