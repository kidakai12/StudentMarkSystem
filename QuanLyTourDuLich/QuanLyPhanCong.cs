using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyTourDuLich
{
    public partial class QuanLyPhanCong : Form
    {
        List<PhanCongDTO> list;
        public List<DoanDuLichDTO> list2;
        public List<NhanVienDTO> list3;

        public QuanLyPhanCong()
        {
            InitializeComponent();
            list = new PhanCongBUS().List();
            list2 = new DoanDuLichBUS().List();
            list3 = new NhanVienBUS().List();
            Grid_Danhsachphancong.AutoGenerateColumns = false;
            List<string> listtype = new List<string> { "Mã Đoàn", "Mã Nhân viên", "Nhiệm vụ" };
            SearchBox_cb.DataSource = listtype;
            BindGrid(list);
        }

        public void BindGrid(List<PhanCongDTO> list)
        {
            Grid_Danhsachphancong.Rows.Clear();
            Grid_Danhsachphancong.Refresh();
            foreach (PhanCongDTO item in list)
            {
                Grid_Danhsachphancong.Rows.Add(item.Id_Doan, item.Id_NV, item.Nhiemvu);
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            using (var form = new QuanLyPhanCong_Them(list, list2, list3))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    list = form.list;
                    BindGrid(list);
                }
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (Grid_Danhsachphancong.SelectedCells.Count > 0)
            {
                int selectedrowindex = Grid_Danhsachphancong.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Danhsachphancong.Rows[selectedrowindex];
                string cellValue1 = Convert.ToString(selectedRow.Cells["Id_Doan"].Value);
                string cellValue2 = Convert.ToString(selectedRow.Cells["Id_NV"].Value);

                using (var form = new QuanLyPhanCong_Sua(list, list2, list3, cellValue1, cellValue2))
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

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (Grid_Danhsachphancong.SelectedCells.Count > 0)
            {
                int selectedrowindex = Grid_Danhsachphancong.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Danhsachphancong.Rows[selectedrowindex];
                string cellValue1 = Convert.ToString(selectedRow.Cells["Id_Doan"].Value);
                string cellValue2 = Convert.ToString(selectedRow.Cells["Id_NV"].Value);

                if (new PhanCongBUS().Delete(cellValue1, cellValue2))
                {
                    MessageBox.Show("Xóa thành công");
                    list.RemoveAll(x => x.Id_Doan.Equals(cellValue1) && x.Id_NV.Equals(cellValue2));
                    BindGrid(list);
                }

            }
        }

        private void BtnReload_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            list = new PhanCongBUS().List();
            BindGrid(list);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
            List<PhanCongDTO> listsearch = new List<PhanCongDTO>();
            switch (typesearch)
            {
                case "Mã Đoàn":
                    listsearch = list.FindAll(x => x.Id_Doan.Contains(searchkey));
                    break;
                case "Mã Nhân viên":
                    listsearch = list.FindAll(x => x.Id_NV.Contains(searchkey));
                    break;
                case "Nhiệm vụ":
                    listsearch = list.FindAll(x => x.Nhiemvu.Contains(searchkey));
                    break;
                default:
                    break;
            }
            BindGrid(listsearch);
        }
    }
}
