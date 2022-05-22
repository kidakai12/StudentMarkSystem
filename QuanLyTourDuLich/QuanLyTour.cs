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
    public partial class QuanLyTour : Form
    {
        List<TourDTO> list;
        List<LoaiTourDTO> listloai;
        public QuanLyTour()
        {
            InitializeComponent();
            list = new TourBUS().List();
            listloai = new LoaiTourBUS().List();
            Grid_Danhsachtour.AutoGenerateColumns = false;
            List<string> listtype = new List<string> { "Mã Tour", "Tên Tour"};
            SearchBox_cb.DataSource = listtype;
            BindGrid(list);
        }

        //QUẢN LÝ TOUR ====================================================================================================================
        //Hàm lấy danh sách
        public void BindGrid(List<TourDTO> list)
        {
            Grid_Danhsachtour.Rows.Clear();
            Grid_Danhsachtour.Refresh();
            foreach (TourDTO item in list)
            {
                if (item.Tinh_Trang == 1)
                {
                    string tenloai = listloai.Find(x => x.Id_Loai.Equals(item.Id_Loai)).Ten_Loai;
                    Grid_Danhsachtour.Rows.Add(item.Id_Tour, item.Ten_Tour, item.Dacdiem_Tour, tenloai);
                }
            }
        }

        //Button thêm 
        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new QuanLyTour_Them(list, listloai))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.list = form.list;
                    BindGrid(list);
                }
            }
        }

        //Button Sửa 
        private void button2_Click(object sender, EventArgs e)
        {
            if (Grid_Danhsachtour.RowCount != 0)
            {
                int selectedrowindex = Grid_Danhsachtour.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Danhsachtour.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Id_Tour"].Value);
                using (var form = new QuanLyTour_Sua(list, listloai, cellValue))
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

        //Button Xóa 
        private void button3_Click(object sender, EventArgs e)
        {
            if (Grid_Danhsachtour.RowCount != 0)
            {
                int selectedrowindex = Grid_Danhsachtour.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Danhsachtour.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Id_Tour"].Value);
                    if (new TourBUS().Delete(cellValue))
                    {
                        MessageBox.Show("Xóa thành công");
                        list.RemoveAll(x => x.Id_Tour.Equals(cellValue));
                        BindGrid(list);
                    }
            }
        }

        //Button Chi tiết 
        private void button4_Click(object sender, EventArgs e)
        {
            if (Grid_Danhsachtour.RowCount != 0)
            {
                int selectedrowindex = Grid_Danhsachtour.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Danhsachtour.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Id_Tour"].Value);
                if (cellValue != null)
                {
                    QuanLyChiTietTour ql_ctt = new QuanLyChiTietTour(cellValue);
                    ql_ctt.ShowDialog();
                }
            }
        }

        //Button Reload 
        private void button5_Click(object sender, EventArgs e)
        {
            BindGrid(list);
        }

        //Other ===========================================================================================================================

        private void SearchTour_txt_TextChanged(object sender, EventArgs e)
        {
            string typesearch = SearchBox_cb.SelectedItem.ToString();
            string searchkey = new Tool().RemoveUnicodeBus(SearchTour_txt.Text.ToLower());
            List<TourDTO> listsearch = new List<TourDTO>();
            switch (typesearch)
            {
                case "Mã Tour":
                    listsearch = list.FindAll(x => x.Id_Tour.ToLower().Contains(searchkey));
                    break;
                case "Tên Tour":
                    listsearch = list.FindAll(x => new Tool().RemoveUnicodeBus(x.Ten_Tour.ToLower()).Contains(searchkey));
                    break;
                default:
                    break;
            }
            BindGrid(listsearch);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Grid_Danhsachtour.RowCount != 0)
            {
                int selectedrowindex = Grid_Danhsachtour.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Danhsachtour.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Id_Tour"].Value);
                if (cellValue != null)
                {
                    ThongKe ql_ctt = new ThongKe(cellValue);
                    ql_ctt.ShowDialog();
                }
            }
        }
    }
}
