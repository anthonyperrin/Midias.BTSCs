using Midias.BTSCs.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midias.BTSCs.Dto
{
    public class ProduitCommandeDto
    {
        public int Quantite { get; set; }

        public virtual CommandeDto Commande { get; set; }
        public virtual ProduitDto Produit { get; set; }
    }
}
