using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionLocationWebApp.Models.Entities
{
    [Table("client")]
    
    public class Client
    {
        [Key]
        public int Id {get;set;}

        
        public string Nom {get;set;}

        
        public string Prenom {get;set;}

        
        public int Tel {get;set;}

        
        public string Ci {get;set;}
        
        public Client()
        {
        }

        public Client(int id, string nom, string prenom, int tel, string ci)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Tel = tel;
            Ci = ci;
        }
    }
}