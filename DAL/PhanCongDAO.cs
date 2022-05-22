using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using DTO;

namespace DAL
{
    public class PhanCongDAO
    {
        public PhanCongDAO() { }

        public List<PhanCongDTO> ListAll()
        {

            DataProvider dataProvider = new DataProvider();

            List<PhanCongDTO> phanCong = new List<PhanCongDTO>();
            string query = "select * from PHANCONG";

            try
            {
                DataTable data = dataProvider.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    string maDoan = item["Id_Doan"].ToString();
                    string maNhanVien = item["Id_NV"].ToString();
                    string nhiemVu = item["Nhiemvu"].ToString();

                    PhanCongDTO newPhanCong = new PhanCongDTO(maDoan, maNhanVien, nhiemVu);

                    phanCong.Add(newPhanCong);
                }
            }
            catch (Exception ex)
            {
                //Hiển thị lỗi trong Immediate Window
                Debug.WriteLine(ex.Message);
            }
            return phanCong;
        }
        public bool Update(PhanCongDTO phanCong, string oldId_Doan, string oldId_NV)
        {
            string query = "update PHANCONG set " +
                "Id_Doan = @MADOAN , " +
                "Id_NV = @MANHANVIEN , " +
                "Nhiemvu = @NHIEMVU " +
                "where Id_Doan = @oldMADOAN AND Id_NV = @oldMANHANVIEN ";

            object[] para = new object[]
            {
                phanCong.Id_Doan,
                phanCong.Id_NV,
                phanCong.Nhiemvu,
                oldId_Doan,
                oldId_NV
            };
            try
            {
                DataProvider dataProvider = new DataProvider();
                if (dataProvider.ExecuteNonQuery(query, para) > 0)
                    return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return false;
        }

        public bool Insert(PhanCongDTO phanCong)
        {
            string query = "insert into PHANCONG " +
                "values( @MADOAN , @MANHANVIEN , @NHIEMVU )";

            object[] para = new object[]
            {
                phanCong.Id_Doan,
                phanCong.Id_NV,
                phanCong.Nhiemvu
            };
            try
            {
                DataProvider dataProvider = new DataProvider();
                if (dataProvider.ExecuteNonQuery(query, para) > 0)
                    return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return false;
        }



        public bool Delete(string maDoan, string maNhanVien)
        {
            string query = "delete from PHANCONG where Id_Doan = @MADOAN AND Id_NV = @MANHANVIEN ";

            object[] para = new object[]
            {
                maDoan,
                maNhanVien
            };
            try
            {
                DataProvider dataProvider = new DataProvider();
                if (dataProvider.ExecuteNonQuery(query, para) > 0)
                    return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return false;
        }

        //Kiểm tra phân công có trùng thời gian không trước khi insert
        public string KiemTraTG(string maDoan, string maNhanVien)
        {
            string query = "select * from DOANDULICH,PHANCONG " +
                "where DOANDULICH.Id_Doan=PHANCONG.Id_Doan and " +
                "Id_NV = '" + maNhanVien + "' and " +
                "((Ngaykhoihanh >= (select Ngaykhoihanh from DOANDULICH where Id_Doan = '" + maDoan + "' ) and " +
                "Ngaykhoihanh <= (select Ngayketthuc from DOANDULICH where Id_Doan = '" + maDoan + "' )) or " +
                "(Ngayketthuc >= (select Ngaykhoihanh from DOANDULICH where Id_Doan = '" + maDoan + "' ) and " +
                "Ngayketthuc <= (select Ngayketthuc from DOANDULICH where Id_Doan = '" + maDoan + "' ))); ";

            string listD = "";

            try
            {
                DataProvider dataProvider = new DataProvider();
                DataTable dataTable = dataProvider.ExecuteQuery(query);
                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow item in dataTable.Rows)
                    {
                        string maDoanL = item["Id_Doan"].ToString();
                        listD += maDoanL + ", ";
                    }
                }
                listD = listD.Remove(listD.Length - 2);
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return listD;
            
        }
    }
}
