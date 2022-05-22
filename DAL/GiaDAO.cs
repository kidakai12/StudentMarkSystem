using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data;
using System.Windows.Forms;

namespace DAL
{
    public class GiaDAO
    {
        public GiaDAO() { }

        public List<GiaDTO> List()
        {
            List<GiaDTO> list = new List<GiaDTO>();
            try 
            {
                DataProvider data = new DataProvider();
                string query = "SELECT * from GIA";

                DataTable table = data.ExecuteQuery(query);
                foreach(DataRow item in table.Rows)
                {
                    string id = item["Id_Gia"].ToString();
                    string idtour = item["Id_Tour"].ToString();
                    string gia = item["Gia"].ToString();
                    string thoigianbatdau = item["Thoigianbatdau"].ToString();
                    string thoigianketthuc = item["Thoigianketthuc"].ToString();

                    GiaDTO itemgia = new GiaDTO(id,idtour,gia,thoigianbatdau,thoigianketthuc);
                    list.Add(itemgia);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi xảy ra ở List GiaDAO: \n"+ e.Message);
            }
            return list;
        }
        public bool Update(GiaDTO gia)
        {
            string query = "update GIA set " +
               "Id_Tour = @idtour , " +
               "Gia = @gia ," +
               " Thoigianbatdau =  @begin , " +
               "Thoigianketthuc =  @end " +
               "where Id_Gia = @idgia ";
            
            object[] para = new object[]
            {
                gia.Id_Tour,
                gia.Gia,
                gia.Thoigianbatdau,
                gia.Thoigianketthuc,
                gia.Id_Gia
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
        public bool Delete(string idgia)
        {
            try
            {
                string query = "DELETE FROM GIA WHERE Id_Gia = @idgia ";

                object[] para = new object[]
                {
                    idgia
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

        public bool DeleteBaseTour(string idtour)
        {
            try
            {
                string query = "DELETE FROM GIA WHERE Id_Tour = @idtour ";

                object[] para = new object[]
                {
                    idtour
                };
                DataProvider datapro = new DataProvider();
                if (datapro.ExecuteNonQuery(query, para) > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return false;
        }
        public bool Insert(GiaDTO gia)
        {
            try
            {
                string query = "INSERT INTO GIA values( @magia " +
                    ", @matour " +
                    ", @gia " +
                    ", @thoigianbatdau " +
                    ", @thoigianketthuc ) ";

                object[] para = new object[]
                {
                    gia.Id_Gia,
                    gia.Id_Tour,
                    gia.Gia,
                    gia.Thoigianbatdau,
                    gia.Thoigianketthuc
                };
                DataProvider datapro = new DataProvider();
                if (datapro.ExecuteNonQuery(query, para) > 0)
                    return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return false;
        }
        public int Count()
        {
            string query = "select count(*) from GIA";
            DataProvider datapro = new DataProvider();
            int count = (int)datapro.ExecuteScalar(query);
            return count;
        }
        public int Exist(String id)
        {
            string query = "select count(*) from GIA where Id_Gia = '" + id + "'";
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
                if(count < 10 )
                id = "G0" + count;
                else id = "G" + count;
                if (Exist(id) == 0)
                    break;
                else count++;
            }
            return id;
        }
    }
}
