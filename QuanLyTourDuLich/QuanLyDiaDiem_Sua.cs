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
    public partial class QuanLyDiaDiem_Sua : Form
    {
        public List<DiaDiemDTO> list { get; set; }
        public QuanLyDiaDiem_Sua(List<DiaDiemDTO> list,string id)
        {
            InitializeComponent();
            this.list = list;
            DiaDiemDTO edit = list.Find(x => x.Id_DiaDiem.Equals(id));

            textBox1.Text = id;
            textBox2.Text = edit.Ten_DiaDiem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string madiadiem = textBox1.Text;
            string tendiadiem = textBox2.Text;
            if (tendiadiem.Equals(""))
            {
                MessageBox.Show("Xin hãy nhập tên địa điểm");
                return;
            }
            if (new DiaDiemBUS().Update(new DiaDiemDTO(madiadiem, tendiadiem)))
            {
                MessageBox.Show("Sửa thành công");
                list.Find(x => x.Id_DiaDiem.Equals(madiadiem)).Ten_DiaDiem = tendiadiem;
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
