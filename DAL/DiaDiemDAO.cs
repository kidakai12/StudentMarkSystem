using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DTO;
using System.Windows.Forms;

namespace DAL
{
    public class DiaDiemDAO
    {
        public DiaDiemDAO() { }

        public List<DiaDiemDTO> ListAll()
        {
            DataProvider datapro = new DataProvider();

            List<DiaDiemDTO> diadiems = new List<DiaDiemDTO>();
            string query = "Select * from DIADIEM";

            DataTable data = datapro.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string iddiadiem = item["Id_DiaDiem"].ToString();
                string tendiadiem = item["Ten_DiaDiem"].ToString();

                DiaDiemDTO newDiaDiem = new DiaDiemDTO(iddiadiem, tendiadiem);

                diadiems.Add(newDiaDiem);
            }
            return diadiems;
        }

        public List<DiaDiemDTO> List(string search)
        {
            DataProvider datapro = new DataProvider();

            List<DiaDiemDTO> diadiems = new List<DiaDiemDTO>();
            string query = "Select * from DIADIEM where Id_DiaDiem LIKE '%" + search + "%'";
            DataTable data = datapro.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string iddiadiem = item["Id_DiaDiem"].ToString();
                string tendiadiem = item["Ten_DiaDiem"].ToString();

                DiaDiemDTO newDiaDiem = new DiaDiemDTO(iddiadiem, tendiadiem);

                diadiems.Add(newDiaDiem);
            }
            return diadiems;
        }

        public List<DiaDiemDTO> ListSearch(string search)
        {
            DataProvider datapro = new DataProvider();

            List<DiaDiemDTO> diadiems = new List<DiaDiemDTO>();
            string query = "Select * from DIADIEM where Id_DiaDiem = " + search;
            DataTable data = datapro.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                string iddiadiem = item["Id_DiaDiem"].ToString();
                string tendiadiem = item["Ten_DiaDiem"].ToString();

                DiaDiemDTO newDiaDiem = new DiaDiemDTO(iddiadiem, tendiadiem);

                diadiems.Add(newDiaDiem);
            }
            return diadiems;
        }

        public DiaDiemDTO getDiaDiem(string search)
        {
            DataProvider datapro = new DataProvider();

            List<DiaDiemDTO> tours = new List<DiaDiemDTO>();
            string query = "Select * from DIADIEM where Id_DiaDiem = " + search;
            DataTable data = datapro.ExecuteQuery(query);
            DiaDiemDTO newDiaDiem = new DiaDiemDTO();
            foreach (DataRow item in data.Rows)
            {
                string iddiadiem = item["Id_DiaDiem"].ToString();
                string tendiadiem = item["Ten_DiaDiem"].ToString();

                newDiaDiem = new DiaDiemDTO(iddiadiem, tendiadiem);
            }
            return newDiaDiem;
        }

        public DiaDiemDTO get(string id)
        {
            DataProvider datapro = new DataProvider();

            DiaDiemDTO newDiaDiem = new DiaDiemDTO();
            string query = "Select * from DIADIEM where Id_DiaDiem = @id";
            object[] para = new object[]
            {
               id
            };
            DataTable data = datapro.ExecuteQuery(query, para);

            foreach (DataRow item in data.Rows)
            {
                string iddiadiem = item["Id_DiaDiem"].ToString();
                string tendiadiem = item["Ten_DiaDiem"].ToString();

                newDiaDiem = new DiaDiemDTO(iddiadiem, tendiadiem);
            }
            return newDiaDiem;
        }

        public bool Update(DiaDiemDTO diadiem)
        {
            string query = "update dbo.DIADIEM set " +
                "Ten_DiaDiem = @TENDIADIEM  " +
                "where Id_DiaDiem = @oldMADIADIEM ";

            object[] para = new object[]
            {
                diadiem.Ten_DiaDiem,
                diadiem.Id_DiaDiem
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

        public bool Insert(DiaDiemDTO diadiem)
        {
            string query = "insert into DIADIEM " +
                "values( @MADIADIEM , @TENDIADIEM )";

            object[] para = new object[]
            {
                diadiem.Id_DiaDiem,
                diadiem.Ten_DiaDiem
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

        public bool Delete(string id)
        {
            string query = "delete from DIADIEM where Id_DiaDiem = @MADIADIEM ";
            //string query2 = "delete from CHITIETDIADIEM where Id_DiaDiem = @MADIADIEM";
            object[] para = new object[]
            {
                id
            };
            DataProvider datapro = new DataProvider();
            //datapro.ExecuteNonQuery(query2, para);
            try
            {
                if (datapro.ExecuteNonQuery(query, para) > 0)
                    return true;
            }
            catch (Exception e) { }
            return false;
        }

        public int Count()
        {
            string query = "select count(*) from DIADIEM";
            DataProvider datapro = new DataProvider();
            int count = (int)datapro.ExecuteScalar(query);
            return count;
        }
        public int Exist(String id)
        {
            string query = "select count(*) from DIADIEM where Id_DiaDiem = '" + id + "'";
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
                id = "DD0" + count;
                else id = "DD" + count;
                if (Exist(id) == 0)
                    break;
                else count++;
            }
            return id;
        }

    }
}
