using System.ComponentModel.DataAnnotations;

namespace Midias.BTSCs.Dal
{
    public class Produit
    {
        [Key]
        public int Id { get; set; }

        public string Libelle { get; set; }

        public double PrixHT { get; set; }
    }
}
