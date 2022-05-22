using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyTourDuLich
{
    public partial class QuanLyKhachHang : Form
    {
        List<KhachDTO> list;

        public QuanLyKhachHang()
        {
            InitializeComponent();
            list = new KhachHangBUS().List();
            Grid_Danhsachkhachhang.AutoGenerateColumns = false;
            List<string> listtype = new List<string> { "Mã Khách hàng", "Họ Tên", "CMND/CCCD",
                "Địa chỉ", "Giới tính", "Số điện thoại", "Quốc tịch"};
            SearchBox_cb.DataSource = listtype;
            BindGrid(list);
        }
        public void BindGrid(List<KhachDTO> list)
        {
            Grid_Danhsachkhachhang.Rows.Clear();
            Grid_Danhsachkhachhang.Refresh();
            foreach (KhachDTO item in list)
            {
                Grid_Danhsachkhachhang.Rows.Add(item.Id_Khach,item.Hoten_Khach, item.Cmnd_Khach
                    , item.Diachi_Khach, item.Gioitinh_Khach, item.Sdt_Khach, item.Quoctich);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var form = new QuanLyKhachHang_Them(list))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    list = form.list;
                    BindGrid(list);
                }
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (Grid_Danhsachkhachhang.SelectedCells.Count > 0)

            {
                int selectedrowindex = Grid_Danhsachkhachhang.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Danhsachkhachhang.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["IdKhach"].Value);

                using (var form = new QuanLyKhachHang_Sua(list, cellValue))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        this.list = form.list;
                        BindGrid(list);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Grid_Danhsachkhachhang.SelectedCells.Count > 0)
            {
                int selectedrowindex = Grid_Danhsachkhachhang.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Danhsachkhachhang.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["IdKhach"].Value);

                if (new KhachHangBUS().Delete(cellValue))
                {
                    MessageBox.Show("Xóa thành công");
                    list.RemoveAll(x => x.Id_Khach.Equals(cellValue));
                    BindGrid(list);
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            list = new KhachHangBUS().List();
            BindGrid(list);
        }


        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void SearchBox_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        public void Search()
        {
            string typesearch = SearchBox_cb.SelectedItem.ToString();
            string searchkey = txtSearch.Text;
            List<KhachDTO> listsearch = new List<KhachDTO>();

            switch (typesearch)
            {
                case "Mã Khách hàng":
                    listsearch = list.FindAll(x => x.Id_Khach.Contains(searchkey));
                    break;
                case "Họ Tên":
                    listsearch = list.FindAll(x => x.Hoten_Khach.Contains(searchkey));
                    break;
                case "CMND/CCCD":
                    listsearch = list.FindAll(x => x.Cmnd_Khach.Contains(searchkey));
                    break;
                case "Địa chỉ":
                    listsearch = list.FindAll(x => x.Diachi_Khach.Contains(searchkey));
                    break;
                case "Giới tính":
                    listsearch = list.FindAll(x => x.Gioitinh_Khach.Contains(searchkey));
                    break;
                case "Số điện thoại":
                    listsearch = list.FindAll(x => x.Sdt_Khach.Contains(searchkey));
                    break;
                case "Quốc tịch":
                    listsearch = list.FindAll(x => x.Quoctich.Contains(searchkey));
                    break;
                default:
                    break;
            }
            BindGrid(listsearch);
        }
    }
}
