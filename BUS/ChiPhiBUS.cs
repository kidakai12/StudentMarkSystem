using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
namespace BUS
{
    public class ChiPhiBUS
    {
        public List<ChiPhiDTO> List(string id)
        {
            return new ChiPhiDAO().ListAll(id);
        }
        public ChiPhiDTO get(string id, string diadiem)
        {
            return new ChiPhiDAO().get(id, diadiem);
        }
        public bool Update(ChiPhiDTO chitiet,string loai)
        {
            return new ChiPhiDAO().Update(chitiet,loai);
            //
        }

        public bool Insert(ChiPhiDTO chitiet)
        {
            return new ChiPhiDAO().Insert(chitiet);
            //Hung
        }
        public bool Delete(string loai, string doan)
        {
            return new ChiPhiDAO().Delete(loai, doan);
        }
    }
}
