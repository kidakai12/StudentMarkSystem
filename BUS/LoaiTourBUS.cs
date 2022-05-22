using System;
using System.Collections.Generic;
using System.Text;
using DAL;
using DTO;
using System.Windows.Forms;
namespace BUS
{
    public class LoaiTourBUS
    {
        public LoaiTourBUS() { }

        private LoaiTourDAO dao = new LoaiTourDAO();
        public List<LoaiTourDTO> List()
        {
            return new LoaiTourDAO().ListAll();
        }
        public string getID(string tenloai)
        {
            return dao.getID(tenloai);
        }
        public string getName(string id)
        {
            return dao.getName(id);
        }
    }
}
