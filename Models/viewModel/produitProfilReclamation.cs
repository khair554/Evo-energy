using webdev_consultationPhotovoltaique.Models.photovoltaiqueDB;

namespace webdev_consultationPhotovoltaique.Models.viewModel
{
    public class produitProfilReclamation
    {
        public int ProfilId { get; set; }
        public int produitId { get; set; }


        public virtual ICollection<string> Reclamations { get; set; } = new List<string>();

       
    }
}
