using Midias.BTSCs.Dal;
using Midias.BTSCs.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midias.BTSCs.Services.Services
{
    public interface ILivraisonsService
    {
        /// <summary>
        /// Returns the matching livraison
        /// </summary>
        /// <param name="id">Livraison Id</param>
        /// <returns></returns>
        Livraison GetLivraison(int id);
        /// <summary>
        /// Returns a list with all the livraison
        /// </summary>
        /// <returns></returns>
        List<LivraisonDto> GetLivraisons();
        /// <summary>
        /// Create a new template of livraison
        /// </summary>
        /// <param name="livraison">livraison Dto</param>
        /// <returns></returns>
        void CreateNewLivraison(LivraisonDto livraison);
        /// <summary>
        /// Updates the given livraison with its new values
        /// </summary>
        /// <param name="livraisonDto">New livraison Dto</param>
        /// <returns></returns>
        LivraisonDto UpdateLivraison(LivraisonDto livraisonDto);
        /// <summary>
        /// Delete the livraison template
        /// </summary>
        /// <param name="id">livraison to remove Id</param>
        /// <returns></returns>
        void DeleteLivraison(int id);
    }

    class LivraisonsService : ServiceBase, ILivraisonsService
    {
        public LivraisonsService()
        {
        }

        public Livraison GetLivraison(int id)
        {
            return Context.Livraison.Where(p => p.Id == id).FirstOrDefault(); 
        }

        public List<LivraisonDto> GetLivraisons()
        {
            return Context.Livraison.Select(livraison => new LivraisonDto()
            {
                Id = livraison.Id,
                DateLivraison = livraison.DateLivraison,
                Adresse = new AdresseDto()
                {
                    Id = livraison.Adresse.Id,
                    Rue1 = livraison.Adresse.Rue1,
                    Rue2 = livraison.Adresse.Rue2,
                    CodePostal = livraison.Adresse.CodePostal,
                    Ville = livraison.Adresse.Ville,
                    Pays = livraison.Adresse.Pays
                },
                Commande = new CommandeDto()
                {
                    Id = livraison.Commande.Id,
                    Libelle = livraison.Commande.Libelle,
                    Etat = livraison.Commande.Etat,
                    DateCreation = livraison.Commande.DateCreation,
                    DateValidation = livraison.Commande.DateValidation,
                },
                Salarie = new SalarieDto()
                {
                    Id = livraison.Salarie.Id,
                    Nom = livraison.Salarie.Nom,
                    Prenom = livraison.Salarie.Prenom,
                    Valide = livraison.Salarie.Valide,
                    Permis = livraison.Salarie.Permis,
                    Email = livraison.Salarie.Email,
                    Telephone = livraison.Salarie.Telephone,
                },
                Vehicule = new VehiculeDto()
                {
                    Id = livraison.Vehicule.Id,
                    CarteGrise = livraison.Vehicule.CarteGrise,
                    Immatriculation = livraison.Vehicule.Immatriculation,
                    Modele = livraison.Vehicule.Modele,
                    Marque = livraison.Vehicule.Marque,
                }
            }).ToList();
        }

        public void CreateNewLivraison(LivraisonDto livraison)
        {
            Context.Livraison.Add(new Livraison()
            {
                Id = livraison.Id,
                DateLivraison = livraison.DateLivraison,
                Adresse = new Adresse()
                {
                    Id = livraison.Adresse.Id,
                    Rue1 = livraison.Adresse.Rue1,
                    Rue2 = livraison.Adresse.Rue2,
                    CodePostal = livraison.Adresse.CodePostal,
                    Ville = livraison.Adresse.Ville,
                    Pays = livraison.Adresse.Pays
                },
                Commande = new Commande()
                {
                    Id = livraison.Commande.Id,
                    Libelle = livraison.Commande.Libelle,
                    Etat = (int) livraison.Commande.Etat,
                    DateCreation = (DateTime) livraison.Commande.DateCreation,
                    DateValidation = (DateTime) livraison.Commande.DateValidation,
                },
                Salarie = new Salarie()
                {
                    Id = livraison.Salarie.Id,
                    Nom = livraison.Salarie.Nom,
                    Prenom = livraison.Salarie.Prenom,
                    Valide = (bool) livraison.Salarie.Valide,
                    Permis = livraison.Salarie.Permis,
                    Email = livraison.Salarie.Email,
                    Telephone = livraison.Salarie.Telephone,
                },
                Vehicule = new Vehicule()
                {
                    Id = livraison.Vehicule.Id,
                    CarteGrise = livraison.Vehicule.CarteGrise,
                    Immatriculation = livraison.Vehicule.Immatriculation,
                    Modele = livraison.Vehicule.Modele,
                    Marque = livraison.Vehicule.Marque,
                }
            });
            Context.SaveChanges();
        }

        public LivraisonDto UpdateLivraison(LivraisonDto livraisonDto)
        {
            var livraison = Context.Livraison.Where(p => p.Id == livraisonDto.Id).FirstOrDefault(); ;

            livraison.DateLivraison = livraison.DateLivraison;


            Context.SaveChanges();

            return livraisonDto;
        }

        public void DeleteLivraison(int id)
        {
            var livraison = Context.Livraison.Where(p => p.Id == id).FirstOrDefault();

            if (livraison == null)
                return;

            Context.Livraison.Remove(livraison);

            Context.SaveChanges();
        }
    }

}
