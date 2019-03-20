using System;

namespace Midias.BTSCs.Dto
{
    public class MouvementDto
    {
        public int Id { get; set; }
        public int? Quantite { get; set; }
        public DateTime? DateCreation { get; set; }
        public ProduitDto Produit { get; set; }
    }
}
