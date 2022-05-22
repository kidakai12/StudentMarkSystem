using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class NhanVienDTO
    {
        public NhanVienDTO() { }
        public NhanVienDTO(string Id_NV, string Hoten_NV, string Email_NV, string Sdt_NV, string Gioitinh_NV, int Tinh_Trang)
        {
            this.Id_NV = Id_NV;
            this.Hoten_NV = Hoten_NV;
            this.Email_NV = Email_NV;
            this.Sdt_NV = Sdt_NV;
            this.Gioitinh_NV = Gioitinh_NV;
            this.Tinh_Trang = Tinh_Trang;
        }
        public string Id_NV { get; set; }
        public string Hoten_NV { get; set; }
        public string Email_NV { get; set; }
        public string Sdt_NV { get; set; }
        public string Gioitinh_NV { get; set; }
        public int Tinh_Trang { get; set; }
    }
}
