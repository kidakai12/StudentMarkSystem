using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace QuanLyTourDuLich
{
    public partial class QuanLyNhanVien_Them : Form
    {
        public List<NhanVienDTO> listNhanVien { get; set; }
        public QuanLyNhanVien_Them(List<NhanVienDTO> list)
        {
            InitializeComponent();
            this.listNhanVien = list;
            txtMaNV.Text = new NhanVienBUS().MakeID();
            rbNam.Checked = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string hotenNV = txtHoTen.Text;
            string email = txtEmail.Text;
            string sdt = txtSDT.Text;
            string gioiTinh;
            if (rbNam.Checked)
                gioiTinh = "Nam";
            else
                gioiTinh = "Nữ";
            if (hotenNV.Equals("") | email.Equals("") | sdt.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ");
                return;

            }

            if (sdt.Length < 10)
            {
                MessageBox.Show("Vui lòng nhập lại số điện thoại");
                return;
            }

            if (IsValidEmail(email) == false)
            {
                MessageBox.Show("Vui lòng nhập lại email");
                return;
            }

            if (new NhanVienBUS().Insert(new NhanVienDTO(maNV, hotenNV, email, sdt, gioiTinh, 1)))
            {
                MessageBox.Show("Thêm thành công");
                this.listNhanVien.Add(new NhanVienDTO(maNV, hotenNV, email, sdt, gioiTinh, 1));
                this.DialogResult = DialogResult.OK;
                Hide();
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool IsValidEmail(string source)
        {
            return new EmailAddressAttribute().IsValid(source);
        }
    }
}
