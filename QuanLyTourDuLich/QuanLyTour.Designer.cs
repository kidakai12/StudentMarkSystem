﻿
namespace QuanLyTourDuLich
{
    partial class QuanLyTour
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyTour));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SearchBox_cb = new System.Windows.Forms.ComboBox();
            this.SearchTour_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.Grid_Danhsachtour = new System.Windows.Forms.DataGridView();
            this.Id_Tour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_Tour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiTour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Danhsachtour)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 845);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Controls.Add(this.SearchBox_cb);
            this.panel3.Controls.Add(this.SearchTour_txt);
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel3.Location = new System.Drawing.Point(574, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(507, 59);
            this.panel3.TabIndex = 8;
            // 
            // SearchBox_cb
            // 
            this.SearchBox_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchBox_cb.Location = new System.Drawing.Point(343, 13);
            this.SearchBox_cb.Name = "SearchBox_cb";
            this.SearchBox_cb.Size = new System.Drawing.Size(151, 34);
            this.SearchBox_cb.TabIndex = 0;
            // 
            // SearchTour_txt
            // 
            this.SearchTour_txt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchTour_txt.Location = new System.Drawing.Point(22, 13);
            this.SearchTour_txt.Name = "SearchTour_txt";
            this.SearchTour_txt.Size = new System.Drawing.Size(302, 34);
            this.SearchTour_txt.TabIndex = 3;
            this.SearchTour_txt.TextChanged += new System.EventHandler(this.SearchTour_txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "Trang Quản Lý Tour";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.Grid_Danhsachtour);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 756);
            this.panel2.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(779, 10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(149, 45);
            this.button6.TabIndex = 11;
            this.button6.Text = "      Thống kê";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Grid_Danhsachtour
            // 
            this.Grid_Danhsachtour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Danhsachtour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Danhsachtour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Tour,
            this.Ten_Tour,
            this.MoTa,
            this.LoaiTour});
            this.Grid_Danhsachtour.Location = new System.Drawing.Point(11, 64);
            this.Grid_Danhsachtour.Name = "Grid_Danhsachtour";
            this.Grid_Danhsachtour.RowHeadersWidth = 51;
            this.Grid_Danhsachtour.RowTemplate.Height = 29;
            this.Grid_Danhsachtour.Size = new System.Drawing.Size(1057, 682);
            this.Grid_Danhsachtour.TabIndex = 10;
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
            // MoTa
            // 
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            // 
            // LoaiTour
            // 
            this.LoaiTour.HeaderText = "Loại Tour";
            this.LoaiTour.MinimumWidth = 6;
            this.LoaiTour.Name = "LoaiTour";
            this.LoaiTour.ReadOnly = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(945, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 45);
            this.button5.TabIndex = 9;
            this.button5.Text = "      Reload";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(639, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 45);
            this.button4.TabIndex = 8;
            this.button4.Text = "      Chi tiết";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(503, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 45);
            this.button3.TabIndex = 7;
            this.button3.Text = "    Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(368, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 45);
            this.button2.TabIndex = 6;
            this.button2.Text = "     Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(231, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "      Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danh sách Tour";
            // 
            // QuanLyTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1100, 855);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyTour";
            this.Text = "QuanLyTour";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Danhsachtour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Grid_Danhsachtour;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox SearchBox_cb;
        private System.Windows.Forms.TextBox SearchTour_txt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Tour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_Tour;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiTour;
        private System.Windows.Forms.Button button6;
    }
}