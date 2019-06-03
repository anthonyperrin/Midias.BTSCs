using System;
using System.Collections.Generic;

namespace Midias.BTSCs.Dto
{
    public class CommandeDto 
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public int? Etat { get; set; }
        public DateTime? DateValidation { get; set; }
        public DateTime? DateCreation { get; set; }

        public virtual ClientDto Client { get; set; }
        public virtual List<ProduitCommandeDto> ProduitCommandes { get; set; }
        public virtual List<LivraisonDto> Livraison { get; set; }
    }
}