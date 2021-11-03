using pamukkaleEdu.Data.Repositories;
using pamukkaleEdu.Entities;
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
        public async Task<IEnumerable<Ogrenci>> OgrencileriGetir()
        {
            return await ogrenciRepository.GetAllEntitiesAync();
        }
    }
}
