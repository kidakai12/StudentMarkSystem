using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;
namespace QuanLyTourDuLich
{
    public partial class QuanLyChiTietTour_Sua : Form
    {

        List<DiaDiemDTO> listdd = new List<DiaDiemDTO>();
        public List<ChiTietTourDTO> list { get; set; }
        string id = "";
        public QuanLyChiTietTour_Sua(List<ChiTietTourDTO> list, List<DiaDiemDTO> listdd, string id)
        {
            InitializeComponent();
            this.list = list;
            this.listdd = listdd;
            this.id = id;
            foreach (DiaDiemDTO item in listdd)
            {
                DiaDiem_cb.Items.Add(item.Ten_DiaDiem);
            }
            ChiTietTourDTO edit = list.Find(x => x.Id_DiaDiem.Equals(id));
            IdTour_txt.Text = edit.Id_Tour;
            DiaDiem_cb.SelectedItem = listdd.Find(x => x.Id_DiaDiem.Equals(id)).Ten_DiaDiem;
            ThuTu_num.Value = edit.Thutu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string matour = IdTour_txt.Text;
            string diadiem = DiaDiem_cb.Text;
            string madiadiem = listdd.Find(x => x.Ten_DiaDiem.Equals(diadiem)).Id_DiaDiem;
            if (diadiem.Equals(null))
            {
                MessageBox.Show("Vui lòng chọn địa điểm");
                return;
            }
            if (ThuTu_num.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập thứ tự");
                return;
            }
            if (ThuTu_num.Text == "" || ThuTu_num.Text == null)
            {
                MessageBox.Show("Vui lòng nhập thứ tự lớn hơn 0");
                return;
            }
            int thutu = int.Parse(ThuTu_num.Text);
            if (new ChiTietTourBUS().Update(new ChiTietTourDTO(matour, madiadiem, thutu), id))
            {
                MessageBox.Show("Sửa thành công");
                list.Find(x => x.Id_DiaDiem.Equals(id)).Id_DiaDiem = madiadiem;
                list.Find(x => x.Id_DiaDiem.Equals(id)).Thutu = thutu;
                this.DialogResult = DialogResult.OK;
                Hide();
            }
            else
            {
                MessageBox.Show("Không thể sửa thành địa điểm này vì tour này đã có địa điểm này");
                return;
            }
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
