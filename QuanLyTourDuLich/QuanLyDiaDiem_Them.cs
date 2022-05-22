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
    public partial class QuanLyDiaDiem_Them : Form
    {
        public List<DiaDiemDTO> list { get; set; }
        public QuanLyDiaDiem_Them(List<DiaDiemDTO> list)
        {
            InitializeComponent();
            this.list = list;
            textBox1.Text = new DiaDiemBUS().MakeID();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string madiadiem = textBox1.Text;
            string tendiadiem = textBox2.Text;
            if(tendiadiem.Equals(""))
            {
                MessageBox.Show("Xin hãy nhập tên địa điểm");
                return;
            }
            if (new DiaDiemBUS().Insert(new DiaDiemDTO(madiadiem, tendiadiem)))
            {
                MessageBox.Show("Thêm thành công");
                this.list.Add(new DiaDiemDTO(madiadiem, tendiadiem));
                this.DialogResult = DialogResult.OK;
                Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
