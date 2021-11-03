using pamukkaleEdu.Data.Repositories;
using pamukkaleEdu.Entities;
using pamukkaleEdu.Services.DataTransferObjects.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pamukkaleEdu.Services
{
    public class OgrenciServisi : IOgrenciServisi
    {
        private IOgrenciRepository ogrenciRepository;
        public OgrenciServisi(IOgrenciRepository ogrenciRepository)
        {
            this.ogrenciRepository = ogrenciRepository;
        }
        public async Task<IEnumerable<OgrenciListeResponse>> OgrencileriGetir()
        {
            var ogrenciler = await ogrenciRepository.GetAllEntitiesAync();
            List<OgrenciListeResponse> sonuc = new List<OgrenciListeResponse>();
            ogrenciler.ToList().ForEach(ogr => sonuc.Add(
                new OgrenciListeResponse
                {
                    Ad = ogr.Ad,
                    Durum = ogr.Durum,
                    Id = ogr.Id,
                    OgrenciNo = ogr.OgrenciNo,
                    Program = ogr.Program,
                    Soyad = ogr.Soyad
                }));

            return sonuc;
        }
    }
}
