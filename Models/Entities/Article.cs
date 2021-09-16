using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionLocationWebApp.Models.Entities
{
    [Table("article")]
    public class Article
    {
        [Key]
        public int Id {get;set;}

        
        public string Label {get;set;}

        
        public string Description {get;set;}

        
        public float Prix {get;set;}

        
        public int Quantity {get;set;}

        
        public int Categorie {get;set;}
        
        public Article()
        {
        }

        public Article(int id, string label, string description, float prix, int quantity, int categorie)
        {
            Id = id;
            Label = label;
            Description = description;
            Prix = prix;
            Quantity = quantity;
            Categorie = categorie;
        }

        
        
    }
}