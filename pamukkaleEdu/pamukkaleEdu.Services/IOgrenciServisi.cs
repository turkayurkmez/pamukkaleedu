using pamukkaleEdu.Entities;
using pamukkaleEdu.Services.DataTransferObjects.Requests;
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
        Task<string> OgrenciEkle(OgrenciEkleRequest ogrenciEkleRequest);
        Task<bool> OgrenciVarMi(int id);
        Task Guncelle(OgrenciGuncelleRequest request);
        Task Sil(int id);
    }
}
