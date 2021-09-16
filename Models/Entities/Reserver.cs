using System.ComponentModel.DataAnnotations;

namespace GestionLocationWebApp.Models.Entities
{
    
    public class Reserver
    {
        [Key]
        public int Id {get;set;}

        
        public Article Article {get;set;}

        
        public Reservation Reservation {get;set;}

        
        public int Nombre {get;set;}
        
        public Reserver() {
            
        }


        public Reserver(int id, Article article, int nombre, Reservation reservation)
        {
            Id = id;
            Article = article;
            Nombre = nombre;
            Reservation = reservation;
        }

        
        
        
    }
}