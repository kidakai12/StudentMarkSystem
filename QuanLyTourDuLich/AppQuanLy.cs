using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyTourDuLich
{
    public partial class AppQuanLy : Form
    {
        List<TourDTO> list;
        List<LoaiTourDTO> listloai;
        public AppQuanLy()
        {
            InitializeComponent();
            this.list = new TourBUS().List();
            this.listloai = new LoaiTourBUS().List();
            Grid_Danhsachtour.AutoGenerateColumns = false;
            List<string> listtype = new List<string> { "Mã Tour", "Tên Tour" };
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
                int selectedrowindex = Grid_Danhsachtour.SelectedRows[0].Index;
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

        //Button Thống kê
        private void button15_Click(object sender, EventArgs e)
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

        //Button Reload 
        private void button5_Click(object sender, EventArgs e)
        {
            BindGrid(list);
        }

        //LEFT MENU BAR ===================================================================================================================
        //Button chuyển trang Quản Lý Tour  
        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyTour());
        }

        //Button chuyển trang Quản Lý Nhân viên
        private void button14_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyNhanVien());
        }

        //Button chuyển trang Quản Lý Khách hàng
        private void button9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyKhachHang());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyDoan());
        }

        //Button chuyển trang Quản Lý Phân Công
        private void button12_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyPhanCong());
        }

        //Button chuyển trang Quản Lý Địa điểm
        private void button13_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyDiaDiem());
        }

        //Button chuyển trang Quản Lý Giá
        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyGia());
        }


        //Hàm xử lý chuyển trang ==========================================================================================================
        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        //Other ===========================================================================================================================
        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void Grid_Danhsachtour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
