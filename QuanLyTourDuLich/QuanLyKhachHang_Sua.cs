using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyTourDuLich
{
    public partial class QuanLyKhachHang_Sua : Form
    {
        public List<KhachDTO> list { get; set; }

        public QuanLyKhachHang_Sua(List<KhachDTO> list, String id)
        {
            InitializeComponent();
            this.list = list;
            KhachDTO item = this.list.Find(x => x.Id_Khach.Equals(id));
            txt_1.Text = id;
            txt_2.Text = item.Hoten_Khach;
            txt_3.Text = item.Cmnd_Khach;
            txt_4.Text = item.Diachi_Khach;
            if (item.Gioitinh_Khach.Equals("Nam"))
            {
                rbNam.Checked = true;
            }
            else
            {
                rbNu.Checked = true;
            }
            txt_6.Text = item.Sdt_Khach;
            txt_7.Text = item.Quoctich;            
        }


        private void btnSua_Click(object sender, EventArgs e)
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
            if (sdt.Length < 10)
            {
                MessageBox.Show("Số điện thoại phải có độ dài ít nhất là 10");
                return;
            }
            if (new KhachHangBUS().Update(new KhachDTO(maKH, hoten, cmnd, diachi, gioiTinh, sdt, quoctich, 1)))
            {
                MessageBox.Show("Sửa thành công");
                list.Find(x => x.Id_Khach.Equals(maKH)).Hoten_Khach = hoten;
                list.Find(x => x.Id_Khach.Equals(maKH)).Cmnd_Khach = cmnd;
                list.Find(x => x.Id_Khach.Equals(maKH)).Diachi_Khach = diachi;
                list.Find(x => x.Id_Khach.Equals(maKH)).Gioitinh_Khach = gioiTinh;
                list.Find(x => x.Id_Khach.Equals(maKH)).Sdt_Khach = sdt;
                list.Find(x => x.Id_Khach.Equals(maKH)).Quoctich = quoctich;

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
