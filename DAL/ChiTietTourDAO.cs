using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data;
namespace DAL
{
    public class ChiTietTourDAO
    {
        public ChiTietTourDAO() { }


        public List<ChiTietTourDTO> ListAll(string id)
        {

            DataProvider datapro = new DataProvider();

            List<ChiTietTourDTO> tours = new List<ChiTietTourDTO>();
            string query = "Select * from CHITIETTOUR where Id_Tour = @id";
            object[] para = new object[]
            {
               id
            };
            DataTable data = datapro.ExecuteQuery(query, para);

            foreach (DataRow item in data.Rows)
            {
                string matour = item["Id_Tour"].ToString();
                string madiadiem = item["Id_DiaDiem"].ToString();
                int thutu = Int32.Parse(item["Thutu"].ToString());


                ChiTietTourDTO newTour = new ChiTietTourDTO(matour, madiadiem, thutu);

                tours.Add(newTour);
            }
            return tours;
        }
        public ChiTietTourDTO get(string id, string diadiem)
        {

            DataProvider datapro = new DataProvider();

            ChiTietTourDTO newTour = new ChiTietTourDTO();
            string query = "Select * from CHITIETTOUR where Id_Tour = @id AND Id_DiaDiem = @diadiem ";
            object[] para = new object[]
            {
               id,
               diadiem
            };
            DataTable data = datapro.ExecuteQuery(query, para);

            foreach (DataRow item in data.Rows)
            {
                string matour = item["Id_Tour"].ToString();
                string madiadiem = item["Id_DiaDiem"].ToString();
                int thutu = Int32.Parse(item["Thutu"].ToString());


                newTour = new ChiTietTourDTO(matour, madiadiem, thutu);
            }
            return newTour;
        }
        public bool Update(ChiTietTourDTO tour, string id)
        {
            string query = "update CHITIETTOUR set " +
                "Id_DiaDiem = @DIADIEM , " +
                "Thutu = @thutu " +
                "where Id_Tour = @oldMATOUR and Id_DiaDiem = @madd";
            object[] para = new object[]
            {
                tour.Id_DiaDiem,
                tour.Thutu,
                tour.Id_Tour,
                id
            };
            try
            {
                DataProvider datapro = new DataProvider();
                if (datapro.ExecuteNonQuery(query, para) > 0)
                    return true;
            }
            catch (Exception e) { }
            return false;
        }

        public bool Insert(ChiTietTourDTO tour)
        {
            string queryThuTu = "select * from CHITIETTOUR where Id_Tour = @MATOUR and Thutu = @THUTU ";
            string query = "insert into CHITIETTOUR " +
                "values( @MATOUR , @MADIADIEM , @THUTU )";

            object[] paraThuTu = new object[]
            {
                tour.Id_Tour,
                tour.Thutu
            };

            object[] para = new object[]
            {
                tour.Id_Tour,
                tour.Id_DiaDiem,
                tour.Thutu
            };
            DataProvider datapro = new DataProvider();
            try
            {
                DataTable data = datapro.ExecuteQuery(queryThuTu, paraThuTu);
                if (data.Rows.Count > 0)
                    return false;
                if (datapro.ExecuteNonQuery(query, para) > 0)
                    return true;
            }
            catch (Exception e)
            {
                return false;
            }
            return false;
        }

        public bool Delete(string idtour, string iddiadiem)
        {
            string query = "delete from CHITIETTOUR where Id_Tour = @MATOUR AND Id_Diadiem = @MADIADIEM ";

            object[] para = new object[]
            {
                idtour,
                iddiadiem,
            };
            DataProvider datapro = new DataProvider();
            try
            {
                if (datapro.ExecuteNonQuery(query, para) > 0)
                    return true;
            }
            catch (Exception e) { }
            return false;
        }
    }
}
