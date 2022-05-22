using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
namespace BUS
{
    public class ChiTietDoanBUS
    {
        public List<ChiTietDoanDTO> List(string id)
        {
            return new ChiTietDoanDAO().ListAll(id);
        }
        public ChiTietDoanDTO get(string id, string idkhach)
        {
            return new ChiTietDoanDAO().get(id, idkhach);
        }
        public bool Insert(ChiTietDoanDTO chitiet)
        {
            return new ChiTietDoanDAO().Insert(chitiet);
        }
        public bool Delete(string iddoan, string idkhach)
        {
            return new ChiTietDoanDAO().Delete(iddoan, idkhach);
        }
    }
}
