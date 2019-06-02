using System.Collections.Generic;

namespace Midias.BTSCs.Dto
{
    public class SalarieDto 
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public bool? Valide { get; set; }
        public string Permis { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }

        public virtual List<LivraisonDto> Livraison { get; set; }
    }
}