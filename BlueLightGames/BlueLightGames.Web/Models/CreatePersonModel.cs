using System;

namespace BlueLightGames.Web.Models
{
    public class CreatePersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateCreated { get; set; }
    }
}