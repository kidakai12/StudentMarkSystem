using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;
using DTO;

namespace DAL
{
    public class KhachHangDAO
    {
        public KhachHangDAO() { }

        public List<KhachDTO> ListAll()
        {
            DataProvider dataProvider = new DataProvider();

            List<KhachDTO> khachHang = new List<KhachDTO>();
            string query = "Select * from KHACH where Tinh_Trang = '1'";

            try
            {
                DataTable data = dataProvider.ExecuteQuery(query);

                foreach (DataRow item in data.Rows)
                {
                    string maKH = item["Id_Khach"].ToString();
                    string hoTenKH = item["Hoten_Khach"].ToString();
                    string cmndKH = item["Cmnd_Khach"].ToString();
                    string diachiKH = item["Diachi_Khach"].ToString();
                    string gioitinhKH = item["Gioitinh_Khach"].ToString();
                    string sdtKH = item["Sdt_Khach"].ToString();
                    string quoctichKH = item["Quoctich"].ToString();

                    int tinhtrang = 0;

                    KhachDTO newKhachHang = new KhachDTO(maKH, hoTenKH, cmndKH, diachiKH, gioitinhKH, sdtKH, quoctichKH, tinhtrang);

                    khachHang.Add(newKhachHang);
                }
            }catch (Exception ex)
            {
                //Hiển thị lỗi trong Immediate Window
                Debug.WriteLine(ex.Message);
            }

            return khachHang;
        }
       
        public bool Update(KhachDTO khachHang)
        {
            string query = "update KHACH set " +
                "Hoten_Khach = @HOTEN , " +
                "Cmnd_Khach = @CMND , " +
                "Diachi_Khach = @DIACHI ," +
                "Gioitinh_Khach = @GIOITINH , " +
                "Sdt_Khach = @SDT , " +
                "Quoctich = @QUOCTICH " +
           //     "Tinh_Trang = @TINHTRANG" + 
                "where Id_Khach = @oldMAKH";

            object[] para = new object[]
            {
                khachHang.Hoten_Khach,
                khachHang.Cmnd_Khach,
                khachHang.Diachi_Khach,
                khachHang.Gioitinh_Khach,
                khachHang.Sdt_Khach,
                khachHang.Quoctich,
                khachHang.Id_Khach
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

        public bool Insert(KhachDTO khachHang)
        {
            string query = "insert into KHACH " +
                "values( @MAKH , @HOTEN , @CMND , @DIACHI , @GIOITINH , @SDT , @QUOCTICH , @TINHTRANG )";

            object[] para = new object[]
            {
                khachHang.Id_Khach,
                khachHang.Hoten_Khach,
                khachHang.Cmnd_Khach,
                khachHang.Diachi_Khach,
                khachHang.Gioitinh_Khach,
                khachHang.Sdt_Khach,
                khachHang.Quoctich,
                khachHang.Tinh_Trang
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

        public bool Delete(string id)
        {
            string query = "update KHACH set Tinh_Trang = 0 where Id_Khach = @MAKH";

            object[] para = new object[]
            {
                id
            };
            DataProvider dataProvider = new DataProvider();
            try
            {
                if (dataProvider.ExecuteNonQuery(query, para) > 0)
                    return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return false;
        }

        public int Count()
        {
            string query = "select count(*) from KHACH";
            int count = 0;
            try
            {
                DataProvider dataProvider = new DataProvider();
                count = (int)dataProvider.ExecuteScalar(query);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return count;
        }
        public int Exist(string id)
        {
            string query = "select count(*) from KHACH where Id_Khach = '" + id + "'";
            int count = 0;
            try
            {
                DataProvider dataProvider = new DataProvider();
                count = (int)dataProvider.ExecuteScalar(query);
            }
            catch (Exception ex) { 
            }
            
            return count;
        }

        public string MakeID()
        {
            int count = Count() + 1;
            string id;
            while (true)
            {
                if(count <10)
                id = "KH0" + count;
                else id = "KH" + count;
                if (Exist(id) == 0)
                    break;
                else count++;
            }
            return id;
        }
    }
}
