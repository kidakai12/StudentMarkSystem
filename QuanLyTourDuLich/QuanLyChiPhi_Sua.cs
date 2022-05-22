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
    public partial class QuanLyChiPhi_Sua : Form
    {
        public List<ChiPhiDTO> list { set; get; }
        List<LoaiChiPhiDTO> listloai;
        string id,idchiphi;
        long phi;
        public QuanLyChiPhi_Sua(List<ChiPhiDTO> list, List<LoaiChiPhiDTO> listloai, string iddoan,string idchiphi)
        {
            InitializeComponent();
            this.list = list;
            this.listloai = listloai;
            this.id = iddoan;
            this.idchiphi = idchiphi;
            this.phi = list.Find(x => x.Id_LoaiChiPhi.Equals(idchiphi)).Gia;
            foreach (LoaiChiPhiDTO item in listloai)
            {
                cb_loaichiphi.Items.Add(item.Ten_LoaiChiPhi);
            }
            cb_loaichiphi.SelectedItem = listloai.Find(x => x.Id_LoaiChiPhi.Equals(idchiphi)).Ten_LoaiChiPhi;
            numGia.Value = phi;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string loai = listloai.Find(x => x.Ten_LoaiChiPhi.Equals(cb_loaichiphi.SelectedItem.ToString())).Id_LoaiChiPhi;
            string gia = numGia.Text;
            long value = long.Parse(gia);
            if (value < 10000)
            {
                MessageBox.Show("Vui lòng nhập giá lớn hơn 10000");
                return;
            }
            long value2 = value - phi;
            if (new ChiPhiBUS().Update(new ChiPhiDTO(loai, id, value),idchiphi))
            {
                MessageBox.Show("Sửa thành công");
                new DoanDuLichBUS().UpdateDoanhThu(id,value2);
                list.Find(x => x.Id_LoaiChiPhi.Equals(idchiphi)).Gia = value;
                list.Find(x => x.Id_LoaiChiPhi.Equals(idchiphi)).Id_LoaiChiPhi = loai;
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
