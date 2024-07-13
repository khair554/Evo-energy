using System.ComponentModel.DataAnnotations;

namespace webdev_consultationPhotovoltaique.Models.photovoltaiqueDB
{
    public class produit
    {
        public int EntrepriseId { get; set; }
        public int Id { get; set; }
        [Required(ErrorMessage = "Sélectionner le type est obligatoire.")]
     
        public string type {  get; set; }

        [Required(ErrorMessage = "Ce champ est obligatoire")]
        [StringLength(10000, MinimumLength =50 , ErrorMessage = "Le longueur de Mot de passe est compris entre 3 et 20")]
        public string Description { get; set; }


        [Required(ErrorMessage = "Ce champ est obligatoire")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Le longueur de Mot de passe est compris entre 3 et 20")]
        public string MotDePasse { get; set; }

        [Required(ErrorMessage = "Ce champ est obligatoire")]
     
        public Uri Logo {  get; set; }
        public virtual Entreprise Entreprise { get; set; } = null!;

    }
}
