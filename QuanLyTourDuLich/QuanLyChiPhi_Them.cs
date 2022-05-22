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
    public partial class QuanLyChiPhi_Them : Form
    {
        public List<ChiPhiDTO> list { set; get; }
        List<LoaiChiPhiDTO> listloai;
        string id;
        public QuanLyChiPhi_Them(List<ChiPhiDTO> list, List<LoaiChiPhiDTO> listloai,string iddoan)
        {
            InitializeComponent();
            this.list = list;
            this.listloai = listloai;
            this.id = iddoan;
            foreach (LoaiChiPhiDTO item in listloai)
            {
                cb_loaichiphi.Items.Add(item.Ten_LoaiChiPhi);
            }
            cb_loaichiphi.SelectedItem = listloai[0].Ten_LoaiChiPhi;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loai =  listloai.Find(x => x.Ten_LoaiChiPhi.Equals(cb_loaichiphi.SelectedItem.ToString())).Id_LoaiChiPhi;
            string gia = numGia.Text;
            long value = long.Parse(gia);
            if(value < 10000)
            {
                MessageBox.Show("Vui lòng nhập giá lớn hơn 10000");
                return;
            }
            if (new ChiPhiBUS().Insert(new ChiPhiDTO(loai, id, value)))
            {
                MessageBox.Show("Thêm thành công");
                list.Add(new ChiPhiDTO(loai, id, value));
                new DoanDuLichBUS().UpdateDoanhThu(id,value);
                this.DialogResult = DialogResult.OK;
                Hide();
            }
            else
            {
                MessageBox.Show("Chi phí đã tồn tại");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
