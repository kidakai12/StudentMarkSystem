using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
namespace QuanLyTourDuLich
{
    public partial class QuanLyGia : Form
    {
        List<GiaDTO> list;
        List<TourDTO> listtour;
        public QuanLyGia()
        {
            InitializeComponent();
            list = new GiaBUS().List();
            listtour = new TourBUS().List();
            GiaView.AutoGenerateColumns = false;
            List<string> listtype = new List<string> { "Mã Giá", "Mã Tour","Giá","Ngày" };
            SearchBox_cb.DataSource = listtype;
            BindGrid(list);
        }
        public void BindGrid(List<GiaDTO> list)
        {
            GiaView.Rows.Clear();
            GiaView.Refresh();
            foreach (GiaDTO item in list)
            {
                GiaView.Rows.Add(item.Id_Gia,item.Id_Tour,item.Gia+"VNĐ",item.Thoigianbatdau,item.Thoigianketthuc);
                //string plit = item.Gia.Split('V')[0];
            }

            
        }
        private void SearchTour_txt_TextChanged(object sender, EventArgs e)
        {
            string typesearch = SearchBox_cb.SelectedItem.ToString();
            string searchkey = SearchGia_txt.Text;
            List<GiaDTO> listsearch = new List<GiaDTO>();
            switch (typesearch)
            {
                case "Mã Giá":
                    listsearch = list.FindAll(x => x.Id_Gia.Contains(searchkey));
                    break;
                case "Mã Tour":
                    listsearch = list.FindAll(x => x.Id_Tour.Contains(searchkey));
                    break;
                default:
                    break;
            }
            BindGrid(listsearch);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new QuanLyGia_Them(list, listtour))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.list = form.list;
                    BindGrid(list);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GiaView.RowCount != 0)
            {
                int selectedrowindex = GiaView.SelectedRows[0].Index;
                DataGridViewRow selectedRow = GiaView.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Id_Gia"].Value);
                using (var form = new QuanLyGia_Sua(list, listtour, cellValue))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        this.list = form.list;
                        BindGrid(list);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int selectedrowindex = GiaView.SelectedRows[0].Index;
            DataGridViewRow selectedRow = GiaView.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Id_Gia"].Value);
                if (new GiaBUS().Delete(cellValue))
                {
                    MessageBox.Show("Xóa thành công");
                    list.RemoveAll(x => x.Id_Gia.Equals(cellValue));
                    BindGrid(list);
                }
            else
            {
                MessageBox.Show("Xóa không được");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BindGrid(list);
        }

        private void SearchBox_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string typesearch = SearchBox_cb.SelectedItem.ToString();
            numup.Text = 100000000000000.ToString();
            numdown.Text = 0.ToString();
            SearchGia_txt.Text = "";
            timepickdown.Value = timepickdown.MinDate;
            timepickup.Value = timepickup.MaxDate;
            switch (typesearch)
            {
                case "Giá":
                    numup.Visible = true;
                    numdown.Visible = true;
                    SearchGia_txt.Visible = false;
                    lblTo.Visible = true;
                    timepickdown.Visible = false;
                    timepickup.Visible = false;
                    break;
                case "Ngày":
                    numup.Visible = false;
                    numdown.Visible = false;
                    SearchGia_txt.Visible = false;
                    lblTo.Visible = true;
                    timepickdown.Visible = true;
                    timepickup.Visible = true;
                    break;
                default:
                    numup.Visible = false;
                    numdown.Visible = false;
                    SearchGia_txt.Visible = true;
                    lblTo.Visible = false;
                    timepickdown.Visible = false;
                    timepickup.Visible = false;
                    break;
            }
        }

        private void timepickup_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt1 = timepickup.Value;
            DateTime dt2 = timepickdown.Value;
            List<GiaDTO> listsearch = new List<GiaDTO>();
            foreach (GiaDTO item in list)
            {
                DateTime d1 = DateTime.ParseExact(item.Thoigianbatdau, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                DateTime d2 = DateTime.ParseExact(item.Thoigianketthuc, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                int result1 = DateTime.Compare(d1, dt2);
                int result2 = DateTime.Compare(d2, dt1);
                if (result1 >= 0 && result2 <= 0)
                {
                    listsearch.Add(item);
                }
            }
            BindGrid(listsearch);

        }

        private void numsearch_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                long up = long.Parse(numup.Text);
                long down = long.Parse(numdown.Text);
                List<GiaDTO> listsearch = new List<GiaDTO>();
                foreach (GiaDTO item in list)
                {
                    long result = long.Parse(item.Gia);
                    if (result >= down && result <= up)
                    {
                        listsearch.Add(item);
                    }
                }
                BindGrid(listsearch);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
