using AutoMapper;
using pamukkaleEdu.Entities;
using pamukkaleEdu.Services.DataTransferObjects.Requests;
using pamukkaleEdu.Services.DataTransferObjects.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pamukkaleEdu.Services.Extensions
{
   public static class ConverterExtensions
    {
        public static IEnumerable<OgrenciListeResponse> ConvertToDto(this IEnumerable<Ogrenci> ogrenciler, IMapper mapper)
        {
            return mapper.Map<IEnumerable<OgrenciListeResponse>>(ogrenciler);
        } 

        public static OgrenciDetayResponse ConvertToDto(this Ogrenci ogrenci, IMapper mapper)
        {

            var ogrenciDetay = mapper.Map<OgrenciDetayResponse>(ogrenci);
            ogrenciDetay.Dersler = ogrenci.DersDetaylari.Select(x => x.Ders.Ad).ToArray();
            return ogrenciDetay;

        }

        public static Ogrenci ConvertToEntity(this OgrenciEkleRequest request, IMapper mapper)
        {
            return mapper.Map<Ogrenci>(request);
        }

        public static Ogrenci ConvertToEntity(this OgrenciGuncelleRequest request, IMapper mapper)
        {
            return mapper.Map<Ogrenci>(request);
        }
    }
}
