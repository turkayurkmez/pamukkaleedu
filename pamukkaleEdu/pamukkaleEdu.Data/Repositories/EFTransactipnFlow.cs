using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pamukkaleEdu.Data.Repositories
{
    public class EFTransactipnFlow
    {
        private IOgrenciRepository ogrenciRepository;
        private IDersRepository dersRepository;

        public EFTransactipnFlow(IOgrenciRepository ogrenciRepository, IDersRepository dersRepository)
        {
            this.ogrenciRepository = ogrenciRepository;
            this.dersRepository = dersRepository;
        }
        public void AddStudentAndCourse()
        {
            ogrenciRepository.
        }
    }
}
