using Midias.BTSCs.Dal;
using Midias.BTSCs.Dto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Midias.BTSCs.Services
{
    public interface IProduitsService
    {
        /// <summary>
        /// Returns the matching product
        /// </summary>
        /// <param name="id">Product Id</param>
        /// <returns></returns>
        Produit GetProduit(int id);
        /// <summary>
        /// Returns a list with all the products
        /// </summary>
        /// <returns></returns>
        List<ProduitDto> GetProduits();
        /// <summary>
        /// Create a new template of product
        /// </summary>
        /// <param name="produit">Product Dto</param>
        /// <returns></returns>
        void CreateNewProduit(ProduitDto produit);
        /// <summary>
        /// Updates the given product with its new values
        /// </summary>
        /// <param name="produitDto">New product Dto</param>
        /// <returns></returns>
        ProduitDto UpdateProduit(ProduitDto produitDto);
        /// <summary>
        /// Delete the product template
        /// </summary>
        /// <param name="id">Product to remove Id</param>
        /// <returns></returns>
        void DeleteProduit(int id);
    }

    public class ProduitsService : ServiceBase, IProduitsService
    {
        public ProduitsService()
        {
        }

        public Produit GetProduit(int id)
        {
            return Context.Produit.Where(p => p.Id == id).FirstOrDefault();
        }

        public List<ProduitDto> GetProduits()
        {
            return Context.Produit.Select(p => new ProduitDto()
            {
                Id = p.Id,
                PrixHT = p.PrixHT,
                Libelle = p.Libelle,
                Taxe = p.Taxe,
                Quantite = p.Quantite,
                Categorie = new CategorieDto()
                {
                    Id = p.Categorie.Id,
                    Libelle = p.Categorie.Libelle
                },
            }).ToList();
        }

        public void CreateNewProduit(ProduitDto produit)
        {
            Produit prod = new Produit();
            prod.Libelle = produit.Libelle;
            prod.PrixHT = produit.PrixHT;
            prod.Quantite = produit.Quantite;
            prod.Taxe = produit.Taxe;
            prod.Categorie = Context.Categorie.Where(x => x.Id == produit.Categorie.Id).FirstOrDefault();
            Context.Produit.Add(prod);
            Context.SaveChanges();
        }

        public ProduitDto UpdateProduit(ProduitDto produitDto)
        {
            var produit = Context.Produit.Where(p => p.Id == produitDto.Id).FirstOrDefault(); ;

            produit.Libelle = produitDto.Libelle;
            produit.PrixHT = produitDto.PrixHT;
            produit.Taxe = produitDto.Taxe;
            produit.Categorie.Libelle = produitDto.Categorie.Libelle;

            Context.SaveChanges();

            return produitDto;
        }

        public void DeleteProduit(int id)
        {
            var produit = Context.Produit.Where(p => p.Id == id).FirstOrDefault();

            if (produit == null)
                return;

            Context.Produit.Remove(produit);

            Context.SaveChanges();
        }
    }
}