using System.ComponentModel.DataAnnotations.Schema;

namespace GestionLocationWebApp.Models.Entities
{
    public class Louer
    {
        [ForeignKey("location")]
        public int IdLocation
        {
            get; set;
        }
        public Location Location
        {
            get; set;
        }

        [ForeignKey("article")]
        public int IdArticle
        {
            get; set;
        }
        public Article Article
        {
            get; set;
        }

        public int Nombre
        {
            get;set;
        }

        public Louer()
        {
        }

        public Louer(int idLocation, Location location, int idArticle, Article article, int nombre)
        {
            IdLocation = idLocation;
            Location = location;
            IdArticle = idArticle;
            Article = article;
            Nombre = nombre;
        }
    }
}