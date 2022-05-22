using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace BUS
{
    public class DiaDiemBUS
    {
        public DiaDiemBUS() { }

        public List<DiaDiemDTO> List()
        {
            return new DiaDiemDAO().ListAll();
        }

        public List<DiaDiemDTO> ListSearch(string text)
        {
            return new DiaDiemDAO().ListSearch(text);
        }
        public DiaDiemDTO getDiaDiem(string id)
        {
            return new DiaDiemDAO().getDiaDiem(id);
        }
        //public string getName(string id)
        //{
        //    return new LoaiTourDAO().getName(id);
        //}

        public bool Insert(DiaDiemDTO diadiem)
        {
            return new DiaDiemDAO().Insert(diadiem);
        }

        public bool Update(DiaDiemDTO diadiem)
        {
            return new DiaDiemDAO().Update(diadiem);
        }

        public bool Delete(string madiadiem)
        {
            return new DiaDiemDAO().Delete(madiadiem);
        }
        public String MakeID()
        {
            return new DiaDiemDAO().MakeID();
        }
    }
}
