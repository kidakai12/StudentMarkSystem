using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DiaDiemDTO
    {
        public DiaDiemDTO() { }
        public DiaDiemDTO(string Id_DiaDiem, string Ten_DiaDiem)
        {
            this.Id_DiaDiem = Id_DiaDiem;
            this.Ten_DiaDiem = Ten_DiaDiem;
        }
        public string Id_DiaDiem { get; set; }
        public string Ten_DiaDiem { get; set; }
    }
}
