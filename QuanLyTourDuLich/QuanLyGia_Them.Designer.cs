
namespace QuanLyTourDuLich
{
    partial class QuanLyGia_Them
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyGia_Them));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.TourView = new System.Windows.Forms.DataGridView();
            this.Id_Tour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_Tour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dacdiem_Tour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTour = new System.Windows.Forms.TextBox();
            this.numGia = new System.Windows.Forms.NumericUpDown();
            this.txtNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.txtNgayKhoiHanh = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.Gia_lbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TourView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.TourView);
            this.panel1.Controls.Add(this.txtTour);
            this.panel1.Controls.Add(this.numGia);
            this.panel1.Controls.Add(this.txtNgayKetThuc);
            this.panel1.Controls.Add(this.txtNgayKhoiHanh);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.Gia_lbl);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtGia);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Location = new System.Drawing.Point(12, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 656);
            this.panel1.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(740, 134);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 43);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "      Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // TourView
            // 
            this.TourView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TourView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TourView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Tour,
            this.Ten_Tour,
            this.Dacdiem_Tour});
            this.TourView.Location = new System.Drawing.Point(34, 208);
            this.TourView.Name = "TourView";
            this.TourView.RowHeadersWidth = 51;
            this.TourView.RowTemplate.Height = 29;
            this.TourView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TourView.Size = new System.Drawing.Size(930, 424);
            this.TourView.TabIndex = 27;
            this.TourView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TourView_CellContentClick);
            // 
            // Id_Tour
            // 
            this.Id_Tour.HeaderText = "Mã Tour";
            this.Id_Tour.MinimumWidth = 6;
            this.Id_Tour.Name = "Id_Tour";
            this.Id_Tour.ReadOnly = true;
            // 
            // Ten_Tour
            // 
            this.Ten_Tour.HeaderText = "Tên Tour";
            this.Ten_Tour.MinimumWidth = 6;
            this.Ten_Tour.Name = "Ten_Tour";
            this.Ten_Tour.ReadOnly = true;
            // 
            // Dacdiem_Tour
            // 
            this.Dacdiem_Tour.HeaderText = "Mô tả";
            this.Dacdiem_Tour.MinimumWidth = 6;
            this.Dacdiem_Tour.Name = "Dacdiem_Tour";
            this.Dacdiem_Tour.ReadOnly = true;
            // 
            // txtTour
            // 
            this.txtTour.Location = new System.Drawing.Point(207, 95);
            this.txtTour.Name = "txtTour";
            this.txtTour.ReadOnly = true;
            this.txtTour.Size = new System.Drawing.Size(225, 27);
            this.txtTour.TabIndex = 26;
            // 
            // numGia
            // 
            this.numGia.Location = new System.Drawing.Point(207, 150);
            this.numGia.Maximum = new decimal(new int[] {
            276447232,
            23283,
            0,
            0});
            this.numGia.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numGia.Name = "numGia";
            this.numGia.Size = new System.Drawing.Size(225, 27);
            this.numGia.TabIndex = 23;
            this.numGia.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numGia.ValueChanged += new System.EventHandler(this.numGia_ValueChanged);
            // 
            // txtNgayKetThuc
            // 
            this.txtNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.txtNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayKetThuc.Location = new System.Drawing.Point(647, 94);
            this.txtNgayKetThuc.Margin = new System.Windows.Forms.Padding(2);
            this.txtNgayKetThuc.Name = "txtNgayKetThuc";
            this.txtNgayKetThuc.Size = new System.Drawing.Size(317, 27);
            this.txtNgayKetThuc.TabIndex = 22;
            // 
            // txtNgayKhoiHanh
            // 
            this.txtNgayKhoiHanh.CustomFormat = "dd/MM/yyyy";
            this.txtNgayKhoiHanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayKhoiHanh.Location = new System.Drawing.Point(647, 43);
            this.txtNgayKhoiHanh.Margin = new System.Windows.Forms.Padding(2);
            this.txtNgayKhoiHanh.Name = "txtNgayKhoiHanh";
            this.txtNgayKhoiHanh.Size = new System.Drawing.Size(317, 27);
            this.txtNgayKhoiHanh.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(475, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "Ngày kết thúc";
            // 
            // Gia_lbl
            // 
            this.Gia_lbl.AutoSize = true;
            this.Gia_lbl.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Gia_lbl.Location = new System.Drawing.Point(34, 40);
            this.Gia_lbl.Name = "Gia_lbl";
            this.Gia_lbl.Size = new System.Drawing.Size(72, 25);
            this.Gia_lbl.TabIndex = 18;
            this.Gia_lbl.Text = "ID Giá";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(475, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "Ngày khởi hành";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(34, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 25);
            this.label12.TabIndex = 15;
            this.label12.Text = "Giá";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(34, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 25);
            this.label13.TabIndex = 14;
            this.label13.Text = "ID Tour";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(207, 41);
            this.txtGia.Name = "txtGia";
            this.txtGia.ReadOnly = true;
            this.txtGia.Size = new System.Drawing.Size(225, 27);
            this.txtGia.TabIndex = 12;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHuy.Location = new System.Drawing.Point(855, 134);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(109, 43);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // QuanLyGia_Them
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 676);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyGia_Them";
            this.Text = "QuanLyGia_Them";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TourView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView TourView;
        private System.Windows.Forms.TextBox txtTour;
        private System.Windows.Forms.NumericUpDown numGia;
        private System.Windows.Forms.DateTimePicker txtNgayKetThuc;
        private System.Windows.Forms.DateTimePicker txtNgayKhoiHanh;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label Gia_lbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Tour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_Tour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dacdiem_Tour;
    }
}