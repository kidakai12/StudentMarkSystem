using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;

namespace BUS
{
    public class DoanDuLichBUS
    {
        public List<DoanDuLichDTO> List()
        {
            return new DoanDuLichDAO().ListAll();
        }
        public List<DoanDuLichDTO> ListBaseTour(string id)
        {
            return new DoanDuLichDAO().ListBaseTour(id);
        }
        public bool Update(DoanDuLichDTO doanDuLich)
        {
            return new DoanDuLichDAO().Update(doanDuLich);
        }
        public bool UpdateDoanhThu(string id,long value)
        {
            return new DoanDuLichDAO().UpdateDoanhThu(id, value);
        }

        public bool Insert(DoanDuLichDTO doanDuLich)
        {
            return new DoanDuLichDAO().Insert(doanDuLich);
        }

        public bool Delete(string maDoan)
        {
            return new DoanDuLichDAO().Delete(maDoan);
        }
        public string MakeID()
        {
            return new DoanDuLichDAO().MakeID();
        }
        public string getGiaTour(string ngaykhoihanh, string idtour)
        {
            List<GiaDTO> gia = new GiaBUS().List().FindAll(x => x.Id_Tour.Equals(idtour));
            Tool tool = new Tool();

            foreach (GiaDTO item in gia)
            {
                if (tool.comparedate(ngaykhoihanh, item.Thoigianbatdau) >= 0){
                    return item.Gia;
                }
            }
            return "";
        }
    }
}

