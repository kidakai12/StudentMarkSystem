using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class LoaiChiPhiDTO
    {
        public LoaiChiPhiDTO(string Id_LoaiChiPhi, string Ten_LoaiChiPhi)
        {
            this.Id_LoaiChiPhi = Id_LoaiChiPhi;
            this.Ten_LoaiChiPhi = Ten_LoaiChiPhi;
        }
        public string Id_LoaiChiPhi { get; set; }
        public string Ten_LoaiChiPhi { get; set; }
    }
}
