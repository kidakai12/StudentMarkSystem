using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyTourDuLich
{
    public partial class QuanLyKhachHang_Them : Form
    {
        public List<KhachDTO> list { get; set; }

        public QuanLyKhachHang_Them(List<KhachDTO> list)
        {
            InitializeComponent();
            this.list = list;
            txt_1.Text = new KhachHangBUS().MakeID();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKH = txt_1.Text;
            string hoten = txt_2.Text;
            string cmnd = txt_3.Text;
            string diachi = txt_4.Text;
            string gioiTinh = "";
            if (rbNam.Checked)
                gioiTinh = "Nam";
            if (rbNu.Checked) 
                gioiTinh = "Nữ";
            string sdt = txt_6.Text;
            string quoctich = txt_7.Text;

            if (hoten.Equals("") || cmnd.Equals("") || diachi.Equals("") || gioiTinh.Equals("") || sdt.Equals("") || quoctich.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ");
                return;
            }

            if(sdt.Length < 10)
            {
                MessageBox.Show("Số điện thoại phải có độ dài ít nhất là 10");
                return;
            }

            if (new KhachHangBUS().Insert(new KhachDTO(maKH, hoten, cmnd, diachi, gioiTinh, sdt, quoctich, 1)))
            {
                MessageBox.Show("Thêm thành công");
                this.list.Add(new KhachDTO(maKH, hoten, cmnd, diachi, gioiTinh, sdt, quoctich, 1));
                this.DialogResult = DialogResult.OK;
                Hide();
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
