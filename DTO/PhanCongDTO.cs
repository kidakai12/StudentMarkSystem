using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class PhanCongDTO
    {
        public PhanCongDTO() { }
        public PhanCongDTO(string Id_Doan, string Id_NV, string Nhiemvu)
        {
            this.Id_Doan = Id_Doan;
            this.Id_NV = Id_NV;
            this.Nhiemvu = Nhiemvu;
        }
        public string Id_Doan { get; set; }
        public string Id_NV { get; set; }
        public string Nhiemvu { get; set; }
    }
}
