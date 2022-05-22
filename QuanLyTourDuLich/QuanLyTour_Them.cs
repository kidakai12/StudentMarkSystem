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
    public partial class QuanLyTour_Them : Form
    {
        public List<TourDTO> list { get; set; }
        List<LoaiTourDTO> listloai;

        public QuanLyTour_Them(List<TourDTO> list, List<LoaiTourDTO> listloai)
        {
            InitializeComponent();
            this.list = list;
            this.listloai = listloai;

            foreach (LoaiTourDTO i in this.listloai)
            {
                comboBox1.Items.Add(i.Ten_Loai);
            }
            comboBox1.SelectedItem = listloai[0].Ten_Loai;
            textBox1.Text = new TourBUS().MakeID();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string matour = textBox1.Text;
            string tentour = textBox2.Text;
            string dacdiem = textBox3.Text;
            string tenloai = comboBox1.SelectedItem.ToString();
            if(tentour.Equals(null)|| tentour.Equals("")|| dacdiem.Equals("") || dacdiem.Equals(null))
            {
                MessageBox.Show("Vui lòng nhập thông tin đầy đủ");
                return;
            }
            string idloai = new LoaiTourBUS().getID(tenloai);
            if (new TourBUS().Insert(new TourDTO(matour, tentour, dacdiem, idloai, 1)))
            {
                MessageBox.Show("Thêm thành công");
                this.list.Add(new TourDTO(matour, tentour, dacdiem, idloai,1));
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QuanLyTour_Them_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
