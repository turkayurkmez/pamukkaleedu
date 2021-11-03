using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoCLifeCycle.Models
{
    public class GuidService
    {
        public ITransient Transient { get; set; }
        public IScoped Scoped { get; set; }
        public ISingleton Singleton { get; set; }

        public GuidService(ITransient transient, IScoped scoped, ISingleton singleton)
        {
            Transient = transient;
            Scoped = scoped;
            Singleton = singleton;
        }
    }
}
