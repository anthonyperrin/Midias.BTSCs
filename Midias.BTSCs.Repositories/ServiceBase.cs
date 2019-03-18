using Midias.BTSCs.Dal;

namespace Midias.BTSCs.Services
{
    public class ServiceBase
    {
        protected BTSCsDbContext Context { get; set; }

        public ServiceBase()
        {
            CreateContext();
        }

        public void CreateContext()
        {
            Context = new BTSCsDbContext();
        }

        public void DisposeContext()
        {
            Context.Dispose();
        }

    }
}