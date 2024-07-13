using System.ComponentModel.DataAnnotations;

namespace webdev_consultationPhotovoltaique.Models.photovoltaiqueDB
{
    public class User
    {
        public int Id { get; set; }
       

        
           

            
            [Required(ErrorMessage = "Ce champ est obligatoire")]
            [StringLength(20, MinimumLength = 3, ErrorMessage = "Le longueur de nom est compris entre 3 et 20")]
            public string Nom { get; set; }
            [Required(ErrorMessage = "Ce champ est obligatoire")]
            [StringLength(20, MinimumLength = 3, ErrorMessage = "Le longueur de prénom est compris entre 3 et 20")]
            public string Prénom { get; set; }

            [Required(ErrorMessage = "Ce champ est obligatoire")]
            [StringLength(20, MinimumLength = 3, ErrorMessage = "Le longueur de l'adresse est compris entre 3 et 20")]


            public string Adresse { get; set; }
            [Required(ErrorMessage = "Ce champ est obligatoire")]
            [StringLength(8, MinimumLength = 8, ErrorMessage = "Le longueur du numéro de télephone est 8 numéro")]
            public string Télephone { get; set; }

            public string Gouvernourat { get; set; }
            
        
    




    [Required(ErrorMessage = "Ce champ est obligatoire")]
       
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Le longueur de Mot de passe est compris entre 3 et 20")]

        public string MotDePasse { get; set; }






    }
}
