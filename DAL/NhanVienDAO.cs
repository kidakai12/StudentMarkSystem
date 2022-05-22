using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DTO;

namespace DAL
{
    public class NhanVienDAO
    {
        DataProvider dataProvider = new DataProvider();
        public NhanVienDAO() { }

        public List<NhanVienDTO> ListAll()
        {

            List<NhanVienDTO> nhanVien = new List<NhanVienDTO>();
            try
            {
                string query = "Select * from NHANVIEN where Tinh_Trang = 1";

                DataTable data = dataProvider.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    string maNhanVien = item["Id_NV"].ToString();
                    string hoTenNhanVien = item["Hoten_NV"].ToString();
                    string email = item["Email_NV"].ToString();
                    string sdt = item["Sdt_NV"].ToString();
                    string gioiTinh = item["Gioitinh_NV"].ToString();
                    int tinhTrang = 1;

                    NhanVienDTO newNhanVien = new NhanVienDTO(maNhanVien, hoTenNhanVien, email, sdt, gioiTinh, tinhTrang);

                    nhanVien.Add(newNhanVien);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi DB tại ListAll " + e);
            }

            return nhanVien;
        }

        public List<NhanVienDTO> ListAllDuocPhanCong()
        {

            List<NhanVienDTO> nhanVien = new List<NhanVienDTO>();
            try
            {
                string query = "Select NHANVIEN.Id_NV, Hoten_NV, Email_NV, Sdt_NV, Gioitinh_NV, Tinh_Trang from NHANVIEN, PHANCONG where NHANVIEN.Id_NV = PHANCONG.Id_NV and Tinh_Trang = 1";

                using (DataTable data = dataProvider.ExecuteQuery(query))
                {

                    foreach (DataRow item in data.Rows)
                    {
                        string maNhanVien = item["Id_NV"].ToString();
                        string hoTenNhanVien = item["Hoten_NV"].ToString();
                        string email = item["Email_NV"].ToString();
                        string sdt = item["Sdt_NV"].ToString();
                        string gioiTinh = item["Gioitinh_NV"].ToString();
                        int tinhTrang = 1;

                        NhanVienDTO newNhanVien = new NhanVienDTO(maNhanVien, hoTenNhanVien, email, sdt, gioiTinh, tinhTrang);

                        nhanVien.Add(newNhanVien);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi DB tại ListAll " + e);
            }

            return nhanVien;
        }

        public List<NhanVienDTO> ListAllChuaPhanCong()
        {

            List<NhanVienDTO> nhanVien = new List<NhanVienDTO>();
            try
            {
                string query = "Select NHANVIEN.Id_NV, Hoten_NV, Email_NV, Sdt_NV, Gioitinh_NV, Tinh_Trang from NHANVIEN where not exists (select NHANVIEN.Id_NV from PHANCONG where NHANVIEN.Id_NV = PHANCONG.Id_NV ) and Tinh_Trang = 1 ";

                using (DataTable data = dataProvider.ExecuteQuery(query))
                {

                    foreach (DataRow item in data.Rows)
                    {
                        string maNhanVien = item["Id_NV"].ToString();
                        string hoTenNhanVien = item["Hoten_NV"].ToString();
                        string email = item["Email_NV"].ToString();
                        string sdt = item["Sdt_NV"].ToString();
                        string gioiTinh = item["Gioitinh_NV"].ToString();
                        int tinhTrang = 1;

                        NhanVienDTO newNhanVien = new NhanVienDTO(maNhanVien, hoTenNhanVien, email, sdt, gioiTinh, tinhTrang);

                        nhanVien.Add(newNhanVien);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi DB tại ListAll " + e);
            }

            return nhanVien;
        }

        public bool Update(NhanVienDTO nhanVien)
        {
            string query = "update NHANVIEN set " +
                "Hoten_NV = @HOTEN , " +
                "Email_NV = @EMAIL , " +
                "Sdt_NV = @SDT ," +
                "Gioitinh_NV = @GIOITINH , " +
                "Tinh_Trang = @TINHTRANG " +
                "where Id_NV = @oldMANV";

            object[] para = new object[]
            {
                nhanVien.Hoten_NV,
                nhanVien.Email_NV,
                nhanVien.Sdt_NV,
                nhanVien.Gioitinh_NV,
                nhanVien.Tinh_Trang,
                nhanVien.Id_NV
            };
            try
            {
                DataProvider dataProvider = new DataProvider();
                if (dataProvider.ExecuteNonQuery(query, para) > 0)
                    return true;
            }
            catch (Exception e) { }
            return false;
        }

        public bool Insert(NhanVienDTO nhanVien)
        {
            string query = "insert into NHANVIEN " +
                "values( @MANV , @HOTEN , @EMAIL , @SDT , @GIOITINH , @TINHTRANG )";
            object[] para = new object[]
            {
                nhanVien.Id_NV,
                nhanVien.Hoten_NV,
                nhanVien.Email_NV,
                nhanVien.Sdt_NV,
                nhanVien.Gioitinh_NV,
                nhanVien.Tinh_Trang
            };
            try
            {
                DataProvider dataProvider = new DataProvider();
                if (dataProvider.ExecuteNonQuery(query, para) > 0)
                    return true;
            }
            catch (Exception e) { }
            return false;
        }

        public bool Delete(string id)
        {
            string queryTimMaNhanVienTrongBangPhanCong = "select * from NHANVIEN , PHANCONG " +
                "where NHANVIEN.Id_NV = @MANV and PHANCONG.Id_NV = NHANVIEN.Id_NV ";
            object[] para = new object[]
            {
                id
            };

            string query = "update NHANVIEN set Tinh_Trang = 0 where Id_NV = @MANV";
            try
            {
                DataProvider dataProvider = new DataProvider();
                if (dataProvider.ExecuteNonQuery(queryTimMaNhanVienTrongBangPhanCong, para) > 0)
                {
                    return false;
                }
                else
                {
                    if (dataProvider.ExecuteNonQuery(query, para) > 0)
                        return true;
                }
            }
            catch (Exception e)
            {

            }
            return false;
        }
        public int Count()
        {
            string query = "select count(*) from NHANVIEN";
            DataProvider dataProvider = new DataProvider();
            int count = (int)dataProvider.ExecuteScalar(query);
            return count;
        }
        public int Exist(string id)
        {
            string query = "select count(*) from NHANVIEN where Id_NV = '" + id + "'";
            DataProvider dataProvider = new DataProvider();
            int count = (int)dataProvider.ExecuteScalar(query);
            return count;
        }
        public string MakeID()
        {
            int count = Count();
            string id;
            while (true)
            {
                if(count < 10)
                id = "NV0" + count;
                else id = "NV" + count;
                if (Exist(id) == 0)
                    break;
                else count++;
            }
            return id;
        }
    }
}
