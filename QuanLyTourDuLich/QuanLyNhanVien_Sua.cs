using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyTourDuLich
{
    public partial class QuanLyNhanVien_Sua : Form
    {
        public List<NhanVienDTO> listNhanVien { get; set; }
        public QuanLyNhanVien_Sua(List<NhanVienDTO> list, string id)
        {
            InitializeComponent();
            this.listNhanVien = list;

            NhanVienDTO item = list.Find(x => x.Id_NV.Equals(id));
            txtMaNV.Text = id;
            txtHoTen.Text = item.Hoten_NV;
            txtSDT.Text = item.Sdt_NV;
            txtEmail.Text = item.Email_NV;
            if (item.Gioitinh_NV.Equals("Nam"))
            {
                rbNam.Checked = true;
            }
            else
            {
                rbNu.Checked = true;
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string hotenNV = txtHoTen.Text;
            string email = txtEmail.Text;
            string sdt = txtSDT.Text;
            bool isChecked = rbNam.Checked;
            string gioiTinh;
            if (isChecked)
                gioiTinh = rbNam.Text;
            else
                gioiTinh = rbNu.Text;
            int tinhTrang = 1;
            if (maNV.Equals(null) || hotenNV.Equals(null) || email.Equals(null) || sdt.Equals(null))
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

            if (new NhanVienBUS().Update(new NhanVienDTO(maNV, hotenNV, email, sdt, gioiTinh, tinhTrang)))
            {
                MessageBox.Show("Sửa thành công");
                listNhanVien.Find(x => x.Id_NV.Equals(maNV)).Hoten_NV = hotenNV;
                listNhanVien.Find(x => x.Id_NV.Equals(maNV)).Email_NV = email;
                listNhanVien.Find(x => x.Id_NV.Equals(maNV)).Sdt_NV = sdt;
                listNhanVien.Find(x => x.Id_NV.Equals(maNV)).Email_NV = email;
                listNhanVien.Find(x => x.Id_NV.Equals(maNV)).Gioitinh_NV = gioiTinh;
                this.DialogResult = DialogResult.OK;
                Hide();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool IsValidEmail(string source)
        {
            return new EmailAddressAttribute().IsValid(source);
        }
    }
}
