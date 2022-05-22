using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;
namespace QuanLyTourDuLich
{
    public partial class QuanLyDoan : Form
    {
        List<DoanDuLichDTO> list;
        List<TourDTO> listTenTour;
        public QuanLyDoan()
        {
            InitializeComponent();
            Tool tool = new Tool();
            list = new DoanDuLichBUS().List().FindAll(x => tool.comparetoday(x.Ngayketthuc) <= 0);
            listTenTour = new TourBUS().List();
            Grid_Danhsachdoan.AutoGenerateColumns = false;
            BindGrid(list);
        }
        public void BindGrid(List<DoanDuLichDTO> list)
        {
            Grid_Danhsachdoan.Rows.Clear();
            Grid_Danhsachdoan.Refresh();
            foreach (DoanDuLichDTO item in list)
            {
                string tentour = listTenTour.Find(x => x.Id_Tour.Equals(item.Id_Tour)).Ten_Tour;
                Grid_Danhsachdoan.Rows.Add(item.Id_Doan, 
                    item.Ten_Doan, 
                    tentour, 
                    item.Ngaykhoihanh, 
                    item.Ngayketthuc, 
                    item.Doanhthu.ToString("#,#")+" VNĐ", 
                    item.Noidung,
                    item.Id_Tour);
            }
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var form = new QuanLyDoan_Them(list, listTenTour))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.list = form.list;
                    BindGrid(list);
                }
            }
        }

        
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (Grid_Danhsachdoan.RowCount != 0)
            {
                int selectedrowindex = Grid_Danhsachdoan.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Danhsachdoan.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Id_Doan"].Value);
                string dt1 = Convert.ToString(selectedRow.Cells["NgayKhoiHanh"].Value);
                string dt2 = Convert.ToString(selectedRow.Cells["NgayKetThuc"].Value);
                Tool tool = new Tool();
                if (tool.comparetoday(dt1) < 0 && tool.comparetoday(dt2) > 0)
                {
                    MessageBox.Show("Đoàn này đang hoạt động");
                }
                else if (tool.comparetoday(dt2) < 0)
                {
                    MessageBox.Show("Đoàn này đã ngưng hoạt động");
                }
                else
                {
                    using (var form = new QuanLyDoan_Sua(list, listTenTour, cellValue))
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
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int selectedrowindex = Grid_Danhsachdoan.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = Grid_Danhsachdoan.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Id_Doan"].Value);

            try
            {
                if (new DoanDuLichBUS().Delete(cellValue))
                {
                    MessageBox.Show("Xóa thành công");
                    list.RemoveAll(x => x.Id_Doan.Equals(cellValue));
                    BindGrid(list);
                } else
                {
                    MessageBox.Show("Đoàn này không được xóa vì đã có khách hàng");
                }
            }
            catch (SqlException e1) when (e1.Number == 547)
            {

                MessageBox.Show("Đoàn này không được xóa vì đã có khách hàng");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            BindGrid(list);
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtTimKiem.Text;
            List<DoanDuLichDTO> listsearch = new List<DoanDuLichDTO>();
            listsearch = list.FindAll(x => x.Ten_Doan.Contains(search));
            BindGrid(listsearch);
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (Grid_Danhsachdoan.RowCount != 0)
            {
                int selectedrowindex = Grid_Danhsachdoan.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Danhsachdoan.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Id_Doan"].Value);
                string idtour = Convert.ToString(selectedRow.Cells["Id_Tour"].Value);
                string cellValueNgayKhoiHanh = Convert.ToString(selectedRow.Cells["NgayKhoiHanh"].Value);
                string gia = new DoanDuLichBUS().getGiaTour(cellValueNgayKhoiHanh, idtour);
                if (!gia.Equals(""))
                {
                    if (cellValue != null)
                    {
                        QuanLyChiTietDoan ql_ctd = new QuanLyChiTietDoan(cellValue, gia);
                        ql_ctd.ShowDialog();
                    }
                }
                
            }
            list = new DoanDuLichBUS().List();
            BindGrid(list);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
