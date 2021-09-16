using System.ComponentModel.DataAnnotations;

namespace GestionLocationWebApp.Models.Entities
{
    
    public class PenaliteLocation
    {
        [Key]
        public int Id {get;set;}

        
        public Article Article {get;set;}

        
        public Location Location {get;set;}
        
        public PenaliteLocation()
        {
        }


        public PenaliteLocation(int id, Article article, Location location)
        {
            Id = id;
            Article = article;
            Location = location;
        }
        
        

        
        
        
    }
}