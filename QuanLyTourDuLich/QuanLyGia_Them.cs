using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
namespace QuanLyTourDuLich
{
    public partial class QuanLyGia_Them : Form
    {
        public List<GiaDTO> list { get; set; }
        public QuanLyGia_Them(List<GiaDTO> list, List<TourDTO> listtour)
        {
            InitializeComponent();
            this.list = list;
            txtGia.Text = new GiaBUS().MakeID();
            foreach (TourDTO item in listtour)
            {
                TourView.Rows.Add(item.Id_Tour,item.Ten_Tour,item.Dacdiem_Tour);
            }
        }

        private void TourView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = TourView.SelectedRows[0].Index;
            DataGridViewRow selectedRow = TourView.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Id_Tour"].Value);
            txtTour.Text = cellValue;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string magia = txtGia.Text;
            string matour = txtTour.Text;
            string gia = numGia.Text;
            long giatour = long.Parse(gia);
            string ngaybatdau = txtNgayKhoiHanh.Text;
            string ngayketthuc = txtNgayKetThuc.Text;
            DateTime dt = DateTime.ParseExact(ngaybatdau, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            DateTime dt1 = DateTime.ParseExact(ngayketthuc, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            int result = DateTime.Compare(dt, dt1);
            if (result > 0)
            {
                MessageBox.Show("Thời gian kết thúc không được sớm hơn thời gian khởi hành");
                return;
            }
            else if (result == 0)
            {
                MessageBox.Show("Thời gian khởi hành không được trùng với thời gian kết thúc");
                return;
            }
            if (matour.Equals(null) || matour.Equals(""))
            {
                MessageBox.Show("Vui lòng Chọn tour trong bảng");
                return;
            }
            if (giatour < 100000)
            {
                MessageBox.Show("Vui lòng nhập giá lớn hơn 100000 VNĐ ");
                return;
            }
            if (new GiaBUS().Insert(new GiaDTO(magia,matour,gia,ngaybatdau,ngayketthuc)))
            {
                MessageBox.Show("Thêm thành công");
                this.list.Add(new GiaDTO(magia, matour, gia, ngaybatdau, ngayketthuc));
                this.DialogResult = DialogResult.OK;
                Hide();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numGia_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
