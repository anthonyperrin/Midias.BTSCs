using Midias.BTSCs.Dal;

namespace Midias.BTSCs.Services
{
    public class ServiceBase
    {
        protected BTSCsEntities Context { get; set; }

        public ServiceBase()
        {
            CreateContext();
        }

        public void CreateContext()
        {
            Context = new BTSCsEntities();
        }

        public void DisposeContext()
        {
            Context.Dispose();
        }

    }
}