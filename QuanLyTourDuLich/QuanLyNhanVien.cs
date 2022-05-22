using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;
namespace QuanLyTourDuLich
{
    public partial class QuanLyNhanVien : Form
    {
        List<NhanVienDTO> listNhanVien;
        List<NhanVienDTO> listNhanVienDuocPhanCong, listNhanVienChuaPhanCong;
        public QuanLyNhanVien()
        {
            InitializeComponent();
            listNhanVien = new NhanVienBUS().List();
            listNhanVienDuocPhanCong = new NhanVienBUS().ListDuocPhanCong();
            listNhanVienChuaPhanCong = new NhanVienBUS().ListChuaPhanCong();
            Grid_Danhsachnhanvien.AutoGenerateColumns = false;
            List<string> listtype = new List<string> { "Mã NV", "Họ Tên", "Email", "SĐT" };
            cbSearchBox.DataSource = listtype;
            BindGrid(listNhanVien);
            rbTatCa.Checked = true;
        }

        //lấy danh sách tất cả nhân viên
        public void BindGrid(List<NhanVienDTO> list)
        {
            Grid_Danhsachnhanvien.Rows.Clear();
            Grid_Danhsachnhanvien.Refresh();
            foreach (NhanVienDTO item in list)
            {
                String tinhtrangnv = "";
                if (item.Tinh_Trang == 1) tinhtrangnv = "Còn hoạt động";
                else tinhtrangnv = "Không hoạt động";
                Grid_Danhsachnhanvien.Rows.Add(item.Id_NV, item.Hoten_NV, item.Email_NV, item.Sdt_NV, item.Gioitinh_NV, tinhtrangnv);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var form = new QuanLyNhanVien_Them(listNhanVien))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.listNhanVien = form.listNhanVien;
                    BindGrid(listNhanVien);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (Grid_Danhsachnhanvien.RowCount != 0)
            {
                int selectedrowindex = Grid_Danhsachnhanvien.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Danhsachnhanvien.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Id_NV"].Value);
                using (var form = new QuanLyNhanVien_Sua(listNhanVien, cellValue))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        this.listNhanVien = form.listNhanVien;
                        BindGrid(listNhanVien);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            List<NhanVienDTO> duocPhanCong = new List<NhanVienDTO>();
            int selectedrowindex = Grid_Danhsachnhanvien.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = Grid_Danhsachnhanvien.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Id_NV"].Value);
            duocPhanCong = listNhanVienDuocPhanCong.FindAll(x => x.Id_NV.Contains(cellValue));
            try
            {
                if (new NhanVienBUS().Delete(cellValue))
                {
                    MessageBox.Show("Xóa thành công");
                    listNhanVien.RemoveAll(x => x.Id_NV.Equals(cellValue));
                    BindGrid(listNhanVien);
                }
            }
            catch (SqlException e1) when (e1.Number == 547)
            {

                MessageBox.Show("Nhân viên này không được xóa vì đã được phân công");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            BindGrid(listNhanVien);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string typesearch = cbSearchBox.SelectedItem.ToString();
            string searchkey = txtSearch.Text;
            List<NhanVienDTO> listsearch = new List<NhanVienDTO>();
            switch (typesearch)
            {
                case "Mã NV":
                    listsearch = listNhanVien.FindAll(x => x.Id_NV.Contains(searchkey));
                    break;
                case "Họ Tên":
                    listsearch = listNhanVien.FindAll(x => x.Hoten_NV.Contains(searchkey));
                    break;
                case "Email":
                    listsearch = listNhanVien.FindAll(x => x.Email_NV.Contains(searchkey));
                    break;
                case "SĐT":
                    listsearch = listNhanVien.FindAll(x => x.Sdt_NV.Contains(searchkey));
                    break;
                default:
                    break;
            }
            BindGrid(listsearch);
        }

        private void rbTatCa_CheckedChanged(object sender, EventArgs e)
        {
            string typesearch = cbSearchBox.SelectedItem.ToString();
            string searchkey = txtSearch.Text;
            List<NhanVienDTO> listsearch = new List<NhanVienDTO>();
            listNhanVien = new NhanVienBUS().List();
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    switch (typesearch)
                    {
                        case "Mã NV":
                            listsearch = listNhanVien.FindAll(x => x.Id_NV.Contains(searchkey));
                            break;
                        case "Họ Tên":
                            listsearch = listNhanVien.FindAll(x => x.Hoten_NV.Contains(searchkey));
                            break;
                        case "Email":
                            listsearch = listNhanVien.FindAll(x => x.Email_NV.Contains(searchkey));
                            break;
                        case "SĐT":
                            listsearch = listNhanVien.FindAll(x => x.Sdt_NV.Contains(searchkey));
                            break;
                        default:
                            break;
                    }
                }
            }
            BindGrid(listsearch);
        }

        private void rbDaPhanCong_CheckedChanged(object sender, EventArgs e)
        {
            string typesearch = cbSearchBox.SelectedItem.ToString();
            string searchkey = txtSearch.Text;
            List<NhanVienDTO> listsearch = new List<NhanVienDTO>();
            listNhanVienDuocPhanCong = new NhanVienBUS().ListDuocPhanCong();
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    switch (typesearch)
                    {
                        case "Mã NV":
                            listsearch = listNhanVienDuocPhanCong.FindAll(x => x.Id_NV.Contains(searchkey));
                            break;
                        case "Họ Tên":
                            listsearch = listNhanVienDuocPhanCong.FindAll(x => x.Hoten_NV.Contains(searchkey));
                            break;
                        case "Email":
                            listsearch = listNhanVienDuocPhanCong.FindAll(x => x.Email_NV.Contains(searchkey));
                            break;
                        case "SĐT":
                            listsearch = listNhanVienDuocPhanCong.FindAll(x => x.Sdt_NV.Contains(searchkey));
                            break;
                        default:
                            break;
                    }
                }
            }
            BindGrid(listsearch);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Grid_Danhsachnhanvien.RowCount != 0)
            {
                int selectedrowindex = Grid_Danhsachnhanvien.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Danhsachnhanvien.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Id_NV"].Value);
                if (cellValue != null)
                {
                    ThongKeNhanVien ql_ctt = new ThongKeNhanVien(cellValue);
                    ql_ctt.ShowDialog();
                }
            }
        }

        private void rbChuaPhanCong_CheckedChanged(object sender, EventArgs e)
        {
            string typesearch = cbSearchBox.SelectedItem.ToString();
            string searchkey = txtSearch.Text;
            List<NhanVienDTO> listsearch = new List<NhanVienDTO>();
            listNhanVienChuaPhanCong = new NhanVienBUS().ListChuaPhanCong();
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    switch (typesearch)
                    {
                        case "Mã NV":
                            listsearch = listNhanVienChuaPhanCong.FindAll(x => x.Id_NV.Contains(searchkey));
                            break;
                        case "Họ Tên":
                            listsearch = listNhanVienChuaPhanCong.FindAll(x => x.Hoten_NV.Contains(searchkey));
                            break;
                        case "Email":
                            listsearch = listNhanVienChuaPhanCong.FindAll(x => x.Email_NV.Contains(searchkey));
                            break;
                        case "SĐT":
                            listsearch = listNhanVienChuaPhanCong.FindAll(x => x.Sdt_NV.Contains(searchkey));
                            break;
                        default:
                            break;
                    }
                }
            }
            BindGrid(listsearch);
        }

    }
}
