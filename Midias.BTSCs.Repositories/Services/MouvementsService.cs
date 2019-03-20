//using Midias.BTSCs.Dal;
//using Midias.BTSCs.Dto;
//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Midias.BTSCs.Services.Services
//{
//    public interface IMouvementsService
//    {
//        /// <summary>
//        /// Returns a list with all mouvements and their related product
//        /// </summary>
//        /// <param name="days">Number of days we need</param>
//        /// <returns></returns>
//        Task<List<MouvementDto>> GetMouvementsForLastXDays(int numberOfDays);
//    }
//    public class MouvementsService : ServiceBase, IMouvementsService
//    {
//        public MouvementsService()
//        {
//        }

//        public async Task<List<MouvementDto>> GetMouvementsForLastXDays(int numberOfDays)
//        {
//            return await (from m in Context.Mouvements
//                        where m.Date > DateTime.Now.AddDays(-numberOfDays)
//                        select m).Select(m => new MouvementDto()
//                        {
//                             Id = m.Id,
//                             Date = m.Date,
//                             Quantite = m.Quantite,
//                             Produit = new ProduitDto()
//                             {
//                                 Id = m.Produit.Id,
//                                 Libelle = m.Produit.Libelle,
//                                 Categorie = m.Produit.Categorie,
//                                 PrixHT = m.Produit.PrixHT,
//                                 Taxe = m.Produit.Taxe
//                             }
//                        }).ToListAsync();
//        }
//    }
//}
