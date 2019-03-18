using Midias.BTSCs.Dal;
using Midias.BTSCs.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midias.BTSCs.Repositories
{
    public static class Test
    {
        public static List<ProduitDto> TestMethod()
        {

            using (var context = new BTSCsDbContext())
            {
                // Create and save a new Students
                Console.WriteLine("Ajout de nouveaux produits...");

                var produit = new Produit
                {
                    Id = 1,
                    Libelle  = "Bomer",
                    PrixHT = 0.2
                };

                context.Produits.Add(produit);

                var produit2 = new Produit
                {
                    Id = 1,
                    Libelle = "Upston",
                    PrixHT = 3.5
                };

                context.Produits.Add(produit2);
                context.SaveChanges();

                // Display all Students from the database
                var produits = (from s in context.Produits
                                orderby s.Id
                                select s).ToList().Select(s => new ProduitDto()
                                {
                                    Id = s.Id,
                                    PrixHT = s.PrixHT,
                                    Libelle = s.Libelle
                                }).ToList();

                Console.WriteLine("Retrieve all Students from the database:");

                foreach (var p in produits)
                {
                    string info = p.PrixHT + " " + p.PrixHT;
                    Console.WriteLine("ID: {0}, Infos: {1}", p.Id, info);
                }
            
                return produits;
            }
        }

    }
}
