using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midias.BTSCs.Dal
{
    public class Mouvement
    {
        [Key]
        public int Id { get; set; }
        public int Quantite { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey("IdProduit")]
        public Produit Produit { get; set; }
    }
}
