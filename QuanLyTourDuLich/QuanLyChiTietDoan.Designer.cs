
namespace QuanLyTourDuLich
{
    partial class QuanLyChiTietDoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyChiTietDoan));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Grid_ChiPhi = new System.Windows.Forms.DataGridView();
            this.Ten_LoaiChiPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_ChiPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridView_CT_Doan = new System.Windows.Forms.DataGridView();
            this.Id_Khach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hoten_Khach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cmnd_Khach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.giareal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ChiPhi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CT_Doan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(586, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "Trang Quản Lý Chi Tiết Đoàn Du Lịch";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.Grid_ChiPhi);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.dataGridView_CT_Doan);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1193, 571);
            this.panel2.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(927, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 45);
            this.button3.TabIndex = 18;
            this.button3.Text = "     Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1050, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 45);
            this.button1.TabIndex = 17;
            this.button1.Text = "    Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(804, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 45);
            this.button2.TabIndex = 16;
            this.button2.Text = "      Thêm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Grid_ChiPhi
            // 
            this.Grid_ChiPhi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_ChiPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_ChiPhi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten_LoaiChiPhi,
            this.Gia,
            this.Id_ChiPhi,
            this.giareal});
            this.Grid_ChiPhi.Location = new System.Drawing.Point(672, 73);
            this.Grid_ChiPhi.Name = "Grid_ChiPhi";
            this.Grid_ChiPhi.RowHeadersWidth = 51;
            this.Grid_ChiPhi.RowTemplate.Height = 29;
            this.Grid_ChiPhi.Size = new System.Drawing.Size(496, 485);
            this.Grid_ChiPhi.TabIndex = 15;
            // 
            // Ten_LoaiChiPhi
            // 
            this.Ten_LoaiChiPhi.HeaderText = "Loại Chi Phí";
            this.Ten_LoaiChiPhi.MinimumWidth = 6;
            this.Ten_LoaiChiPhi.Name = "Ten_LoaiChiPhi";
            this.Ten_LoaiChiPhi.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // Id_ChiPhi
            // 
            this.Id_ChiPhi.HeaderText = "Mã Chi Phí";
            this.Id_ChiPhi.MinimumWidth = 6;
            this.Id_ChiPhi.Name = "Id_ChiPhi";
            this.Id_ChiPhi.ReadOnly = true;
            this.Id_ChiPhi.Visible = false;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(535, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(117, 45);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "    Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(412, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(117, 45);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "      Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataGridView_CT_Doan
            // 
            this.dataGridView_CT_Doan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_CT_Doan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CT_Doan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Khach,
            this.Hoten_Khach,
            this.Cmnd_Khach});
            this.dataGridView_CT_Doan.Location = new System.Drawing.Point(11, 73);
            this.dataGridView_CT_Doan.Name = "dataGridView_CT_Doan";
            this.dataGridView_CT_Doan.RowHeadersWidth = 51;
            this.dataGridView_CT_Doan.RowTemplate.Height = 29;
            this.dataGridView_CT_Doan.Size = new System.Drawing.Size(641, 485);
            this.dataGridView_CT_Doan.TabIndex = 10;
            // 
            // Id_Khach
            // 
            this.Id_Khach.HeaderText = "Mã Khách Hàng";
            this.Id_Khach.MinimumWidth = 8;
            this.Id_Khach.Name = "Id_Khach";
            // 
            // Hoten_Khach
            // 
            this.Hoten_Khach.HeaderText = "Họ Tên";
            this.Hoten_Khach.MinimumWidth = 8;
            this.Hoten_Khach.Name = "Hoten_Khach";
            // 
            // Cmnd_Khach
            // 
            this.Cmnd_Khach.HeaderText = "CMND";
            this.Cmnd_Khach.MinimumWidth = 8;
            this.Cmnd_Khach.Name = "Cmnd_Khach";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danh sách Chi tiết Đoàn";
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.Location = new System.Drawing.Point(1085, 17);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(120, 45);
            this.btnReload.TabIndex = 14;
            this.btnReload.Text = "      Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.button5_Click);
            // 
            // giareal
            // 
            this.giareal.HeaderText = "giareal";
            this.giareal.MinimumWidth = 6;
            this.giareal.Name = "giareal";
            this.giareal.ReadOnly = true;
            this.giareal.Visible = false;
            // 
            // QuanLyChiTietDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1217, 665);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.panel2);
            this.Name = "QuanLyChiTietDoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Đoàn";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_ChiPhi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CT_Doan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridView_CT_Doan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView Grid_ChiPhi;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_LoaiChiPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_ChiPhi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Khach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hoten_Khach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cmnd_Khach;
        private System.Windows.Forms.DataGridViewTextBoxColumn giareal;
    }
}