using Midias.BTSCs.Dal;
using Midias.BTSCs.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midias.BTSCs.Services.Services
{
    public interface ICommandesService
    {
        /// <summary>
        /// Returns the matching commande
        /// </summary>
        /// <param name="id">Commande Id</param>
        /// <returns></returns>
        Commande GetCommande(int id);
        /// <summary>
        /// Returns a list with all the commande
        /// </summary>
        /// <returns></returns>
        List<CommandeDto> GetCommandes();
        /// <summary>
        /// Create a new template of commande
        /// </summary>
        /// <param name="commande">commande Dto</param>
        /// <returns></returns>
        void CreateNewCommande(CommandeDto commande);
        /// <summary>
        /// Updates the given commande with its new values
        /// </summary>
        /// <param name="commandeDto">New commande Dto</param>
        /// <returns></returns>
        CommandeDto UpdateCommande(CommandeDto commandeDto);
        /// <summary>
        /// Delete the commande template
        /// </summary>
        /// <param name="id">Commande to remove Id</param>
        /// <returns></returns>
        void DeleteCommande(int id);
    }

    public class CommandesService : ServiceBase, ICommandesService
    {
        public CommandesService()
        {
        }

        public Commande GetCommande(int id)
        {
            return Context.Commande.Where(p => p.Id == id).FirstOrDefault();
        }

        public List<CommandeDto> GetCommandes()
        {
            return Context.Commande.Select(commande => new CommandeDto()
            {
                Id = commande.Id,
                Libelle = commande.Libelle,
                Etat = commande.Etat,
                DateCreation = commande.DateCreation,
                DateValidation = commande.DateValidation,
                Client = new ClientDto()
                {
                    Id = commande.Client.Id,
                    Nom = commande.Client.Nom,
                    Prenom = commande.Client.Prenom
                },
                Livraison = commande.Livraisons.Select(l => new LivraisonDto()
                {
                    Id = l.Id,
                    DateLivraison = l.DateLivraison
                }).ToList()
            }).ToList();
        }

        public void CreateNewCommande(CommandeDto commande)
        {
            Context.Commande.Add(new Commande()
            {
                Id = commande.Id,
                Libelle = commande.Libelle,
                Etat = (int) commande.Etat,
                DateCreation = (DateTime) commande.DateCreation,
                DateValidation = (DateTime) commande.DateValidation,
                Client = Context.Client.Where(c => c.Id == commande.Client.Id).FirstOrDefault()
            });
            Context.SaveChanges();
        }

        public CommandeDto UpdateCommande(CommandeDto commandeDto)
        {
            var commande = Context.Commande.Where(p => p.Id == commandeDto.Id).FirstOrDefault(); ;

            commande.Libelle = commandeDto.Libelle;
            commande.Etat = (int) commandeDto.Etat;
            commande.DateCreation = (DateTime) commandeDto.DateCreation;
            commande.DateValidation = (DateTime) commandeDto.DateValidation;
            
            Context.SaveChanges();

            return commandeDto;
        }

        public void DeleteCommande(int id)
        {
            var commande = Context.Commande.Where(p => p.Id == id).FirstOrDefault();

            if (commande == null)
                return;

            Context.Commande.Remove(commande);

            Context.SaveChanges();
        }
    }

}
