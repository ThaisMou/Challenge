using Microsoft.EntityFrameworkCore;
using CineApi.Models;

namespace CineApi.Persistence.Contexts
{
    public class CineContext : DbContext
    {
        public CineContext (DbContextOptions options) : base(options)
        { }

        public DbSet<User> users {get; set;}
        public DbSet<Movie> movies {get; set;}

         protected override void OnModelCreating (ModelBuilder builder){
            base.OnModelCreating (builder);

            builder.Entity<User> ().ToTable ("User");
            builder.Entity<User> ().HasKey (p => p.Id);
            builder.Entity<User> ().Property (p => p.Id).IsRequired ().valueGeneratedOnAdd ();
            builder.Entity<User> ().Property (p => p.FirstName).IsRequired ().HasMaxLength (30);
            builder.Entity<User> ().Property (p => p.LastName).IsRequired ().HasMaxLength (30);
            builder.Entity<User> ().HasForeingKey (p => p.MovieId).IsRequired();
            builder.Entity<User> ().HasData ( 
                new User { Id = 1, FirstName = "Adam", LastName = "Smith", MovieId = "1"},
                new user { Id = 2, FirstName = "Ravi", LastName = "Kumar", MovieId = "2"},
                new user { Id = 3, FirstName = "Susan", LastName = "Davidson", MovieId = "5"},
                new user { Id = 4, FirstName = "Jenny", LastName = "Adrianna", MovieId = "8"},
                new user { Id = 6, FirstName = "Lee", LastName = "Pong", MovieId = "10"}
            );

            builder.Entity<Movie> ().ToTable("Movie");
            builder.Entity<Movie> ().HasKey(p => p.Id);
            builder.Entity<Movie> ().Property(p => p.Id).IsRequired ().valueGeneratedOnAdd ();
            builder.Entity<Movie> ().Property(p => p.Title).IsRequired ().HasMaxLength (50);
            builder.Entity<Movie> ().Property(p => p.Category).IsRequired ().HasMaxLength (30);
            builder.Entity<Movie> ().HasData(
                new Movie { Id = 1, Title = "ASSASSIN'S CREED: EMBERS", Category = "Animation"},
                new Movie { Id = 1, Title = "Real Steel(2012)", Category = "Animation"},
                new Movie { Id = 1, Title = "Alvin and the Chipmunks", Category = "Animation"},
                new Movie { Id = 1, Title = "The Adventures of Tin Tin", Category = "Animation"},
                new Movie { Id = 1, Title = "Safe (2012)", Category = "Action"},
                new Movie { Id = 1, Title = "Safe House(2012)", Category = "Action"},
                new Movie { Id = 1, Title = "GIA", Category = "18+"},
                new Movie { Id = 1, Title = "Deadline 2009", Category = "18+"},
                new Movie { Id = 1, Title = "The Dirty Picture", Category = "18+"},
                new Movie { Id = 1, Title = "Marley and me", Category = "Romance"}            
            );                    
        }
    }
    
}