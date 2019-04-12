using Midias.BTSCs.Dal;
using Midias.BTSCs.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midias.BTSCs.Services.Services
{

    public interface ICategoriesService
    {
        /// <summary>
        /// Returns the matching categorie
        /// </summary>
        /// <param name="id">Categorie Id</param>
        /// <returns></returns>
        CategorieDto GetCategorie(int id);
        /// <summary>
        /// Returns a list with all the categories
        /// </summary>
        /// <returns></returns>
        List<CategorieDto> GetCategories();
        /// <summary>
        /// Create a new template of categorie
        /// </summary>
        /// <param name="categorie">Categorie Dto</param>
        /// <returns></returns>
        void CreateNewCategorie(CategorieDto categorie);
        /// <summary>
        /// Updates the given categorie with its new values
        /// </summary>
        /// <param name="categorieDto">New categorie Dto</param>
        /// <returns></returns>
        CategorieDto UpdateCategorie(CategorieDto categorieDto);
        /// <summary>
        /// Delete the categorie template
        /// </summary>
        /// <param name="id">Categorie to remove Id</param>
        /// <returns></returns>
        void DeleteCategorie(int id);
    }

    class CategoriesService : ServiceBase, ICategoriesService
    {
        public CategoriesService()
        {
        }

        public CategorieDto GetCategorie(int id)
        {
            var categorie = Context.Categorie.Where(p => p.Id == id).FirstOrDefault();
            return new CategorieDto()
            {
                Id = categorie.Id,
                Libelle = categorie.Libelle
            };
        }

        public List<CategorieDto> GetCategories()
        {
            return Context.Categorie.Select(a => new CategorieDto()
            {
                Id = a.Id,
                Libelle = a.Libelle
            }).ToList();
        }

        public void CreateNewCategorie(CategorieDto categorie)
        {
            Context.Categorie.Add(new Categorie()
            {
                Id = categorie.Id,
                Libelle = categorie.Libelle
            });
            Context.SaveChanges();
        }

        public CategorieDto UpdateCategorie(CategorieDto categorieDto)
        {
            var categorie = GetCategorie(categorieDto.Id);

            categorie.Libelle = categorieDto.Libelle;

            Context.SaveChanges();

            return new CategorieDto()
            {
                Id = categorie.Id,
                Libelle = categorie.Libelle
            };
        }

        public void DeleteCategorie(int id)
        {
            var categorie = Context.Categorie.Where(p => p.Id == id).FirstOrDefault();

            if (categorie == null)
                return;

            Context.Categorie.Remove(categorie);

            Context.SaveChanges();
        }
    }
  
}
