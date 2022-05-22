using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
namespace BUS
{
    public class LoaiChiPhiBUS
    {
        public LoaiChiPhiBUS()
        {

        }

        public List<LoaiChiPhiDTO> List()
        {
            return new LoaiChiPhiDAO().List();
        }
    }
}
