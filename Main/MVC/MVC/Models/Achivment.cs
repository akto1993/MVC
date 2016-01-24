using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;


namespace MVC.Models
{
    public class Achivment
    {
        public int AchivmentID { get; set; }

        public int GameID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string AchivmentTitle { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string AchivmentDescription { get; set; }


        public virtual Game Game { get; set; }

    }

    /*public class AchivmentDBContext : DbContext
    {
        public DbSet<Achivment> Achivments { get; set; }
    }*/
}