using AutoMapper;
using pamukkaleEdu.Entities;
using pamukkaleEdu.Services.DataTransferObjects.Requests;
using pamukkaleEdu.Services.DataTransferObjects.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pamukkaleEdu.Services.Mapping
{
   public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Ogrenci, OgrenciListeResponse>().ReverseMap();
            CreateMap<Ogrenci, OgrenciDetayResponse>().ReverseMap();
            CreateMap<OgrenciEkleRequest, Ogrenci>();
            CreateMap<OgrenciGuncelleRequest, Ogrenci>();
        }
    }
}
