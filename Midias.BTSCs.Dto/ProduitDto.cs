using System.Collections.Generic;

namespace Midias.BTSCs.Dto
{
    public class ProduitDto 
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public double? PrixHT { get; set; }
        public double? Taxe { get; set; }
        public int? Quantite { get; set; }

        public CategorieDto Categorie { get; set; }
        public List<MouvementDto> Mouvements { get; set; }
    }
}
