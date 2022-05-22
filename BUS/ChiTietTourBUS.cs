using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTO;
using System.Windows.Forms;
namespace BUS
{
    public class ChiTietTourBUS
    {
        public List<ChiTietTourDTO> List(string id)
        {
            return new ChiTietTourDAO().ListAll(id);
        }
        public ChiTietTourDTO get(string id,string diadiem)
        {
            return new ChiTietTourDAO().get(id,diadiem);
        }
        public bool Update(ChiTietTourDTO chitiet, string id)
        {
            return new ChiTietTourDAO().Update(chitiet, id);
        }

        public bool Insert(ChiTietTourDTO chitiet)
        {
            return new ChiTietTourDAO().Insert(chitiet);
        }
        public bool Delete(string idtour,string iddiadiem)
        {
            return new ChiTietTourDAO().Delete(idtour,iddiadiem);
        }
    }
}
