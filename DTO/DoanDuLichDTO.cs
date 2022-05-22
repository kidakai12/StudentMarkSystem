using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DoanDuLichDTO
    {
        public DoanDuLichDTO() { }
        public DoanDuLichDTO(string Id_Doan, string Ten_Doan, string Id_Tour, string Ngaykhoihanh, string Ngayketthuc, long Doanhthu, string Noidung)
        {
            this.Id_Doan = Id_Doan;
            this.Ten_Doan = Ten_Doan;
            this.Id_Tour = Id_Tour;
            this.Ngaykhoihanh = Ngaykhoihanh;
            this.Ngayketthuc = Ngayketthuc;
            this.Doanhthu = Doanhthu;
            this.Noidung = Noidung;
        }
        public string Id_Doan { get; set; }
        public string Ten_Doan { get; set; }
        public string Id_Tour { get; set; }
        public string Ngaykhoihanh { get; set; }
        public string Ngayketthuc { get; set; }
        public long Doanhthu { get; set; }
        public string Noidung { get; set; }
    }
}
