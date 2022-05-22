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
    public partial class QuanLyChiTietTour : Form
    {
        string id = "";
        List<ChiTietTourDTO> list;
        List<DiaDiemDTO> listdd;
        public QuanLyChiTietTour(String id)
        {
            InitializeComponent();
            this.id = id;
            list = new ChiTietTourBUS().List(id);
            listdd = new DiaDiemBUS().List();
            Grid_chitiettour.AutoGenerateColumns = false;
            BindGrid(list);
        }
        //QUẢN LÝ CHI TIẾT TOUR ===========================================================================================================
        //Hàm lấy danh sách
        public void BindGrid(List<ChiTietTourDTO> list)
        {
            Grid_chitiettour.Rows.Clear();
            Grid_chitiettour.Refresh();
            foreach (ChiTietTourDTO item in list)
            {
                string tendiadiem = listdd.Find(x => x.Id_DiaDiem.Equals(item.Id_DiaDiem)).Ten_DiaDiem;
                Grid_chitiettour.Rows.Add(item.Id_DiaDiem, tendiadiem, item.Thutu);
            }
        }

        //Button Thêm
        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new QuanLyChiTietTour_Them(list, listdd,id))
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
            if (Grid_chitiettour.RowCount != 0)
            {
                int selectedrowindex = Grid_chitiettour.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_chitiettour.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Id_DiaDiem"].Value);
                using (var form = new QuanLyChiTietTour_Sua(list, listdd, cellValue))
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

        private void button5_Click(object sender, EventArgs e)
        {
            BindGrid(list);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Grid_chitiettour.RowCount != 0)
            {
                int selectedrowindex = Grid_chitiettour.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_chitiettour.Rows[selectedrowindex];
                string cellValue = id;
                string cellValue2 = Convert.ToString(selectedRow.Cells["Id_DiaDiem"].Value);
                if(new ChiTietTourBUS().Delete(cellValue,cellValue2))
                {
                    MessageBox.Show("Xóa chi tiết thành công");
                    list.RemoveAll(x=>x.Id_DiaDiem.Equals(cellValue2));
                    BindGrid(list) ;
                }
            }
        }
    }
}
