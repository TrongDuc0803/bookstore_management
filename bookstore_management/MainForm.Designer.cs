﻿namespace bookstore_management
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbSachLoaiSach = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSachTacGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSachTenSach = new System.Windows.Forms.TextBox();
            this.btnSachXoa = new System.Windows.Forms.Button();
            this.btnSachSua = new System.Windows.Forms.Button();
            this.btnSachThem = new System.Windows.Forms.Button();
            this.dgSach = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgHoaDon = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.numSachSoLuong = new System.Windows.Forms.NumericUpDown();
            this.numSachGiaBan = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateNgayLapHoaDon = new System.Windows.Forms.DateTimePicker();
            this.txtHoaDonTenKH = new System.Windows.Forms.TextBox();
            this.txtHoaDonSDTKH = new System.Windows.Forms.TextBox();
            this.btnHoaDonXoa = new System.Windows.Forms.Button();
            this.btnHoaDonSua = new System.Windows.Forms.Button();
            this.btnHoaDonThem = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPhieuNhapXoa = new System.Windows.Forms.Button();
            this.btnPhieuNhapSua = new System.Windows.Forms.Button();
            this.btnPhieuNhapThem = new System.Windows.Forms.Button();
            this.txtPhieuNhapNhaCungCap = new System.Windows.Forms.TextBox();
            this.dateNgayLapPhieuNhap = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSach)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHoaDon)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSachSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSachGiaBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(965, 506);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dgSach);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(957, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sách";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numSachGiaBan);
            this.panel1.Controls.Add(this.numSachSoLuong);
            this.panel1.Controls.Add(this.cbSachLoaiSach);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSachTacGia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSachTenSach);
            this.panel1.Controls.Add(this.btnSachXoa);
            this.panel1.Controls.Add(this.btnSachSua);
            this.panel1.Controls.Add(this.btnSachThem);
            this.panel1.Location = new System.Drawing.Point(7, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 153);
            this.panel1.TabIndex = 2;
            // 
            // cbSachLoaiSach
            // 
            this.cbSachLoaiSach.FormattingEnabled = true;
            this.cbSachLoaiSach.Location = new System.Drawing.Point(120, 64);
            this.cbSachLoaiSach.Name = "cbSachLoaiSach";
            this.cbSachLoaiSach.Size = new System.Drawing.Size(207, 28);
            this.cbSachLoaiSach.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Giá bán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Loại sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tác giả";
            // 
            // txtSachTacGia
            // 
            this.txtSachTacGia.Location = new System.Drawing.Point(445, 65);
            this.txtSachTacGia.Name = "txtSachTacGia";
            this.txtSachTacGia.Size = new System.Drawing.Size(230, 27);
            this.txtSachTacGia.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên sách";
            // 
            // txtSachTenSach
            // 
            this.txtSachTenSach.Location = new System.Drawing.Point(120, 10);
            this.txtSachTenSach.Name = "txtSachTenSach";
            this.txtSachTenSach.Size = new System.Drawing.Size(555, 27);
            this.txtSachTenSach.TabIndex = 3;
            // 
            // btnSachXoa
            // 
            this.btnSachXoa.Location = new System.Drawing.Point(796, 112);
            this.btnSachXoa.Name = "btnSachXoa";
            this.btnSachXoa.Size = new System.Drawing.Size(86, 29);
            this.btnSachXoa.TabIndex = 2;
            this.btnSachXoa.Text = "Xóa";
            this.btnSachXoa.UseVisualStyleBackColor = true;
            // 
            // btnSachSua
            // 
            this.btnSachSua.Location = new System.Drawing.Point(796, 64);
            this.btnSachSua.Name = "btnSachSua";
            this.btnSachSua.Size = new System.Drawing.Size(86, 29);
            this.btnSachSua.TabIndex = 1;
            this.btnSachSua.Text = "Sửa";
            this.btnSachSua.UseVisualStyleBackColor = true;
            // 
            // btnSachThem
            // 
            this.btnSachThem.Location = new System.Drawing.Point(796, 13);
            this.btnSachThem.Name = "btnSachThem";
            this.btnSachThem.Size = new System.Drawing.Size(86, 29);
            this.btnSachThem.TabIndex = 0;
            this.btnSachThem.Text = "Thêm";
            this.btnSachThem.UseVisualStyleBackColor = true;
            // 
            // dgSach
            // 
            this.dgSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSach.Location = new System.Drawing.Point(0, 6);
            this.dgSach.Name = "dgSach";
            this.dgSach.RowHeadersWidth = 51;
            this.dgSach.RowTemplate.Height = 24;
            this.dgSach.Size = new System.Drawing.Size(948, 285);
            this.dgSach.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(957, 473);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Loại sách";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.dgHoaDon);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(957, 473);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hóa Đơn";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgHoaDon
            // 
            this.dgHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHoaDon.Location = new System.Drawing.Point(6, 6);
            this.dgHoaDon.Name = "dgHoaDon";
            this.dgHoaDon.RowHeadersWidth = 51;
            this.dgHoaDon.RowTemplate.Height = 24;
            this.dgHoaDon.Size = new System.Drawing.Size(948, 285);
            this.dgHoaDon.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(957, 473);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Phiếu Nhập";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // numSachSoLuong
            // 
            this.numSachSoLuong.Location = new System.Drawing.Point(120, 112);
            this.numSachSoLuong.Name = "numSachSoLuong";
            this.numSachSoLuong.Size = new System.Drawing.Size(97, 27);
            this.numSachSoLuong.TabIndex = 11;
            // 
            // numSachGiaBan
            // 
            this.numSachGiaBan.Location = new System.Drawing.Point(466, 114);
            this.numSachGiaBan.Name = "numSachGiaBan";
            this.numSachGiaBan.Size = new System.Drawing.Size(209, 27);
            this.numSachGiaBan.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(947, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(7, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 121);
            this.panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(350, 27);
            this.textBox1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên loại sách";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "Thêm";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnHoaDonXoa);
            this.panel3.Controls.Add(this.btnHoaDonSua);
            this.panel3.Controls.Add(this.btnHoaDonThem);
            this.panel3.Controls.Add(this.txtHoaDonSDTKH);
            this.panel3.Controls.Add(this.txtHoaDonTenKH);
            this.panel3.Controls.Add(this.dateNgayLapHoaDon);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(6, 297);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(946, 170);
            this.panel3.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày lập hóa đơn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tên khách hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(506, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "SĐT Khách Hàng";
            // 
            // dateNgayLapHoaDon
            // 
            this.dateNgayLapHoaDon.Location = new System.Drawing.Point(211, 19);
            this.dateNgayLapHoaDon.Name = "dateNgayLapHoaDon";
            this.dateNgayLapHoaDon.Size = new System.Drawing.Size(336, 27);
            this.dateNgayLapHoaDon.TabIndex = 4;
            // 
            // txtHoaDonTenKH
            // 
            this.txtHoaDonTenKH.Location = new System.Drawing.Point(211, 72);
            this.txtHoaDonTenKH.Name = "txtHoaDonTenKH";
            this.txtHoaDonTenKH.Size = new System.Drawing.Size(262, 27);
            this.txtHoaDonTenKH.TabIndex = 5;
            // 
            // txtHoaDonSDTKH
            // 
            this.txtHoaDonSDTKH.Location = new System.Drawing.Point(666, 72);
            this.txtHoaDonSDTKH.Name = "txtHoaDonSDTKH";
            this.txtHoaDonSDTKH.Size = new System.Drawing.Size(187, 27);
            this.txtHoaDonSDTKH.TabIndex = 6;
            // 
            // btnHoaDonXoa
            // 
            this.btnHoaDonXoa.Location = new System.Drawing.Point(582, 120);
            this.btnHoaDonXoa.Name = "btnHoaDonXoa";
            this.btnHoaDonXoa.Size = new System.Drawing.Size(86, 29);
            this.btnHoaDonXoa.TabIndex = 9;
            this.btnHoaDonXoa.Text = "Xóa";
            this.btnHoaDonXoa.UseVisualStyleBackColor = true;
            // 
            // btnHoaDonSua
            // 
            this.btnHoaDonSua.Location = new System.Drawing.Point(405, 120);
            this.btnHoaDonSua.Name = "btnHoaDonSua";
            this.btnHoaDonSua.Size = new System.Drawing.Size(86, 29);
            this.btnHoaDonSua.TabIndex = 8;
            this.btnHoaDonSua.Text = "Sửa";
            this.btnHoaDonSua.UseVisualStyleBackColor = true;
            // 
            // btnHoaDonThem
            // 
            this.btnHoaDonThem.Location = new System.Drawing.Point(226, 120);
            this.btnHoaDonThem.Name = "btnHoaDonThem";
            this.btnHoaDonThem.Size = new System.Drawing.Size(86, 29);
            this.btnHoaDonThem.TabIndex = 7;
            this.btnHoaDonThem.Text = "Thêm";
            this.btnHoaDonThem.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnPhieuNhapXoa);
            this.panel4.Controls.Add(this.btnPhieuNhapSua);
            this.panel4.Controls.Add(this.btnPhieuNhapThem);
            this.panel4.Controls.Add(this.txtPhieuNhapNhaCungCap);
            this.panel4.Controls.Add(this.dateNgayLapPhieuNhap);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(4, 297);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(946, 170);
            this.panel4.TabIndex = 3;
            // 
            // btnPhieuNhapXoa
            // 
            this.btnPhieuNhapXoa.Location = new System.Drawing.Point(582, 120);
            this.btnPhieuNhapXoa.Name = "btnPhieuNhapXoa";
            this.btnPhieuNhapXoa.Size = new System.Drawing.Size(86, 29);
            this.btnPhieuNhapXoa.TabIndex = 9;
            this.btnPhieuNhapXoa.Text = "Xóa";
            this.btnPhieuNhapXoa.UseVisualStyleBackColor = true;
            // 
            // btnPhieuNhapSua
            // 
            this.btnPhieuNhapSua.Location = new System.Drawing.Point(405, 120);
            this.btnPhieuNhapSua.Name = "btnPhieuNhapSua";
            this.btnPhieuNhapSua.Size = new System.Drawing.Size(86, 29);
            this.btnPhieuNhapSua.TabIndex = 8;
            this.btnPhieuNhapSua.Text = "Sửa";
            this.btnPhieuNhapSua.UseVisualStyleBackColor = true;
            // 
            // btnPhieuNhapThem
            // 
            this.btnPhieuNhapThem.Location = new System.Drawing.Point(226, 120);
            this.btnPhieuNhapThem.Name = "btnPhieuNhapThem";
            this.btnPhieuNhapThem.Size = new System.Drawing.Size(86, 29);
            this.btnPhieuNhapThem.TabIndex = 7;
            this.btnPhieuNhapThem.Text = "Thêm";
            this.btnPhieuNhapThem.UseVisualStyleBackColor = true;
            // 
            // txtPhieuNhapNhaCungCap
            // 
            this.txtPhieuNhapNhaCungCap.Location = new System.Drawing.Point(666, 10);
            this.txtPhieuNhapNhaCungCap.Name = "txtPhieuNhapNhaCungCap";
            this.txtPhieuNhapNhaCungCap.Size = new System.Drawing.Size(262, 27);
            this.txtPhieuNhapNhaCungCap.TabIndex = 5;
            // 
            // dateNgayLapPhieuNhap
            // 
            this.dateNgayLapPhieuNhap.Location = new System.Drawing.Point(203, 12);
            this.dateNgayLapPhieuNhap.Name = "dateNgayLapPhieuNhap";
            this.dateNgayLapPhieuNhap.Size = new System.Drawing.Size(288, 27);
            this.dateNgayLapPhieuNhap.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(517, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tên Nhà Cung Cấp";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Ngày Lập Phiếu Nhập";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(957, 285);
            this.dataGridView2.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 549);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSach)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgHoaDon)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSachSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSachGiaBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgSach;
        private System.Windows.Forms.DataGridView dgHoaDon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSachTenSach;
        private System.Windows.Forms.Button btnSachXoa;
        private System.Windows.Forms.Button btnSachSua;
        private System.Windows.Forms.Button btnSachThem;
        private System.Windows.Forms.ComboBox cbSachLoaiSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSachTacGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numSachGiaBan;
        private System.Windows.Forms.NumericUpDown numSachSoLuong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtHoaDonSDTKH;
        private System.Windows.Forms.TextBox txtHoaDonTenKH;
        private System.Windows.Forms.DateTimePicker dateNgayLapHoaDon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnHoaDonXoa;
        private System.Windows.Forms.Button btnHoaDonSua;
        private System.Windows.Forms.Button btnHoaDonThem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnPhieuNhapXoa;
        private System.Windows.Forms.Button btnPhieuNhapSua;
        private System.Windows.Forms.Button btnPhieuNhapThem;
        private System.Windows.Forms.TextBox txtPhieuNhapNhaCungCap;
        private System.Windows.Forms.DateTimePicker dateNgayLapPhieuNhap;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}