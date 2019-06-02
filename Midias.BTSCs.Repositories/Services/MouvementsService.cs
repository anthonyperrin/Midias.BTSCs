using Midias.BTSCs.Dal;
using Midias.BTSCs.Dto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Midias.BTSCs.Services.Services
{
    public interface IMouvementsService
    {
        /// <summary>
        /// Returns the matching mouvement
        /// </summary>
        /// <param name="id">Mouvement Id</param>
        /// <returns></returns>
        Mouvement GetMouvement(int id);
        /// <summary>
        /// Returns a list with all the mouvements
        /// </summary>
        /// <returns></returns>
        List<MouvementDto> GetMouvements();
        /// <summary>
        /// Create a new template of mouvement
        /// </summary>
        /// <param name="mouvement">mouvement Dto</param>
        /// <returns></returns>
        void CreateNewMouvement(MouvementDto mouvement);
        /// <summary>
        /// Updates the given mouvement with its new values
        /// </summary>
        /// <param name="mouvementDto">New mouvement Dto</param>
        /// <returns></returns>
        MouvementDto UpdateMouvement(MouvementDto mouvementDto);
        /// <summary>
        /// Delete the mouvement template
        /// </summary>
        /// <param name="id">Mouvement to remove Id</param>
        /// <returns></returns>
        void DeleteMouvement(int id);
    }

    public class MouvementsService : ServiceBase, IMouvementsService
    {
        public MouvementsService()
        {
        }

        public Mouvement GetMouvement(int id)
        {
            return Context.Mouvement.Where(p => p.Id == id).FirstOrDefault();
        }

        public List<MouvementDto> GetMouvements()
        {
            return Context.Mouvement.Select(mouvement => new MouvementDto()
            {
                Id = mouvement.Id,
                Quantite = mouvement.Quantite,
                DateCreation = mouvement.DateCreation,
                Produit = new ProduitDto()
                {
                    Id = mouvement.Produit.Id,
                    Libelle = mouvement.Produit.Libelle,
                    PrixHT = mouvement.Produit.PrixHT,
                    Taxe = mouvement.Produit.Taxe,
                    Quantite = mouvement.Produit.Quantite
                },
            }).ToList();
        }

        public void CreateNewMouvement(MouvementDto mouvement)
        {
            Mouvement mouv = new Mouvement();
            mouv.Produit = Context.Produit.Where(m => m.Id == mouvement.Produit.Id).FirstOrDefault();
            mouv.Quantite = mouvement.Quantite;
            mouv.DateCreation = mouvement.DateCreation;
            Context.Mouvement.Add(mouv);
            Context.SaveChanges();
        }

        public MouvementDto UpdateMouvement(MouvementDto mouvementDto)
        {
            var mouvement = Context.Mouvement.Where(p => p.Id == mouvementDto.Id).FirstOrDefault(); ;

            mouvement.Quantite = mouvementDto.Quantite;
            mouvement.DateCreation = mouvementDto.DateCreation;

            Context.SaveChanges();

            return mouvementDto;
        }

        public void DeleteMouvement(int id)
        {
            var mouvement = Context.Mouvement.Where(p => p.Id == id).FirstOrDefault();

            if (mouvement == null)
                return;

            Context.Mouvement.Remove(mouvement);

            Context.SaveChanges();
        }
    }
}
