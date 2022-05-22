
namespace QuanLyTourDuLich
{
    partial class ThongKeNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Grid_Thongke = new System.Windows.Forms.DataGridView();
            this.txt_thamgia = new System.Windows.Forms.TextBox();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.txtNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.txtNgayKhoiHanh = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.Gia_lbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.Id_Doan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaykhoihanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngayketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Thongke)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.Grid_Thongke);
            this.panel1.Controls.Add(this.txt_thamgia);
            this.panel1.Controls.Add(this.txt_manv);
            this.panel1.Controls.Add(this.txtNgayKetThuc);
            this.panel1.Controls.Add(this.txtNgayKhoiHanh);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.Gia_lbl);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 383);
            this.panel1.TabIndex = 6;
            // 
            // Grid_Thongke
            // 
            this.Grid_Thongke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Thongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Thongke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Doan,
            this.Ngaykhoihanh,
            this.Ngayketthuc});
            this.Grid_Thongke.Location = new System.Drawing.Point(468, 116);
            this.Grid_Thongke.Name = "Grid_Thongke";
            this.Grid_Thongke.RowHeadersWidth = 51;
            this.Grid_Thongke.RowTemplate.Height = 29;
            this.Grid_Thongke.Size = new System.Drawing.Size(460, 242);
            this.Grid_Thongke.TabIndex = 38;
            // 
            // txt_thamgia
            // 
            this.txt_thamgia.Location = new System.Drawing.Point(208, 172);
            this.txt_thamgia.Name = "txt_thamgia";
            this.txt_thamgia.ReadOnly = true;
            this.txt_thamgia.Size = new System.Drawing.Size(240, 27);
            this.txt_thamgia.TabIndex = 33;
            // 
            // txt_manv
            // 
            this.txt_manv.Location = new System.Drawing.Point(208, 116);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.ReadOnly = true;
            this.txt_manv.Size = new System.Drawing.Size(240, 27);
            this.txt_manv.TabIndex = 32;
            // 
            // txtNgayKetThuc
            // 
            this.txtNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.txtNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayKetThuc.Location = new System.Drawing.Point(468, 16);
            this.txtNgayKetThuc.Margin = new System.Windows.Forms.Padding(2);
            this.txtNgayKetThuc.Name = "txtNgayKetThuc";
            this.txtNgayKetThuc.Size = new System.Drawing.Size(317, 27);
            this.txtNgayKetThuc.TabIndex = 22;
            // 
            // txtNgayKhoiHanh
            // 
            this.txtNgayKhoiHanh.CustomFormat = "dd/MM/yyyy";
            this.txtNgayKhoiHanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayKhoiHanh.Location = new System.Drawing.Point(24, 16);
            this.txtNgayKhoiHanh.Margin = new System.Windows.Forms.Padding(2);
            this.txtNgayKhoiHanh.Name = "txtNgayKhoiHanh";
            this.txtNgayKhoiHanh.Size = new System.Drawing.Size(390, 27);
            this.txtNgayKhoiHanh.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(419, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "Tới";
            // 
            // Gia_lbl
            // 
            this.Gia_lbl.AutoSize = true;
            this.Gia_lbl.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Gia_lbl.Location = new System.Drawing.Point(24, 118);
            this.Gia_lbl.Name = "Gia_lbl";
            this.Gia_lbl.Size = new System.Drawing.Size(139, 25);
            this.Gia_lbl.TabIndex = 18;
            this.Gia_lbl.Text = "Mã Nhân Viên";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(24, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 25);
            this.label12.TabIndex = 15;
            this.label12.Text = "Số đoàn tham gia";
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHuy.Location = new System.Drawing.Point(819, 8);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(109, 43);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Tìm";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // Id_Doan
            // 
            this.Id_Doan.HeaderText = "Mã Đoàn";
            this.Id_Doan.MinimumWidth = 6;
            this.Id_Doan.Name = "Id_Doan";
            this.Id_Doan.ReadOnly = true;
            // 
            // Ngaykhoihanh
            // 
            this.Ngaykhoihanh.HeaderText = "Ngày khởi hành";
            this.Ngaykhoihanh.MinimumWidth = 6;
            this.Ngaykhoihanh.Name = "Ngaykhoihanh";
            this.Ngaykhoihanh.ReadOnly = true;
            // 
            // Ngayketthuc
            // 
            this.Ngayketthuc.HeaderText = "Ngày kết thúc";
            this.Ngayketthuc.MinimumWidth = 6;
            this.Ngayketthuc.Name = "Ngayketthuc";
            this.Ngayketthuc.ReadOnly = true;
            // 
            // ThongKeNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 407);
            this.Controls.Add(this.panel1);
            this.Name = "ThongKeNhanVien";
            this.Text = "ThongKeNhanVien";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Thongke)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Grid_Thongke;
        private System.Windows.Forms.TextBox txt_thamgia;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.DateTimePicker txtNgayKetThuc;
        private System.Windows.Forms.DateTimePicker txtNgayKhoiHanh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Gia_lbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Doan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaykhoihanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngayketthuc;
    }
}