using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DernekYonetim.DAL.Repositories;

namespace DernekYonetim.BLL
{
    public class ToplantiService
    {
        ToplantiRepo toplantiRepo;
        ToplantiDetayRepo toplantiDetayRepo;
        public ToplantiService()
        {
            toplantiRepo = new ToplantiRepo();
            toplantiDetayRepo = new ToplantiDetayRepo();
        }
        public int PlanlananToplantiSayisi()
        {
            return toplantiRepo.GetAll().Where(x => x.ToplantiTarihi > DateTime.Now).Count();
        }
        public int TamamlananToplantiSayisi()
        {
            return toplantiRepo.GetAll().Where(x => x.ToplantiTarihi < DateTime.Now).Count();
        }
    }
}
