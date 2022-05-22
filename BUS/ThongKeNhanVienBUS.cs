using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
namespace BUS
{
    public class ThongKeNhanVienBUS
    {
        public ThongKeNhanVienBUS()
        {

        }

        public List<DoanDuLichDTO> list(List<PhanCongDTO> listchiphi,string dt1,string dt2)
        {
            Tool tool = new Tool();
            List<DoanDuLichDTO> list = new List<DoanDuLichDTO>();
            foreach (PhanCongDTO item in listchiphi)
            {
                DoanDuLichDTO doan = new DoanDuLichDAO().getID(item.Id_Doan);
                if (tool.comparedate(doan.Ngaykhoihanh, dt1) >= 0 && tool.comparedate(doan.Ngaykhoihanh, dt2) <= 0)
                    list.Add(doan);
            }
            return list;
        }
    }
}
