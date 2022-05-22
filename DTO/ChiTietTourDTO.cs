using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ChiTietTourDTO
    {
        public ChiTietTourDTO() { }
        public ChiTietTourDTO(string Id_Tour, string Id_DiaDiem, int Thutu)
        {
            this.Id_Tour = Id_Tour;
            this.Id_DiaDiem = Id_DiaDiem;
            this.Thutu = Thutu;
        }
        public string Id_Tour { get; set; }
        public string Id_DiaDiem { get; set; }
        public int Thutu { get; set; }
    }
}
