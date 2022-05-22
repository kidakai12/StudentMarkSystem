using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class LoaiTourDTO
    {
        public LoaiTourDTO(string Id_Loai, string Ten_Loai)
        {
            this.Id_Loai = Id_Loai;
            this.Ten_Loai = Ten_Loai;
        }
        public string Id_Loai { get; set; }
        public string Ten_Loai { get; set; }
    }
}
