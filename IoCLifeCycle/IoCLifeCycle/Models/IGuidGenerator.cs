using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoCLifeCycle.Models
{
  public  interface IGuidGenerator
    {
        public Guid Guid { get; }

    }

    public interface IScoped : IGuidGenerator
    {

    }

    public interface ITransient: IGuidGenerator { }
    public interface ISingleton : IGuidGenerator { }
}
