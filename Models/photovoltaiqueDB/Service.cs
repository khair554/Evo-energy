using System.ComponentModel.DataAnnotations;

namespace webdev_consultationPhotovoltaique.Models.photovoltaiqueDB
{
    public class Service
    {
        public int EntrepriseId { get; set; }
        public int Id { get; set; }

        [Required(ErrorMessage = "Sélectionner le type est obligatoire.")]

        public string type {  get; set; }
        public string AutreService { get; set; } = null!;
        public virtual Entreprise Entreprise { get; set; } = null!;
    }
}
