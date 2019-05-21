using Midias.BTSCs.Dal;

namespace Midias.BTSCs.Services
{
    public class ServiceBase
    {
        protected Midias.BTSCs.Dal.BTSCs Context { get; set; }

        public ServiceBase()
        {
            CreateContext();
        }

        public void CreateContext()
        {
            Context = new Midias.BTSCs.Dal.BTSCs();
        }

        public void DisposeContext()
        {
            Context.Dispose();
        }

    }
}