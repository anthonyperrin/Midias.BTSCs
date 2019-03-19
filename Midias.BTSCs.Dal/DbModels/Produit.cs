using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Midias.BTSCs.Dal
{
    public class Produit
    {
        [Key]
        public int Id { get; set; }
        public string Libelle { get; set; }
        public double PrixHT { get; set; }
        public string Categorie { get; set; }
        public double Taxe { get; set; }
        public int Quantite { get; set; }

        public ICollection<Mouvement> Mouvements { get; set; }
    }
}
