using System.Collections.Generic;

namespace CineFlixApi.Models
{
    public class User
    {
        public int Id { get; set;}
        public string FirstName { get; set;}
        public string LastName {get; set;}
        public int MovieId {get; set;}
    }
}