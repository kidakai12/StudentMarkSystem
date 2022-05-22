using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class KhachDTO
    {
        public KhachDTO() { }
        public KhachDTO(string Id_Khach, string Hoten_Khach, string Cmnd_Khach, string Diachi_Khach, string Gioitinh_Khach, string Sdt_Khach, string Quoctich, int Tinh_Trang)
        {
            this.Id_Khach = Id_Khach;
            this.Hoten_Khach = Hoten_Khach;
            this.Cmnd_Khach = Cmnd_Khach;
            this.Diachi_Khach = Diachi_Khach;
            this.Gioitinh_Khach = Gioitinh_Khach;
            this.Sdt_Khach = Sdt_Khach;
            this.Quoctich = Quoctich;
            this.Tinh_Trang = Tinh_Trang;
        }
        public string Id_Khach { get; set; }
        public string Hoten_Khach { get; set; }
        public string Cmnd_Khach { get; set; }
        public string Diachi_Khach { get; set; }
        public string Gioitinh_Khach { get; set; }
        public string Sdt_Khach { get; set; }
        public string Quoctich { get; set; }
        public int Tinh_Trang { get; set; }
    }
}
