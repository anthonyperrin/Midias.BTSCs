using System.Collections.Generic;

namespace Midias.BTSCs.Dto
{
    public class AdresseDto
    {
        public int Id { get; set; }
        public string Rue1 { get; set; }
        public string Rue2 { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string Pays { get; set; }

        public virtual List<LivraisonDto> Livraison { get; set; }
    }
}