using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyTourDuLich
{
    public partial class QuanLyPhanCong_Them : Form
    {
        public List<PhanCongDTO> list { get; set; }

        public QuanLyPhanCong_Them(List<PhanCongDTO> list, List<DoanDuLichDTO> listDoan, List<NhanVienDTO> listNhanVien)
        {
            InitializeComponent();
            this.list = list;
            foreach (DoanDuLichDTO d in listDoan)
            {
                cboDoan.Items.Add(d.Id_Doan);
            }
            foreach (NhanVienDTO nv in listNhanVien)
            {
                cboNV.Items.Add(nv.Id_NV);
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            string maDoan = cboDoan.Text;
            string maNV = cboNV.Text;
            string nhiemVu = txt_1.Text;

            if (list.Find(x => x.Id_Doan.Equals(maDoan) && x.Id_NV.Equals(maNV)) != null)
            {
                MessageBox.Show("Nhân viên " + maNV + " đã được phân công trong Đoàn " + maDoan + ".\nVui là chọn Đoàn hoặc Nhân viên khác.");
                return;
            }

            if (new PhanCongBUS().KiemTraTG(maDoan, maNV) != "")
            {
                MessageBox.Show("Nhân viên " + maNV + " đã được phân công trong Đoàn " + new PhanCongBUS().KiemTraTG(maDoan, maNV) + " trùng thời gian với đoàn " + maDoan + ".\nVui là chọn Đoàn hoặc Nhân viên khác.");
                return;
            }    
                
            if (nhiemVu.Equals("") || maDoan.Equals("") || nhiemVu.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            if (new PhanCongBUS().Insert(new PhanCongDTO(maDoan, maNV, nhiemVu)))
            {
                MessageBox.Show("Thêm thành công");
                this.list.Add(new PhanCongDTO(maDoan, maNV, nhiemVu));
                this.DialogResult = DialogResult.OK;
                Hide();
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
