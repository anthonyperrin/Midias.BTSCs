using System.Collections.Generic;

namespace Midias.BTSCs.Dto
{
    public class ClientDto
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public AdresseDto Adresse { get; set; }

        public virtual List<CommandeDto> Commande { get; set; }
    }
}