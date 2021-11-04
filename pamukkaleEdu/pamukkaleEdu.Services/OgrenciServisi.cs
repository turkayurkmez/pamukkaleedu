using AutoMapper;
using pamukkaleEdu.Data.Repositories;
using pamukkaleEdu.Entities;
using pamukkaleEdu.Services.DataTransferObjects.Responses;
using pamukkaleEdu.Services.Extensions;
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
        private IMapper mapper;

        public OgrenciServisi(IOgrenciRepository ogrenciRepository, IMapper mapper)
        {
            this.ogrenciRepository = ogrenciRepository;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<OgrenciListeResponse>> OgrencileriGetir()
        {
            var ogrenciler = await ogrenciRepository.GetAllEntitiesAync();
            var ogrenciListeResponses = ogrenciler.ConvertToDto(mapper);// mapper.Map<IEnumerable<OgrenciListeResponse>>(ogrenciler);

            return ogrenciListeResponses;
            //Eğer automapper olmasaydı:
            //List<OgrenciListeResponse> sonuc = new List<OgrenciListeResponse>();
            //ogrenciler.ToList().ForEach(ogr => sonuc.Add(
            //    new OgrenciListeResponse
            //    {
            //        Ad = ogr.Ad,
            //        Durum = ogr.Durum,
            //        Id = ogr.Id,
            //        OgrenciNo = ogr.OgrenciNo,
            //        Program = ogr.Program,
            //        Soyad = ogr.Soyad
            //    }));
        }

        public async Task<OgrenciDetayResponse> OgrenciNoyaGoreOgrenciGetir(string ogrenciNo)
        {
            var ogrenci = await ogrenciRepository.GetStudentByStudentNo(ogrenciNo);
            return ogrenci.ConvertToDto(mapper);
        }
    }
}
