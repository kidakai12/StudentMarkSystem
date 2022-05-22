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
    public partial class QuanLyChiTietDoan : Form
    {
        string id;

        string gia;

        List<ChiTietDoanDTO> list;

        List<KhachDTO> listkhach;

        List<ChiPhiDTO> listchiphi;

        List<LoaiChiPhiDTO> listloaichiphi;

        public QuanLyChiTietDoan(string id, string gia)
        {
            InitializeComponent();
            this.id = id;
            this.gia = gia;

            list = new ChiTietDoanBUS().List(id);
            listkhach = new KhachHangBUS().List();

            listchiphi = new ChiPhiBUS().List(id);
            listloaichiphi = new LoaiChiPhiBUS().List();

            dataGridView_CT_Doan.AutoGenerateColumns = false;
            Grid_ChiPhi.AutoGenerateColumns = false;

            BindGrid(list);
            BindGrid2(listchiphi);
        }
        public void BindGrid(List<ChiTietDoanDTO> list)
        {
            dataGridView_CT_Doan.Rows.Clear();
            dataGridView_CT_Doan.Refresh();
            foreach (ChiTietDoanDTO item in list)
            {
                
                string tenkhach = listkhach.Find(x => x.Id_Khach.Equals(item.Id_Khach)).Hoten_Khach;
                string cmndkhach = listkhach.Find(x => x.Id_Khach.Equals(item.Id_Khach)).Cmnd_Khach;
                dataGridView_CT_Doan.Rows.Add(item.Id_Khach, tenkhach, cmndkhach);
            }
        }
        public void BindGrid2(List<ChiPhiDTO> list)
        {
            Grid_ChiPhi.Rows.Clear();
            Grid_ChiPhi.Refresh();
            foreach (ChiPhiDTO item in list)
            {
                string tenchiphi =  listloaichiphi.Find(x => x.Id_LoaiChiPhi.Equals(item.Id_LoaiChiPhi)).Ten_LoaiChiPhi;
                Grid_ChiPhi.Rows.Add(tenchiphi,item.Gia.ToString("#,#") + " VNĐ", item.Id_LoaiChiPhi, item.Gia);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var form = new QuanLyChiTietDoan_Them(list, listkhach, id, gia))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.list = form.list;
                    BindGrid(list);
                }
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView_CT_Doan.RowCount != 0)
            {
                int selectedrowindex = dataGridView_CT_Doan.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView_CT_Doan.Rows[selectedrowindex];
                string cellValue = id;
                string cellValue2 = Convert.ToString(selectedRow.Cells["Id_Khach"].Value);
                if (new ChiTietDoanBUS().Delete(cellValue, cellValue2))
                {
                    MessageBox.Show("Xóa chi tiết thành công");
                    new DoanDuLichBUS().UpdateDoanhThu(id,long.Parse(gia));
                    list.RemoveAll(x => x.Id_Khach.Equals(cellValue2));
                    BindGrid(list);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var form = new QuanLyChiPhi_Them(listchiphi, listloaichiphi,id))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.listchiphi = form.list;
                    BindGrid2(listchiphi);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Grid_ChiPhi.RowCount != 0)
            {
                int selectedrowindex = Grid_ChiPhi.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_ChiPhi.Rows[selectedrowindex];
                string cellValue2 = Convert.ToString(selectedRow.Cells["Id_ChiPhi"].Value);
                long cellValue3 = long.Parse(Convert.ToString(selectedRow.Cells["giareal"].Value));
                if (new ChiPhiBUS().Delete(cellValue2,id))
                {
                    MessageBox.Show("Xóa chi tiết thành công");
                    new DoanDuLichBUS().UpdateDoanhThu(id,cellValue3);
                    listchiphi.RemoveAll(x => x.Id_LoaiChiPhi.Equals(cellValue2));
                    BindGrid2(listchiphi);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Grid_ChiPhi.RowCount != 0)
            {
                int selectedrowindex = Grid_ChiPhi.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Grid_ChiPhi.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Id_ChiPhi"].Value);
                using (var form = new QuanLyChiPhi_Sua(listchiphi, listloaichiphi, id, cellValue))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        this.listchiphi = form.list;
                        BindGrid2(listchiphi);
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BindGrid(list);
            BindGrid2(listchiphi);
        }

    }
}
