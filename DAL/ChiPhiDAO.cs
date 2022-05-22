using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data;
namespace DAL
{
    public class ChiPhiDAO
    {
        public ChiPhiDAO() { }

        public List<ChiPhiDTO> ListAll(string id)
        {

            DataProvider datapro = new DataProvider();

            List<ChiPhiDTO> list = new List<ChiPhiDTO>();
            string query = "Select * from CHIPHI where Id_Doan = @madoan";
            object[] para = new object[]
            {
               id
            }; 
            DataTable data = datapro.ExecuteQuery(query,para);

            foreach (DataRow item in data.Rows)
            {
                string maloai = item["Id_LoaiChiPhi"].ToString();
                string madoan = item["Id_Doan"].ToString();
                int gia = Int32.Parse(item["Gia"].ToString());


                ChiPhiDTO chiphi = new ChiPhiDTO(maloai, madoan, gia);

                list.Add(chiphi);
            }
            return list;
        }
        public ChiPhiDTO get(string loai, string doan)
        {

            DataProvider datapro = new DataProvider();

            ChiPhiDTO chiphi = new ChiPhiDTO();
            string query = "Select * from CHIPHI where Id_loaiChiPhi = @loai AND Id_Doan = @doan ";
            object[] para = new object[]
            {
               loai,
               doan
            };
            DataTable data = datapro.ExecuteQuery(query, para);

            foreach (DataRow item in data.Rows)
            {
                string maloai = item["Id_LoaiChiPhi"].ToString();
                string madoan = item["Id_Doan"].ToString();
                int gia = Int32.Parse(item["Gia"].ToString());


                chiphi = new ChiPhiDTO(maloai, madoan, gia);

            }
            return chiphi;
        }
        public bool Update(ChiPhiDTO chiphi,string loai)
        {
            try
            {
                string query = "update CHIPHI set " +
                    "Id_LoaiChiPhi = @loai , " +
                    "Gia = @gia " +
                    "where Id_LoaiChiPhi = @oldloai AND Id_Doan = @doan";

                object[] para = new object[]
                {
                    chiphi.Id_LoaiChiPhi,
                    chiphi.Gia,
                    loai,
                    chiphi.Id_Doan
                };
                DataProvider datapro = new DataProvider();
                if (datapro.ExecuteNonQuery(query, para) > 0)
                    return true;
            }
            catch (Exception E)
            {
                return false;
            }
            return false;
        }

        public bool Insert(ChiPhiDTO tour)
        {
            try
            {
                string query = "insert into CHIPHI " +
                    "values( @maloai , @madoan , @gia )";

                object[] para = new object[]
                {
                tour.Id_LoaiChiPhi,
                tour.Id_Doan,
                tour.Gia
                };
                DataProvider datapro = new DataProvider();
                if (datapro.ExecuteNonQuery(query, para) > 0)
                    return true;
            }catch(Exception e)
            {
                return false;
            }
            return false;
        }

        public bool Delete(string loai, string doan)
        {
            try
            {
                string query = "delete from CHIPHI " +
                    "where Id_LoaiChiPhi = @loai AND Id_Doan = @doan";

                object[] para = new object[]
                {
                loai,
                doan,
                };
                DataProvider datapro = new DataProvider();
                if (datapro.ExecuteNonQuery(query, para) > 0)
                    return true;
            }
            catch (Exception e)
            {
                return false;
            }
            return false;
        }
    }
}
