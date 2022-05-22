using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class GiaDTO
    {
        public GiaDTO() { }
        public GiaDTO(string Id_Gia, string Id_Tour, string Gia, string Thoigianbatdau, string Thoigianketthuc)
        {
            this.Id_Gia = Id_Gia;
            this.Id_Tour = Id_Tour;
            this.Gia = Gia;
            this.Thoigianbatdau = Thoigianbatdau;
            this.Thoigianketthuc = Thoigianketthuc;
        }
        public string Id_Gia { get; set; }
        public string Id_Tour { get; set; }
        public string Gia { get; set; }
        public string Thoigianbatdau { get; set; }
        public string Thoigianketthuc { get; set; }
    }
}
