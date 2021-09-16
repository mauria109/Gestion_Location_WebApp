using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionLocationWebApp.Models.Entities
{
    [Table("location")]
    public class Location
    {
        [Key]
        public int Id { get; set; }

        
        public DateTime DateLoc { get; set; }

        public DateTime DateRet { get; set; }
        
        public Client Client
        {
            get;set;
        }

        public int Duree
        {
            get;set;
        }

        public bool Retourner
        {
            get;set;
        }

        public User User
        {
            get;set;
        }

        public Location(int id, DateTime dateLoc, DateTime dateRet, Client client, int duree, bool retourner, User user)
        {
            Id = id;
            DateLoc = dateLoc;
            DateRet = dateRet;
            Client = client;
            Duree = duree;
            Retourner = retourner;
            User = user;
        }


        public Location()
        {
        }

    }
}