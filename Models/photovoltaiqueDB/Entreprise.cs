using System.ComponentModel.DataAnnotations;

namespace webdev_consultationPhotovoltaique.Models.photovoltaiqueDB
{
    public class Entreprise
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ce champ est obligatoire")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Le longueur de nom est compris entre 3 et 20")]
        public string Nom { get; set; }

        

        [Required(ErrorMessage = "Ce champ est obligatoire")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Ce champ est obligatoire")]
        [Url(ErrorMessage = "C'est n'est pas un URL valide !")]
        [Display(Name = "Page Facebook")]
        public string Facebook { get; set; } = null!;
       
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        [Url(ErrorMessage = "C'est n'est pas un URL valide !")]
        [Display(Name = "Page Instagram")]
        public string Instagram { get; set; } = null!;
      
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        [Url(ErrorMessage = "C'est n'est pas un URL valide !")]
        [Display(Name = "Page officiel")]
        public string officiel { get; set; } = null!;


        [Required(ErrorMessage = "Ce champ est obligatoire")]
        [Display(Name = "Motdepaase")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Le longueur de Mot de passe est compris entre 3 et 20")]
        public string MotDePasse
        {
            get; set;
        }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Le longueur d'adresse est compris entre 3 et 20")]
        public string Adresse { get; set; }

        




        public string Gouvernourat { get; set; }
        [Display(Name = "Téléphone 1")]

        [Required(ErrorMessage = "Ce champ est obligatoire")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "Le longueur du numéro de télephone est 8 numéro")]
        public string tel { get; set; }
        [Display(Name = "Téléhpone 2")]

        [StringLength(8, MinimumLength = 8, ErrorMessage = "Le longueur du numéro de télephone est 8 numéro")]
        public string tel2 { get; set; }

        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string ChampMatricule {  get; set; }


        public virtual ICollection<Service> Services { get; } = new List<Service>();
        public virtual ICollection<produit> produits { get; } = new List<produit>();
        
    }
}
