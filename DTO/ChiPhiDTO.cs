using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ChiPhiDTO
    {
        public ChiPhiDTO() { }
        public ChiPhiDTO(string Id_LoaiChiPhi, string Id_Doan, long Gia)
        {
            this.Id_LoaiChiPhi = Id_LoaiChiPhi;
            this.Id_Doan = Id_Doan;
            this.Gia = Gia;
        }

        public string Id_LoaiChiPhi { get; set; }
        public string Id_Doan { get; set; }
        public long Gia { get; set; }
    }
}
