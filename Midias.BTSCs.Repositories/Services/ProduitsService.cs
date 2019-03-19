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
        Task<ProduitDto> GetProduit(int id);
        /// <summary>
        /// Returns a list with all the products
        /// </summary>
        /// <returns></returns>
        Task<List<ProduitDto>> GetProduits();
        /// <summary>
        /// Create a new template of product
        /// </summary>
        /// <param name="produit">Product Dto</param>
        /// <returns></returns>
        Task CreateNewProduit(ProduitDto produit);
        /// <summary>
        /// Updates the given product with its new values
        /// </summary>
        /// <param name="produitDto">New product Dto</param>
        /// <returns></returns>
        Task<ProduitDto> UpdateProduit(ProduitDto produitDto);
        /// <summary>
        /// Delete the product template
        /// </summary>
        /// <param name="id">Product to remove Id</param>
        /// <returns></returns>
        Task DeleteProduit(int id);
    }

    public class ProduitsService : ServiceBase, IProduitsService
    {
        public ProduitsService()
        {
        }

        public async Task<ProduitDto> GetProduit(int id)
        {
            var produit = await Context.Produits.Where(p => p.Id == id).FirstOrDefaultAsync();
            return new ProduitDto()
            {
                Id = produit.Id,
                Libelle = produit.Libelle,
                PrixHT = produit.PrixHT,
                Categorie = produit.Categorie,
                Taxe = produit.Taxe,
                Mouvements = produit.Mouvements.Select(m => new MouvementDto()
                {
                    Id = m.Id,
                    Date = m.Date,
                    Quantite = m.Quantite
                }).ToList()
            };
        }

        public async Task<List<ProduitDto>> GetProduits()
        {
            return await Context.Produits.Select(p => new ProduitDto()
            {
                Id = p.Id,
                PrixHT = p.PrixHT,
                Libelle = p.Libelle,
                Taxe = p.Taxe,
                Categorie = p.Categorie
            }).ToListAsync();
        }

        public async Task CreateNewProduit(ProduitDto produit)
        {
            Context.Produits.Add(new Produit()
            {
                Id = produit.Id,
                Libelle = produit.Libelle,
                PrixHT = produit.PrixHT,
                Categorie = produit.Categorie,
                Taxe = produit.Taxe
            });
            await Context.SaveChangesAsync();
        }

        public async Task<ProduitDto> UpdateProduit(ProduitDto produitDto)
        {
            var produit = await GetProduit(produitDto.Id);

            produit.Libelle = produitDto.Libelle;
            produit.PrixHT = produitDto.PrixHT;
            produit.Taxe = produitDto.Taxe;
            produit.Categorie = produitDto.Categorie;

            await Context.SaveChangesAsync();

            return new ProduitDto()
            {
                Libelle = produit.Libelle,
                PrixHT = produit.PrixHT,
                Categorie = produit.Categorie,
                Taxe = produit.Taxe
            };
        }

        public async Task DeleteProduit(int id)
        {
            var produit = await Context.Produits.Where(p => p.Id == id).FirstOrDefaultAsync();

            if (produit == null)
                return;

            Context.Produits.Remove(produit);

            await Context.SaveChangesAsync();
        }
    }
}