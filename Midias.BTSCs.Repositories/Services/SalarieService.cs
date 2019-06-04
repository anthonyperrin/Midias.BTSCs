using Midias.BTSCs.Dal;
using Midias.BTSCs.Dto;
using Midias.BTSCs.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midias.BTSCs.Services
{
    public interface ISalarieService
    {
        /// <summary>
        /// Returns the matching product
        /// </summary>
        /// <param name="id">Salarie Id</param>
        /// <returns></returns>
        Salarie GetSalarie(int id);
        /// <summary>
        /// Returns a list with all the products
        /// </summary>
        /// <returns></returns>
        List<SalarieDto> GetSalaries();
        /// <summary>
        /// Create a new template of product
        /// </summary>
        /// <param name="salarie">Salarie Dto</param>
        /// <returns></returns>
        void CreateNewSalarie(SalarieDto salarie);
        /// <summary>
        /// Updates the given product with its new values
        /// </summary>
        /// <param name="salarieDto">New salarie Dto</param>
        /// <returns></returns>
        SalarieDto UpdateSalarie(SalarieDto salarieDto);
        /// <summary>
        /// Delete the salarie template
        /// </summary>
        /// <param name="id">Salarie to remove Id</param>
        /// <returns></returns>
        void DeleteSalarie(int id);
    }

    public class SalarieService : ServiceBase, ISalarieService
    {
        public SalarieService()
        {

        }

        public Salarie GetSalarie(int id)
        {
            return Context.Salarie.Where(s => s.Id == id).FirstOrDefault();
        }

        public List<SalarieDto> GetSalaries()
        {
            return Context.Salarie.Select(s => new SalarieDto()
            {
                Id = s.Id,
                Nom = s.Nom,
                Prenom = s.Prenom,
                Valide = s.Valide,
                Permis = s.Permis,
                Email = s.Email,
                Telephone = s.Telephone,
            }).ToList();
        }

        public void CreateNewSalarie(SalarieDto salarie)
        {
            Context.Salarie.Add(new Salarie()
            {
                Id = salarie.Id,
                Nom = salarie.Nom,
                Prenom = salarie.Prenom,
                Valide = (bool) salarie.Valide,
                Permis = salarie.Permis,
                Email = salarie.Email,
                Telephone = salarie.Telephone
            });
            Context.SaveChanges();
        }


        public SalarieDto UpdateSalarie(SalarieDto salarieDto)
        {
            var salarie = Context.Salarie.Where(s => s.Id == salarieDto.Id).FirstOrDefault(); ;

            salarie.Nom = salarieDto.Nom;
            salarie.Prenom = salarieDto.Prenom;
            salarie.Valide = (bool) salarieDto.Valide;
            salarie.Permis = salarieDto.Permis;
            salarie.Email = salarieDto.Email;
            salarie.Telephone = salarieDto.Telephone;

            Context.SaveChanges();

            return salarieDto;
        }


        public void DeleteSalarie(int id)
        {
            var salarie = Context.Salarie.Where(s => s.Id == id).FirstOrDefault();

            if (salarie == null)
                return;

            Context.Salarie.Remove(salarie);

            Context.SaveChanges();
        }

    }
}
