using System;
using System.ComponentModel.DataAnnotations;

namespace GestionLocationWebApp.Models.Entities
{
    
    public class Reservation
    {
        [Key]
        public int Id {get;set;}

        
        public DateTime Date {get;set;}

        
        public Client Client {get;set;}
        
        public Reservation()
        {
        }

        public Reservation(int id, DateTime date, Client client)
        {
            Id = id;
            Date = date;
            Client = client;
        }

    }
}