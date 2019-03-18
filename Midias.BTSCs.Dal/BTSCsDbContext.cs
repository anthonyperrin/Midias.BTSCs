using System.Data.Entity;

namespace Midias.BTSCs.Dal
{
    public class BTSCsDbContext : DbContext
    {
        public virtual DbSet<Produit> Produits { get; set; }
    }
}
