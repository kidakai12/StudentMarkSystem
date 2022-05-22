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
    public partial class ThongKe : Form
    {
        List<string> hi;
        List<DoanDuLichDTO> list;
        public ThongKe(string id)
        {
            InitializeComponent();
            List<DoanDuLichDTO> listdoan = new DoanDuLichBUS().List();
            list = listdoan.FindAll(x => x.Id_Tour.Equals(id));
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string dt1 = txtNgayKhoiHanh.Text;
            string dt2 = txtNgayKetThuc.Text;
            ThongKeBUS bus = new ThongKeBUS();
            txt_khachsan.Text = bus.chiphikhachsan(list, dt1, dt2).ToString("#,#") + " VNĐ";
            txt_anuong.Text = bus.chiphianuong(list, dt1, dt2).ToString("#,#") + " VNĐ";
            txt_phuongtien.Text = bus.chiphiphuongtien(list, dt1, dt2).ToString("#,#") + " VNĐ";
            txt_sodoan.Text = bus.sodoan(list, dt1, dt2).ToString();
            txtdoanhso.Text = bus.doanhso(list, dt1, dt2).ToString("#,#") + " VNĐ";
            txt_tong.Text=bus.tongtatca(list, dt1, dt2).ToString("#,#") + " VNĐ";

        }
    }
}
