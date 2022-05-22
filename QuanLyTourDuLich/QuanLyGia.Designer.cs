
namespace QuanLyTourDuLich
{
    partial class QuanLyGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyGia));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.GiaView = new System.Windows.Forms.DataGridView();
            this.Id_Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Tour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thoigianbatdau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thoigianketthuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numdown = new System.Windows.Forms.NumericUpDown();
            this.lblTo = new System.Windows.Forms.Label();
            this.numup = new System.Windows.Forms.NumericUpDown();
            this.timepickup = new System.Windows.Forms.DateTimePicker();
            this.timepickdown = new System.Windows.Forms.DateTimePicker();
            this.SearchBox_cb = new System.Windows.Forms.ComboBox();
            this.SearchGia_txt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GiaView)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numup)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 845);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 38);
            this.label1.TabIndex = 12;
            this.label1.Text = "Trang Quản Lý Giá";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.GiaView);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 756);
            this.panel2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(816, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 45);
            this.button3.TabIndex = 14;
            this.button3.Text = "    Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // GiaView
            // 
            this.GiaView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GiaView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GiaView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Gia,
            this.Id_Tour,
            this.Gia,
            this.Thoigianbatdau,
            this.Thoigianketthuc});
            this.GiaView.Location = new System.Drawing.Point(11, 64);
            this.GiaView.Name = "GiaView";
            this.GiaView.RowHeadersWidth = 51;
            this.GiaView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GiaView.RowTemplate.Height = 29;
            this.GiaView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GiaView.Size = new System.Drawing.Size(1057, 682);
            this.GiaView.TabIndex = 0;
            // 
            // Id_Gia
            // 
            this.Id_Gia.HeaderText = "Mã Giá";
            this.Id_Gia.MinimumWidth = 6;
            this.Id_Gia.Name = "Id_Gia";
            this.Id_Gia.ReadOnly = true;
            // 
            // Id_Tour
            // 
            this.Id_Tour.HeaderText = "Mã Tour";
            this.Id_Tour.MinimumWidth = 6;
            this.Id_Tour.Name = "Id_Tour";
            this.Id_Tour.ReadOnly = true;
            // 
            // Gia
            // 
            this.Gia.HeaderText = "Giá (VNĐ)";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            // 
            // Thoigianbatdau
            // 
            this.Thoigianbatdau.HeaderText = "Thời gian bắt đầu";
            this.Thoigianbatdau.MinimumWidth = 6;
            this.Thoigianbatdau.Name = "Thoigianbatdau";
            this.Thoigianbatdau.ReadOnly = true;
            // 
            // Thoigianketthuc
            // 
            this.Thoigianketthuc.HeaderText = "Thời gian kết thúc";
            this.Thoigianketthuc.MinimumWidth = 6;
            this.Thoigianketthuc.Name = "Thoigianketthuc";
            this.Thoigianketthuc.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(681, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 45);
            this.button2.TabIndex = 13;
            this.button2.Text = "     Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(544, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "      Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(948, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 45);
            this.button5.TabIndex = 17;
            this.button5.Text = "      Reload";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Danh sách Giá";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.numdown);
            this.panel3.Controls.Add(this.lblTo);
            this.panel3.Controls.Add(this.numup);
            this.panel3.Controls.Add(this.timepickup);
            this.panel3.Controls.Add(this.timepickdown);
            this.panel3.Controls.Add(this.SearchBox_cb);
            this.panel3.Controls.Add(this.SearchGia_txt);
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel3.Location = new System.Drawing.Point(322, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(758, 59);
            this.panel3.TabIndex = 15;
            // 
            // numdown
            // 
            this.numdown.Location = new System.Drawing.Point(18, 13);
            this.numdown.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numdown.Name = "numdown";
            this.numdown.Size = new System.Drawing.Size(250, 34);
            this.numdown.TabIndex = 8;
            this.numdown.Visible = false;
            this.numdown.ValueChanged += new System.EventHandler(this.numsearch_ValueChanged);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(274, 19);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(38, 27);
            this.lblTo.TabIndex = 7;
            this.lblTo.Text = "tới";
            this.lblTo.Visible = false;
            // 
            // numup
            // 
            this.numup.Location = new System.Drawing.Point(326, 13);
            this.numup.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numup.Name = "numup";
            this.numup.Size = new System.Drawing.Size(249, 34);
            this.numup.TabIndex = 6;
            this.numup.Value = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numup.Visible = false;
            this.numup.ValueChanged += new System.EventHandler(this.numsearch_ValueChanged);
            // 
            // timepickup
            // 
            this.timepickup.Checked = false;
            this.timepickup.CustomFormat = "dd/MM/yyyy";
            this.timepickup.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timepickup.Location = new System.Drawing.Point(326, 13);
            this.timepickup.Name = "timepickup";
            this.timepickup.Size = new System.Drawing.Size(250, 34);
            this.timepickup.TabIndex = 5;
            this.timepickup.Value = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timepickup.Visible = false;
            this.timepickup.ValueChanged += new System.EventHandler(this.timepickup_ValueChanged);
            // 
            // timepickdown
            // 
            this.timepickdown.CustomFormat = "dd/MM/yyyy";
            this.timepickdown.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timepickdown.Location = new System.Drawing.Point(18, 13);
            this.timepickdown.Name = "timepickdown";
            this.timepickdown.Size = new System.Drawing.Size(250, 34);
            this.timepickdown.TabIndex = 4;
            this.timepickdown.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timepickdown.Visible = false;
            this.timepickdown.ValueChanged += new System.EventHandler(this.timepickup_ValueChanged);
            // 
            // SearchBox_cb
            // 
            this.SearchBox_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchBox_cb.Location = new System.Drawing.Point(595, 13);
            this.SearchBox_cb.Name = "SearchBox_cb";
            this.SearchBox_cb.Size = new System.Drawing.Size(151, 34);
            this.SearchBox_cb.TabIndex = 0;
            this.SearchBox_cb.SelectedIndexChanged += new System.EventHandler(this.SearchBox_cb_SelectedIndexChanged);
            // 
            // SearchGia_txt
            // 
            this.SearchGia_txt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchGia_txt.Location = new System.Drawing.Point(274, 13);
            this.SearchGia_txt.Name = "SearchGia_txt";
            this.SearchGia_txt.Size = new System.Drawing.Size(302, 34);
            this.SearchGia_txt.TabIndex = 3;
            this.SearchGia_txt.TextChanged += new System.EventHandler(this.SearchTour_txt_TextChanged);
            // 
            // QuanLyGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1100, 855);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyGia";
            this.Text = "QuanLyGia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GiaView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView GiaView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox SearchBox_cb;
        private System.Windows.Forms.TextBox SearchGia_txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Tour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thoigianbatdau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thoigianketthuc;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.NumericUpDown numup;
        private System.Windows.Forms.DateTimePicker timepickup;
        private System.Windows.Forms.DateTimePicker timepickdown;
        private System.Windows.Forms.NumericUpDown numdown;
    }
}