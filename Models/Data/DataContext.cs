using GestionLocationWebApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace GestionLocationWebApp.Models.Data
{
    public class DataContext : DbContext
    {
        //achat
        public DbSet<Achat> Achats { get; set; }
        //article
        public DbSet<Article> Articles { get; set; }
        //categorie
        public DbSet<Categorie> Categories { get; set; }
        //client
        public DbSet<Client> Clients { get; set; }
        //incident
        public DbSet<Incident> Incidents { get; set; }
        //incident location
        public DbSet<IncidentLocation> IncidentLocations { get; set; }
        //penalité
        public DbSet<Penalite> Penalites { get; set; }
        //penalite location
        public DbSet<PenaliteLocation> PenaliteLocations { get; set; }
        //reservation
        public DbSet<Reservation> Reservations { get; set; }
        //reserver
        public DbSet<Reserver> Reservers { get; set; }
        //retour
        public DbSet<Retour> Retours { get; set; }
        //retourner
        public DbSet<Retourner> Retourners { get; set; }
        //location
        public DbSet<Location> Locations { get; set; }
        //user
        public DbSet<User> Users { get; set; }


        private const string MySqlConnectionStr = @"server=127.0.0.1;port=3306;user=root;password=;database=location_web_app";


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(MySqlConnectionStr, ServerVersion.AutoDetect(MySqlConnectionStr))
                    .UseLoggerFactory(LoggerFactory.Create(b => b.AddConsole()
                        .AddFilter(level => level >= LogLevel.Information))).EnableSensitiveDataLogging().EnableDetailedErrors();
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Achat>().ToTable("achat");
            modelBuilder.Entity<Article>().ToTable("article");
            modelBuilder.Entity<Categorie>().ToTable("categorie");
            modelBuilder.Entity<Client>().ToTable("client");
            modelBuilder.Entity<Incident>().ToTable("incident");
            modelBuilder.Entity<IncidentLocation>().ToTable("incident_location").HasKey(il => new {il.IdIncident, il.IdLocation});
            modelBuilder.Entity<Penalite>().ToTable("penalite");
            modelBuilder.Entity<PenaliteLocation>().ToTable("penalite_location");
            modelBuilder.Entity<Reservation>().ToTable("reservation");
            modelBuilder.Entity<Reserver>().ToTable("reserver");
            modelBuilder.Entity<Retour>().ToTable("retour");
            modelBuilder.Entity<Retourner>().ToTable("retourner");
            modelBuilder.Entity<Location>().ToTable("location");
            modelBuilder.Entity<Louer>().ToTable("louer").HasKey(l => new {l.IdArticle, l.IdLocation});
            modelBuilder.Entity<User>().ToTable("user");
        }
    }
}