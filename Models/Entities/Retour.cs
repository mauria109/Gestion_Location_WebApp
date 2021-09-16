using System;
using System.ComponentModel.DataAnnotations;

namespace GestionLocationWebApp.Models.Entities
{
    
    public class Retour
    {
        [Key]
        public int Id {get;set;}

        public DateTime Date {get;set;}
        
        public Retour()
        {
        }

        public Retour(int id, DateTime date)
        {
            Id = id;
            Date = date;
        }

        
        
        
        
    }
}