using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Diagnostics;

namespace QuanLyTourDuLich
{
    public partial class QuanLyPhanCong_Sua : Form
    {
        public List<PhanCongDTO> list { get; set; }
        string idDoan, idNV;

        public QuanLyPhanCong_Sua(List<PhanCongDTO> list, List<DoanDuLichDTO> listDoan, List<NhanVienDTO> listNhanVien, String idDoan, String idNV)
        {
            InitializeComponent();
            this.list = list;
            this.idDoan = idDoan;
            this.idNV = idNV;
            foreach (DoanDuLichDTO d in listDoan)
            {
                cboDoan.Items.Add(d.Id_Doan);
            }
            foreach (NhanVienDTO nv in listNhanVien)
            {
                cboNV.Items.Add(nv.Id_NV);
            }

            cboDoan.SelectedIndex = cboDoan.FindStringExact(idDoan);
            cboNV.SelectedIndex = cboNV.FindStringExact(idNV);
            PhanCongDTO item2 = this.list.Find(x => x.Id_Doan.Equals(idDoan) && x.Id_NV.Equals(idNV));
            txt_1.Text = item2.Nhiemvu;
        }

        private void BtnSua_Click(object sender, EventArgs e)
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

            if (new PhanCongBUS().Update(new PhanCongDTO(maDoan, maNV, nhiemVu), idDoan, idNV))
            {
                MessageBox.Show("Sửa thành công");

                list.Find(x => x.Id_Doan.Equals(idDoan) && x.Id_NV.Equals(idNV)).Nhiemvu = nhiemVu;
                list.Find(x => x.Id_Doan.Equals(idDoan) && x.Id_NV.Equals(idNV)).Id_Doan = maDoan;
                list.Find(x => x.Id_Doan.Equals(maDoan) && x.Id_NV.Equals(idNV)).Id_NV = maNV;

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
