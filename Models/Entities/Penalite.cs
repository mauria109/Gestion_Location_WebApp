using System;
using System.ComponentModel.DataAnnotations;

namespace GestionLocationWebApp.Models.Entities
{
    
    public class Penalite
    {
        [Key]
        public int Id {get;set;}

        
        public DateTime Date {get;set;}
        public Penalite()
        {
        }

        public Penalite(int id, DateTime date)
        {
            Id = id;
            Date = date;
        }

        
        
        
    }
}