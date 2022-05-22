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
    public partial class ThongKeNhanVien : Form
    {
        List<PhanCongDTO> list;
        public ThongKeNhanVien(string idnv)
        {
            InitializeComponent();
            txt_manv.Text = idnv;
            txt_thamgia.Text = "0";
            List<PhanCongDTO> phancong = new PhanCongBUS().List();
            list = phancong.FindAll(x => x.Id_NV.Equals(idnv));
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Grid_Thongke.Rows.Clear();
            Grid_Thongke.Refresh();
            string dt1 = txtNgayKhoiHanh.Text;
            string dt2 = txtNgayKetThuc.Text;
            List<DoanDuLichDTO> doan = new ThongKeNhanVienBUS().list(list, dt1, dt2);
            foreach (DoanDuLichDTO item in doan)
                Grid_Thongke.Rows.Add(item.Id_Doan,item.Ngaykhoihanh,item.Ngayketthuc);
            if(doan.Count != 0)
            {
                txt_thamgia.Text = doan.Count.ToString();
            }
        }
    }
}
