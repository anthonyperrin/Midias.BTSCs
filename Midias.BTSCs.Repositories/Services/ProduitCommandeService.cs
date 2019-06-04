using Midias.BTSCs.Dal;
using Midias.BTSCs.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midias.BTSCs.Services.Services
{
    public interface IProduitCommandeService
    {
        /// <summary>
        /// Returns the matching product-command
        /// </summary>
        /// <param name="idProduit">Product Id</param>
        /// <param name="idCommande">COmmande Id</param>
        /// <returns></returns>
        ProduitCommande GetProduitCommande(int idProduit, int idCommande);
        /// <summary>
        /// Returns a list with all the products-commands
        /// </summary>
        /// <returns></returns>
        List<ProduitCommandeDto> GetProduitCommandes();
        /// <summary>
        /// Create a new template of product-command 
        /// </summary>
        /// <param name="produitCommande">ProductCommand Dto</param>
        /// <returns></returns>
        void CreateNewProduitCommands(ProduitCommandeDto produitCommande);
        /// <summary>
        /// Updates the given product-command with its new values
        /// </summary>
        /// <param name="produitCommandeDto">New product Dto</param>
        /// <returns></returns>
        ProduitCommandeDto UpdateProduitCommande(ProduitCommandeDto produitCommande);
        /// <summary>
        /// Delete the product-command template
        /// </summary>
        /// <param name="idProduit">Product to remove Id</param>
        /// <param name="idCommande">Command to remove Id</param>
        /// <returns></returns>
        void DeleteProduitCommande(ProduitCommandeDto produitCommandeDto);
    }
    public class ProduitCommandeService : ServiceBase, IProduitCommandeService
    {
        public ProduitCommandeService()
        {
        }

        public ProduitCommande GetProduitCommande(int idProduit, int idCommande)
        {
            return Context.ProduitCommande.Where(pc => pc.Produit.Id == idProduit && pc.Commande.Id == idCommande ).FirstOrDefault();
        }

        public List<ProduitCommandeDto> GetProduitCommandes()
        {
            return Context.ProduitCommande.Select(pc => new ProduitCommandeDto()
            {
                Quantite = pc.Quantite,
                Produit = new ProduitDto
                {
                    Id = pc.Produit.Id,
                    Libelle = pc.Produit.Libelle,
                    Quantite = pc.Produit.Quantite,
                    PrixHT = pc.Produit.PrixHT,
                    Taxe = pc.Produit.Taxe,
                    Categorie = new CategorieDto
                    {
                        Id = pc.Produit.Categorie.Id,
                        Libelle = pc.Produit.Categorie.Libelle
                    }
                },
                Commande = new CommandeDto
                {
                    Id = pc.Commande.Id,
                    Libelle = pc.Commande.Libelle,
                    Etat = pc.Commande.Etat,
                    DateCreation = pc.Commande.DateCreation,
                    DateValidation = pc.Commande.DateValidation,
                    Client = new ClientDto
                    {
                        Id = pc.Commande.Client.Id,
                        Nom = pc.Commande.Client.Nom,
                        Prenom = pc.Commande.Client.Prenom,
                        Adresse = new AdresseDto
                        {
                            Id = pc.Commande.Client.Adresse.Id,
                            Rue1 = pc.Commande.Client.Adresse.Rue1,
                            Rue2 = pc.Commande.Client.Adresse.Rue2,
                            Ville = pc.Commande.Client.Adresse.Ville,
                            Pays = pc.Commande.Client.Adresse.Pays,
                            CodePostal = pc.Commande.Client.Adresse.CodePostal,
                        }
                    }
                }
            }).ToList();
        }

        public void CreateNewProduitCommands(ProduitCommandeDto produitCommandeDto)
        {

            ProduitCommande prodCommande = new ProduitCommande()
            {
                Quantite = produitCommandeDto.Quantite,
                Produit = Context.Produit.Where(p => p.Id == produitCommandeDto.Produit.Id).FirstOrDefault(),
                Commande = Context.Commande.Where(c => c.Id == produitCommandeDto.Commande.Id).FirstOrDefault(),
            };

            Context.ProduitCommande.Add(prodCommande);
            Context.SaveChanges();
        }

        public ProduitCommandeDto UpdateProduitCommande(ProduitCommandeDto produitCommandeDto)
        {
            var produitCommande = Context.ProduitCommande.Where(pc => pc.Produit.Id == produitCommandeDto.Produit.Id && pc.Commande.Id == produitCommandeDto.Commande.Id).FirstOrDefault();

            produitCommande.Quantite = produitCommandeDto.Quantite;
            produitCommande.Produit = Context.Produit.Where(p => p.Id == produitCommandeDto.Produit.Id).FirstOrDefault();
            produitCommande.Commande = Context.Commande.Where(p => p.Id == produitCommandeDto.Commande.Id).FirstOrDefault();

            Context.SaveChanges();

            return produitCommandeDto;
        }

        public void DeleteProduitCommande(ProduitCommandeDto produitCommandeDto)
        {
            var produitCommande = Context.ProduitCommande.Where(pc => pc.Produit.Id == produitCommandeDto.Produit.Id && pc.Commande.Id == produitCommandeDto.Commande.Id).FirstOrDefault();

            if (produitCommande == null)
                return;

            Context.ProduitCommande.Remove(produitCommande);

            Context.SaveChanges();
        }
    }
}
