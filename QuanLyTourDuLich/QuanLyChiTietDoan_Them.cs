using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Data.SqlClient;

namespace QuanLyTourDuLich
{
    public partial class QuanLyChiTietDoan_Them : Form
    {
        
        public List<ChiTietDoanDTO> list { get; set; }
        List<KhachDTO> listkhach = new List<KhachDTO>();
        string gia;
        public QuanLyChiTietDoan_Them(List<ChiTietDoanDTO> list, List<KhachDTO> listkhach, string id, string gia)
        {
            InitializeComponent();
            this.list = list;
            this.listkhach = listkhach;
            cbHoTen.Items.Clear();
            foreach (KhachDTO item in listkhach)
            {
                cbHoTen.Items.Add(item.Hoten_Khach);
            }
            cbHoTen.SelectedItem = listkhach[0].Hoten_Khach;
            txtMaKhach.Text = listkhach[0].Id_Khach;
            txtCMND.Text = listkhach[0].Cmnd_Khach;
            txtMaDoan.Text = id;
            this.gia = gia;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string madoan = txtMaDoan.Text;
            string makhach = txtMaKhach.Text;
            if (cbHoTen.ValueMember == null)
            {
                MessageBox.Show("Vui lòng nhập họ tên khách");
                return;
            }
            try
            {
                if (new ChiTietDoanBUS().Insert(new ChiTietDoanDTO(madoan, makhach)))
                {
                    MessageBox.Show("Thêm thành công");
                    new DoanDuLichBUS().UpdateDoanhThu(madoan, -long.Parse(gia));
                    this.list.Add(new ChiTietDoanDTO(madoan, makhach));
                    this.DialogResult = DialogResult.OK;
                    Hide();
                }
            }
            catch (SqlException e1) when (e1.Number == 2627)
            {
                MessageBox.Show("Không thể thêm khách hàng này vì đoàn này đã có khách hàng này");
                Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbMaKhach_DropDownClosed(object sender, EventArgs e)
        {
            if (cbHoTen.ValueMember != null)
            {
                string strHoTenKhach = cbHoTen.SelectedItem.ToString();
                string strId_Khach = listkhach.Find(x => x.Hoten_Khach.Equals(strHoTenKhach)).Id_Khach;
                string strCMND_Khach = listkhach.Find(x => x.Hoten_Khach.Equals(strHoTenKhach)).Cmnd_Khach;
                txtMaKhach.Text = strId_Khach;
                txtCMND.Text = strCMND_Khach;
            }
        }
    }
}
