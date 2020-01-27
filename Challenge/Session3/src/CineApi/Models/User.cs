using System.Collections.Generic;
using CineApi.Models;

namespace CineApi.Models
{
    public class User
    {
        public int Id { get; set;}
        public string FirstName { get; set;}
        public string LastName {get; set;}
        public List<Movie> MovieId {get;set;} = new List<Movie>();
    }
}