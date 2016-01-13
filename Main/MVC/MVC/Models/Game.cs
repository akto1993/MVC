using System;
using System.Data.Entity;


namespace MVC.Models
{
    public class Game
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public int Done { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<Game> Movies { get; set; }
    }
}