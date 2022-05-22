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
    public partial class QuanLyTour_Sua : Form
    {
        public List<TourDTO> list { get; set; }
        List<LoaiTourDTO> listloai;
        public QuanLyTour_Sua(List<TourDTO> list, List<LoaiTourDTO> listloai,string id)
        {
            InitializeComponent();
            this.list = list;
            this.listloai = listloai;

            foreach (LoaiTourDTO i in this.listloai)
            {
                comboBox2.Items.Add(i.Ten_Loai);
            }
            TourDTO item = list.Find(x=> x.Id_Tour.Equals(id));
            textBox1.Text = id;
            textBox2.Text = item.Ten_Tour;
            textBox3.Text = item.Dacdiem_Tour;
            comboBox2.SelectedItem = listloai.Find(x => x.Id_Loai.Equals(item.Id_Loai)).Ten_Loai;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string matour = textBox1.Text;
            string tentour = textBox2.Text;
            string dacdiem = textBox3.Text;
            string tenloai = comboBox2.SelectedItem.ToString();
            string idloai = listloai.Find(x => x.Ten_Loai.Equals(tenloai)).Id_Loai;
            if (tentour.Equals(null) || tentour.Equals("") || dacdiem.Equals("") || dacdiem.Equals(null))
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ");
                return;
            }
            if (new TourBUS().Update(new TourDTO(matour, tentour, dacdiem, idloai,1)))
            {
                MessageBox.Show("Sửa thành công");
                list.Find(x => x.Id_Tour.Equals(matour)).Ten_Tour=tentour;
                list.Find(x => x.Id_Tour.Equals(matour)).Dacdiem_Tour = dacdiem;
                list.Find(x => x.Id_Tour.Equals(matour)).Id_Loai = idloai;
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
