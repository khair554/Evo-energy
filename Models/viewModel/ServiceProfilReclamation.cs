using webdev_consultationPhotovoltaique.Models.photovoltaiqueDB;

namespace webdev_consultationPhotovoltaique.Models.viewModel
{
    public class ServiceProfilReclamation
    {
        public int ProfilId { get; set; }
        public int ServiceId { get; set; }


        public virtual ICollection<string> Reclamations { get; set; } = new List<string>();

    }
}
