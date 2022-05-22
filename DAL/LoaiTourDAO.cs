using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data;
using System.Windows.Forms;
namespace DAL
{
    public class LoaiTourDAO
    {
        public LoaiTourDAO() { }

        public List<LoaiTourDTO> ListAll()
        {

            DataProvider datapro = new DataProvider();

            List<LoaiTourDTO> tours = new List<LoaiTourDTO>();
            string query = "Select * from LOAITOUR";

            DataTable data = datapro.ExecuteQuery(query);
            try
            {
                foreach (DataRow item in data.Rows)
                {
                    string maloai = item["Id_Loai"].ToString();
                    string tenloai = item["Ten_Loai"].ToString();

                    LoaiTourDTO newTour = new LoaiTourDTO(maloai, tenloai);

                    tours.Add(newTour);
                }
                return tours;
            }
            catch (Exception e)
            {

            }
            return tours;
        }
        public string  getID(string tenloai)
        {

            DataProvider datapro = new DataProvider();
            string query = "Select Id_Loai from LOAITOUR where Ten_Loai = @tenloai";
            object[] para = new object[]
            {
                tenloai
            };
            string maloai = " ";
            var firstColumn = datapro.ExecuteScalar(query,para);
            if (firstColumn != null)
            {
                maloai = firstColumn.ToString();
            }
            return maloai;
        }
        public string getName(string idloai)
        {

            DataProvider datapro = new DataProvider();
            string query = "Select Ten_Loai from LOAITOUR where Id_Loai = @idloai";
            object[] para = new object[]
            {
                idloai
            };
            string tenloai = " ";
            var firstColumn = datapro.ExecuteScalar(query, para);
            if (firstColumn != null)
            {
                tenloai = firstColumn.ToString();
            }
            return tenloai;
        }
        public int Count()
        {
            string query = "select count(*) from LOAITOUR";
            DataProvider datapro = new DataProvider();
            int count = (int)datapro.ExecuteScalar(query);
            return count;
        }
        public int Exist(String id)
        {
            string query = "select count(*) from LOAITOUR where Id_Loai = " + id;
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
                id = "L" + count;
                if (Exist(id) == 0)
                    break;
                else count++;
            }
            return id;
        }
    }
}
