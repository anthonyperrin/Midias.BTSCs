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
        Task<ProduitDto> GetProduit(int id);
        Task<List<ProduitDto>> GetProduitsAsync();
        void AddProduit(ProduitDto produit);
        Task<ProduitDto> UpdateProduit(ProduitDto produitDto);
        Task
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
                Taxe = produit.Taxe
            };
        }

        public async Task<List<ProduitDto>> GetProduitsAsync()
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

        public async void AddProduit(ProduitDto produit)
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
    }
}