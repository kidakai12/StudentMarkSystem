using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using DAL;
using DTO;
namespace BUS
{
    public class ThongKeBUS
    {
        public ThongKeBUS() { }

        public long chiphikhachsan(List<DoanDuLichDTO> list, string dt1, string dt2)
        {
            long tong = 0;
            foreach (DoanDuLichDTO i in list)
            {
                Tool tool = new Tool();
                if (tool.comparedate(i.Ngaykhoihanh,dt1)>=0 && tool.comparedate(i.Ngayketthuc,dt2)<=0)
                {
                    List<ChiPhiDTO> chiphi = new ChiPhiBUS().List(i.Id_Doan);
                        ChiPhiDTO cpcon = new ChiPhiDTO();
                    if (chiphi.FindAll(x => x.Id_LoaiChiPhi.Equals("CP002")).Count > 0)
                    {
                        long khachsan = 0;
                        khachsan = chiphi.Find(x => x.Id_LoaiChiPhi.Equals("CP002")).Gia;

                        tong = tong + khachsan;
                    }
                }
            }
            return tong;
        }
        public long chiphianuong(List<DoanDuLichDTO> list, string dt1, string dt2)
        {
            long tong = 0;
            foreach (DoanDuLichDTO i in list)
            {
                Tool tool = new Tool();
                if (tool.comparedate(i.Ngaykhoihanh, dt1) >= 0 && tool.comparedate(i.Ngayketthuc, dt2) <= 0)
                {
                    List<ChiPhiDTO> chiphi = new ChiPhiBUS().List(i.Id_Doan);
                    ChiPhiDTO cpcon = new ChiPhiDTO();
                    if (chiphi.FindAll(x => x.Id_LoaiChiPhi.Equals("CP001")).Count > 0)
                    {
                        long khachsan = 0;
                        khachsan = chiphi.Find(x => x.Id_LoaiChiPhi.Equals("CP001")).Gia;

                        tong = tong + khachsan;
                    }
                }
            }
            return tong;
        }

        public long chiphiphuongtien(List<DoanDuLichDTO> list, string dt1, string dt2)
        {
            long tong = 0;
            foreach (DoanDuLichDTO i in list)
            {
                Tool tool = new Tool();
                if (tool.comparedate(i.Ngaykhoihanh, dt1) >= 0 && tool.comparedate(i.Ngayketthuc, dt2) <= 0)
                {
                    List<ChiPhiDTO> chiphi = new ChiPhiBUS().List(i.Id_Doan);
                    ChiPhiDTO cpcon = new ChiPhiDTO();
                    if (chiphi.FindAll(x => x.Id_LoaiChiPhi.Equals("CP003")).Count > 0)
                    {
                        long khachsan = 0;
                        khachsan = chiphi.Find(x => x.Id_LoaiChiPhi.Equals("CP003")).Gia;

                        tong = tong + khachsan;
                    }
                }
            }
            return tong;
        }

        public long doanhso(List<DoanDuLichDTO> list, string dt1, string dt2)
        {
            long tong = 0;
            foreach (DoanDuLichDTO i in list)
            {
                Tool tool = new Tool();
                if (tool.comparedate(i.Ngaykhoihanh, dt1) >= 0 && tool.comparedate(i.Ngayketthuc, dt2) <= 0)
                {
                    tong = tong + i.Doanhthu;
                }
            }
            return tong- (chiphiphuongtien(list,dt1,dt2)+ chiphikhachsan(list, dt1, dt2) + chiphianuong(list, dt1, dt2));
        }

        public int sodoan(List<DoanDuLichDTO> list, string dt1, string dt2)
        {
            int tong = 0;
            foreach (DoanDuLichDTO i in list)
            {
                Tool tool = new Tool();
                if (tool.comparedate(i.Ngaykhoihanh, dt1) >= 0 && tool.comparedate(i.Ngayketthuc, dt2) <= 0)
                {
                    tong = tong + 1;
                }
            }
            return tong;
        }

        public long tongtatca(List<DoanDuLichDTO> list, string dt1, string dt2)
        {
            long tong = 0;
            foreach (DoanDuLichDTO i in list)
            {
                Tool tool = new Tool();
                if (tool.comparedate(i.Ngaykhoihanh, dt1) >= 0 && tool.comparedate(i.Ngayketthuc, dt2) <= 0)
                {
                    tong = tong + i.Doanhthu;
                }
            }
            return tong;
        }
    }
}
