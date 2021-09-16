using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionLocationWebApp.Models.Entities
{
    [Table("achat")]
    public class Achat
    {
        [Key]
        public int Id {get;set;}

        
        public DateTime Date {get;set;}
        
        public Achat()
        {
        }


        public Achat(int id, DateTime date)
        {
            Id = id;
            Date = date;
        }
    }
}