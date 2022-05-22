using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DTO;
namespace DAL
{
    public class LoaiChiPhiDAO
    {
        public LoaiChiPhiDAO()
        {
           
        }
        public List<LoaiChiPhiDTO> List()
        {
            DataProvider datapro = new DataProvider();

            List<LoaiChiPhiDTO> tours = new List<LoaiChiPhiDTO>();
            string query = "Select * from LOAICHIPHI";

            DataTable data = datapro.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string maloai = item["Id_LoaiChiPhi"].ToString();
                string tenloai = item["Ten_LoaiChiPhi"].ToString();

                LoaiChiPhiDTO newTour = new LoaiChiPhiDTO(maloai, tenloai);

                tours.Add(newTour);
            }
            return tours;
        }
    }
}
