using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionLocationWebApp.Models.Entities
{
    
    public class IncidentLocation
    {
        [Key]
        public int Id {get;set;}

        [ForeignKey("incident")]
        public int IdIncident {get;set;}
        
        public Incident Incident {get;set;}

        [ForeignKey("location")]
        public int IdLocation {get;set;}
        
        public Location Location {get;set;}
        
        public Achat Achat {get;set;}
        
        public string TypeIncident {get;set;}

        public int Nombre {get;set;}
        
        public IncidentLocation() {}

        public IncidentLocation(int id, int idIncident, Incident incident, int idLocation, Location location, Achat achat, string typeIncident, int nombre)
        {
            Id = id;
            IdIncident = idIncident;
            Incident = incident;
            IdLocation = idLocation;
            Location = location;
            Achat = achat;
            TypeIncident = typeIncident;
            Nombre = nombre;
        }
    }
}