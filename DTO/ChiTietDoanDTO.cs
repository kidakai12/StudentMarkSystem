using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ChiTietDoanDTO
    {
        public ChiTietDoanDTO() { }
        public ChiTietDoanDTO(string Id_Doan, string Id_Khach)
        {
            this.Id_Doan = Id_Doan;
            this.Id_Khach = Id_Khach;
        }
        public string Id_Doan { get; set; }
        public string Id_Khach { get; set; }
    }
}
