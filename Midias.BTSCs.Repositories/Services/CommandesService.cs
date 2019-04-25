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
        CommandeDto GetCommande(int id);
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

    class CommandesService : ServiceBase, ICommandesService
    {
        public CommandesService()
        {
        }

        public CommandeDto GetCommande(int id)
        {
            var commande = Context.Commande.Where(p => p.Id == id).FirstOrDefault();
            return new CommandeDto()
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
                Livraison = commande.Livraison.Select(l => new LivraisonDto()
                {
                    Id = l.Id,
                    DateLivraison = l.DateLivraison
                }).ToList()
            };
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
                Livraison = commande.Livraison.Select(l => new LivraisonDto()
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
                Etat = commande.Etat,
                DateCreation = commande.DateCreation,
                DateValidation = commande.DateValidation,
                Client = new Client()
                {
                    Id = commande.Client.Id,
                    Nom = commande.Client.Nom,
                    Prenom = commande.Client.Prenom
                }
            });
            Context.SaveChanges();
        }

        public CommandeDto UpdateCommande(CommandeDto commandeDto)
        {
            var commande = GetCommande(commandeDto.Id);

            commande.Libelle = commandeDto.Libelle;
            commande.Etat = commandeDto.Etat;
            commande.DateCreation = commandeDto.DateCreation;
            commande.DateValidation = commandeDto.DateValidation;
            

            Context.SaveChanges();

            return new CommandeDto()
            {
                Id = commande.Id,
                Libelle = commande.Libelle,
                Etat = commande.Etat,
                DateCreation = commande.DateCreation,
                DateValidation = commande.DateValidation,
                Livraison = commande.Livraison,
                Client = commande.Client
            };
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
