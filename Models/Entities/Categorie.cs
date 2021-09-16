using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionLocationWebApp.Models.Entities
{
    [Table("categorie")]
    public class Categorie
    {
        [Key]
        public int Id {get;set;}

        
        public string Label {get;set;}

        
        public string Code {get;set;}
        public Categorie(int id, string label, string code)
        {
            Id = id;
            Label = label;
            Code = code;
        }
        
        public Categorie()
        {
        }
        
    }
}