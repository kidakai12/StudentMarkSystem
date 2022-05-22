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
    public partial class QuanLyChiTietTour_Them : Form
    {
        List<DiaDiemDTO> listdd = new List<DiaDiemDTO>();
        public List<ChiTietTourDTO> list { get; set; }
        public QuanLyChiTietTour_Them(List<ChiTietTourDTO> list, List<DiaDiemDTO> listdd,string id)
        {
            InitializeComponent();
            this.list = list;
            this.listdd = listdd;
            List<string> listname = new List<string>();
            foreach (DiaDiemDTO item in listdd)
            {
                DiaDiem_cb.Items.Add(item.Ten_DiaDiem);
            }
            DiaDiem_cb.SelectedItem = listdd[0].Ten_DiaDiem;
            IdTour_txt.Text = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string matour = IdTour_txt.Text;
            string diadiem = DiaDiem_cb.Text;
            string iddiadiem = listdd.Find(x=>x.Ten_DiaDiem.Equals(diadiem)).Id_DiaDiem;
            
            if(diadiem.Equals(null))
            {
                MessageBox.Show("Vui lòng chọn địa điểm");
                return;
            }
            if (ThuTu_num.Text.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập thứ tự");
                return;
            }
            int thutu = Int32.Parse(ThuTu_num.Text);
            if (thutu < 0)
            {
                MessageBox.Show("Vui lòng nhập thứ tự lớn hơn 0");
                return;
            }
            try
            {
                if (new ChiTietTourBUS().Insert(new ChiTietTourDTO(matour, iddiadiem, thutu)))
                {
                    MessageBox.Show("Thêm thành công");
                    this.list.Add(new ChiTietTourDTO(matour, iddiadiem, thutu));
                    this.DialogResult = DialogResult.OK;
                    Hide();
                }
                else
                {
                    MessageBox.Show("Không thể thêm địa điểm này vì tour này đã có thứ tự này");
                    return;
                }
            }
            catch (SqlException e1) when (e1.Number == 2627)
            {
                MessageBox.Show("Không thể thêm địa điểm này vì tour này đã có địa điểm này");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
