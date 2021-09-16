using System.ComponentModel.DataAnnotations;

namespace GestionLocationWebApp.Models.Entities
{
    
    public class User
    {
        [Key]
        public int IdUsr {get;set;}

        
        public string NomUsr {get;set;}

        
        public string PrenomUsr {get;set;}

        
        public string LoginUsr {get;set;}

        
        public string PwdUsr {get;set;}

        
        public string DroitUsr {get;set;}
        
        public User()
        {
        }

        public User(int idUsr, string nomUsr, string prenomUsr, string loginUsr, string pwdUsr, string droitUsr) {
            IdUsr = idUsr;
            NomUsr = nomUsr;
            PrenomUsr = prenomUsr;
            LoginUsr = loginUsr;
            PwdUsr = pwdUsr;
            DroitUsr = droitUsr;
        }
    }
}