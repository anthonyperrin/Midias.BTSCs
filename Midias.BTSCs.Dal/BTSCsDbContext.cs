using System.Data.Entity;

namespace Midias.BTSCs.Dal
{
    public class BTSCsDbContext : DbContext
    {
        public virtual DbSet<Mouvement> Mouvements{ get; set; }
        public virtual DbSet<Produit> Produits { get; set; }

    }
}
