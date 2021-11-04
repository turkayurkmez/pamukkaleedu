using pamukkaleEdu.Entities;
using pamukkaleEdu.Services.DataTransferObjects.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pamukkaleEdu.Services
{
   public interface IOgrenciServisi
    {
        Task<IEnumerable<OgrenciListeResponse>> OgrencileriGetir();
        Task<OgrenciDetayResponse> OgrenciNoyaGoreOgrenciGetir(string ogrenciNo);
    }
}
