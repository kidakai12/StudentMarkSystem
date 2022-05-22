using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DTO;
using System.Windows.Forms;
namespace DAL
{
    public class TourDAO
    {
        DataProvider datapro = new DataProvider();
        public TourDAO() { }

        public List<TourDTO> ListAll()
        {
            List<TourDTO> tours = new List<TourDTO>();
            try
            {
                string query = "Select * from TOUR";

                DataTable data = datapro.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    string matour = item["Id_Tour"].ToString();
                    string tentour = item["Ten_Tour"].ToString();
                    string dacdiem = item["Dacdiem_Tour"].ToString();
                    string maloai = item["Id_Loai"].ToString();
                    string tinhtrang = item["Tinh_Trang"].ToString();
                    TourDTO newTour = new TourDTO(matour, tentour, dacdiem, maloai,Int32.Parse(tinhtrang));

                    tours.Add(newTour);
                }
            }catch(Exception e)
            {
                Console.WriteLine("Lỗi DB tại ListAll "+e);
            }
            return tours;
        }
        public bool Update(TourDTO tour)
        {
            try
            {
                string query = "update TOUR set " +
                    "Ten_Tour = @TENTOUR , " +
                    "Dacdiem_Tour = @DACDIEM , " +
                    "Id_Loai = @MALOAI " +
                    "where Id_Tour = @oldMATOUR";

                object[] para = new object[]
                {
                tour.Ten_Tour,
                tour.Dacdiem_Tour,
                tour.Id_Loai,
                tour.Id_Tour
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

        public bool Insert(TourDTO tour)
        {
            try
            {
                string query = "insert into TOUR (Id_Tour , Ten_Tour , Dacdiem_Tour , Id_Loai , Tinh_Trang ) " +
                    "values( @MATOUR , @TENTOUR , @DACDIEM , @MALOAI , @tinhtrang )";

                object[] para = new object[]
                {
                tour.Id_Tour,
                tour.Ten_Tour,
                tour.Dacdiem_Tour,
                tour.Id_Loai,
                tour.Tinh_Trang
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

        public bool Delete(string id)
        {
            try
            {
                string query = "update TOUR set " +
                    "Tinh_Trang = @tinhtrang " +
                    "where Id_Tour = @oldMATOUR ";

                object[] para = new object[]
                {
                0,
                id
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
        public int Count()
        {
            string query = "select count(*) from TOUR";
            DataProvider datapro = new DataProvider();
            int count = (int)datapro.ExecuteScalar(query);
            return count;
        }
        public int Exist(String id)
        {
            string query = "select count(*) from TOUR where Id_Tour = '"+id+"'";
            DataProvider datapro = new DataProvider();
            int count = (int)datapro.ExecuteScalar(query);
            return count;
        }
        public String MakeID()
        {
            String id = "";
            int count = Count();
            while (true)
            {
                if(count < 10)
                id = "T0" + count;
                else
                id = "T" + count;
                if (Exist(id) == 0)
                    break;
                else count++;
            }
            return id;
        }
    }
}
