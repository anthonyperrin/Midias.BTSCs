using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midias.BTSCs.Dto
{
    public class VehiculeDto
    {
        public int Id { get; set; }
        public string CarteGrise { get; set; }
        public string Immatriculation { get; set; }
        public string Modele { get; set; }
        public string Marque { get; set; }

        public virtual List<LivraisonDto> Livraison { get; set; }
    }
}
