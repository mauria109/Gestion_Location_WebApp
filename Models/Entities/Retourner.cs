using System.ComponentModel.DataAnnotations;

namespace GestionLocationWebApp.Models.Entities
{
    
    public class Retourner
    {
        [Key]
        public int Id {get;set;}

        
        public Retour Retour {get;set;}

        
        public Location Location {get;set;}

        
        public Article Article {get;set;}

        
        public int Nombre {get;set;}
        
        public Retourner()
        {
        }

        public Retourner(int id, Retour retour, Location location, Article article, int nombre)
        {
            Id = id;
            Retour = retour;
            Location = location;
            Article = article;
            Nombre = nombre;
        }

        
        
    }
}