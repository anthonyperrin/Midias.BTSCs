using Midias.BTSCs.Dal;
using Midias.BTSCs.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Midias.BTSCs.Services.Services
{

    public interface IAdressesService
    {
        /// <summary>
        /// Returns the matching adresse
        /// </summary>
        /// <param name="id">Adresse Id</param>
        /// <returns></returns>
        Adresse GetAdresse(int id);
        /// <summary>
        /// Returns a list with all the adresses
        /// </summary>
        /// <returns></returns>
        List<AdresseDto> GetAdresses();
        /// <summary>
        /// Create a new template of product
        /// </summary>
        /// <param name="adresse">Adresse Dto</param>
        /// <returns></returns>
        void CreateNewAdresse(AdresseDto adresse);
        /// <summary>
        /// Updates the given adresse with its new values
        /// </summary>
        /// <param name="adresseDto">New adresse Dto</param>
        /// <returns></returns>
        AdresseDto UpdateAdresse(AdresseDto adresseDto);
        /// <summary>
        /// Delete the adresse template
        /// </summary>
        /// <param name="id">Adresse to remove Id</param>
        /// <returns></returns>
        void DeleteAdresse(int id);
    }

    class AdressesService : ServiceBase, IAdressesService
    {
        public AdressesService()
        {
        }

        public Adresse GetAdresse(int id)
        {
            return Context.Adresse.Where(p => p.Id == id).FirstOrDefault();
        }

        public List<AdresseDto> GetAdresses()
        {
            return Context.Adresse.Select(a => new AdresseDto()
            {
                Id = a.Id,
                Rue1 = a.Rue1,
                Rue2 = a.Rue2,
                CodePostal = a.CodePostal,
                Ville = a.Ville,
                Pays = a.Pays
            }).ToList();
        }

        public void CreateNewAdresse(AdresseDto adresse)
        {
            Context.Adresse.Add(new Adresse()
            {
                Id = adresse.Id,
                Rue1 = adresse.Rue1,
                Rue2 = adresse.Rue2,
                CodePostal = adresse.CodePostal,
                Ville = adresse.Ville,
                Pays = adresse.Pays
            });
            Context.SaveChanges();
        }

        public AdresseDto UpdateAdresse(AdresseDto adresseDto)
        {
            Adresse adresse = Context.Adresse.Where(p => p.Id == adresseDto.Id).FirstOrDefault();

            adresse.Rue1 = adresseDto.Rue1;
            adresse.Rue2 = adresseDto.Rue2;
            adresse.CodePostal = adresseDto.CodePostal;
            adresse.Ville = adresseDto.Ville;
            adresse.Pays = adresseDto.Pays;

            Context.SaveChanges();

            return adresseDto;
        }

        public void DeleteAdresse(int id)
        {
            var adresse = Context.Adresse.Where(p => p.Id == id).FirstOrDefault();

            if (adresse == null)
                return;

            Context.Adresse.Remove(adresse);

            Context.SaveChanges();
        }
    }
}
