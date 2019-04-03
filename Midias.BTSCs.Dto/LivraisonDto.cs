using System;

namespace Midias.BTSCs.Dto
{
    public class LivraisonDto
    {
        public int Id { get; set; }
        public DateTime? DateLivraison { get; set; }

        public virtual AdresseDto Adresse { get; set; }
        public virtual CommandeDto Commande { get; set; }
        public virtual SalarieDto Salarie { get; set; }
        public virtual VehiculeDto Vehicule { get; set; }
    }
}