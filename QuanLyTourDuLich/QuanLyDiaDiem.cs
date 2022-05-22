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
    public partial class QuanLyDiaDiem : Form
    {
        List<DiaDiemDTO> list;
        public QuanLyDiaDiem()
        {
            InitializeComponent();
            list = new DiaDiemBUS().List();
            Grid_Danhsachdiadiem.AutoGenerateColumns = false;
            List<string> listtype = new List<string> { "Mã Địa điểm", "Tên Địa điểm"};
            SearchBox_cb.DataSource = listtype;
            BindGrid(list);
        }

        //QUẢN LÝ ĐỊA ĐIỂM =================================================================================================================
        //Hàm lấy danh sách
        public void BindGrid(List<DiaDiemDTO> list)
        {
            Grid_Danhsachdiadiem.Rows.Clear();
            Grid_Danhsachdiadiem.Refresh();
            foreach (DiaDiemDTO item in list)
            {
                Grid_Danhsachdiadiem.Rows.Add(item.Id_DiaDiem,item.Ten_DiaDiem);
            }
        }

        //Button thêm 
        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new QuanLyDiaDiem_Them(list))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.list = form.list;
                    BindGrid(list);
                }
            }
        }

        //Button Sửa 
        private void button2_Click(object sender, EventArgs e)
        {
            if (Grid_Danhsachdiadiem.RowCount != 0)
            {
                int selectedrowindex = Grid_Danhsachdiadiem.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_Danhsachdiadiem.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Id_Diadiem"].Value);
                using (var form = new QuanLyDiaDiem_Sua(list, cellValue))
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

        //Button Xóa 
        private void button3_Click(object sender, EventArgs e)
        {
            int selectedrowindex = Grid_Danhsachdiadiem.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = Grid_Danhsachdiadiem.Rows[selectedrowindex];
            string cellValue = Convert.ToString(selectedRow.Cells["Id_Diadiem"].Value);
            try
            {
                if (new DiaDiemBUS().Delete(cellValue))
                {
                    MessageBox.Show("Xóa thành công");
                    list.RemoveAll(x => x.Id_DiaDiem.Equals(cellValue));
                    BindGrid(list);
                }
            } catch (SqlException e1) when (e1.Number == 547)
            {
                MessageBox.Show("Không thể xóa địa điểm này vì địa điểm này đã có trong tour du lịch");
                return;
            }
        }

        //Button Reload 
        private void button5_Click(object sender, EventArgs e)
        {
            BindGrid(list);
        }

        private void SearchDiadiem_txt_TextChanged(object sender, EventArgs e)
        {
            string search = SearchDiadiem_txt.Text;
            string typesearch = SearchBox_cb.SelectedItem.ToString();
            List<DiaDiemDTO> listsearch = new List<DiaDiemDTO>();
            switch (typesearch)
            {
                case "Mã Địa điểm":
                    listsearch = list.FindAll(x => x.Id_DiaDiem.Contains(search));
                    break;
                case "Tên Địa điểm":
                    listsearch = list.FindAll(x => x.Ten_DiaDiem.Contains(search));
                    break;
                default:
                    break;
            }
            BindGrid(listsearch);
        }
    }
}
