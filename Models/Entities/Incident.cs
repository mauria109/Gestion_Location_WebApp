using System;
using System.ComponentModel.DataAnnotations;

namespace GestionLocationWebApp.Models.Entities
{
    
    public class Incident
    {
        [Key]
        public int Id {get;set;}

        
        public DateTime Date {get;set;}
        public Incident()
        {
        }

        public Incident(int id, DateTime date)
        {
            Id = id;
            Date = date;
        }

        
        
    }
}