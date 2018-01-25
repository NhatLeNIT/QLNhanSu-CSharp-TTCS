namespace ThucTapCoSo
{
    partial class frmEmployeeManagement
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
            this.grThongTinNhanVien = new System.Windows.Forms.GroupBox();
            this.txtHeSoLuong = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.msdsNhanVien = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Office = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grSapXep = new System.Windows.Forms.GroupBox();
            this.btnThucHienSapXep = new System.Windows.Forms.Button();
            this.rbtnGiamDan = new System.Windows.Forms.RadioButton();
            this.rbtnTangDan = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbTieuChiSapXep = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grTimKiem = new System.Windows.Forms.GroupBox();
            this.btnThucHienTimKiem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNoiDungTim = new System.Windows.Forms.TextBox();
            this.grXoa = new System.Windows.Forms.GroupBox();
            this.btnThucHienXoa = new System.Windows.Forms.Button();
            this.txtTuKhoaXoa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLuuLai = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btn_DocLaiFile = new System.Windows.Forms.Button();
            this.grThongTinNhanVien.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msdsNhanVien)).BeginInit();
            this.grSapXep.SuspendLayout();
            this.grTimKiem.SuspendLayout();
            this.grXoa.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grThongTinNhanVien
            // 
            this.grThongTinNhanVien.Controls.Add(this.txtHeSoLuong);
            this.grThongTinNhanVien.Controls.Add(this.btnThem);
            this.grThongTinNhanVien.Controls.Add(this.label4);
            this.grThongTinNhanVien.Controls.Add(this.cbbChucVu);
            this.grThongTinNhanVien.Controls.Add(this.label3);
            this.grThongTinNhanVien.Controls.Add(this.dpNgaySinh);
            this.grThongTinNhanVien.Controls.Add(this.label2);
            this.grThongTinNhanVien.Controls.Add(this.label1);
            this.grThongTinNhanVien.Controls.Add(this.txtHoTen);
            this.grThongTinNhanVien.Location = new System.Drawing.Point(18, 20);
            this.grThongTinNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grThongTinNhanVien.Name = "grThongTinNhanVien";
            this.grThongTinNhanVien.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grThongTinNhanVien.Size = new System.Drawing.Size(690, 120);
            this.grThongTinNhanVien.TabIndex = 0;
            this.grThongTinNhanVien.TabStop = false;
            this.grThongTinNhanVien.Text = "Thông tin nhân viên";
            // 
            // txtHeSoLuong
            // 
            this.txtHeSoLuong.Location = new System.Drawing.Point(441, 76);
            this.txtHeSoLuong.Name = "txtHeSoLuong";
            this.txtHeSoLuong.Size = new System.Drawing.Size(129, 30);
            this.txtHeSoLuong.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(587, 44);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 41);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hệ số lương:";
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Location = new System.Drawing.Point(99, 74);
            this.cbbChucVu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(212, 33);
            this.cbbChucVu.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chức vụ:";
            // 
            // dpNgaySinh
            // 
            this.dpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpNgaySinh.Location = new System.Drawing.Point(441, 29);
            this.dpNgaySinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dpNgaySinh.Name = "dpNgaySinh";
            this.dpNgaySinh.Size = new System.Drawing.Size(129, 30);
            this.dpNgaySinh.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ngày sinh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(99, 29);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(212, 30);
            this.txtHoTen.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.msdsNhanVien);
            this.groupBox2.Location = new System.Drawing.Point(15, 175);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(693, 412);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên";
            // 
            // msdsNhanVien
            // 
            this.msdsNhanVien.AllowUserToAddRows = false;
            this.msdsNhanVien.AllowUserToDeleteRows = false;
            this.msdsNhanVien.AllowUserToOrderColumns = true;
            this.msdsNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msdsNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.FullName,
            this.Office,
            this.Birthday,
            this.Salary});
            this.msdsNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msdsNhanVien.Location = new System.Drawing.Point(2, 25);
            this.msdsNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.msdsNhanVien.Name = "msdsNhanVien";
            this.msdsNhanVien.Size = new System.Drawing.Size(689, 385);
            this.msdsNhanVien.TabIndex = 0;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 81;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.FillWeight = 145F;
            this.FullName.HeaderText = "Họ tên";
            this.FullName.Name = "FullName";
            // 
            // Office
            // 
            this.Office.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Office.FillWeight = 120F;
            this.Office.HeaderText = "Chức vụ";
            this.Office.Name = "Office";
            // 
            // Birthday
            // 
            this.Birthday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Birthday.HeaderText = "Ngày sinh";
            this.Birthday.Name = "Birthday";
            // 
            // Salary
            // 
            this.Salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Salary.HeaderText = "Hệ số lương";
            this.Salary.Name = "Salary";
            this.Salary.Width = 119;
            // 
            // grSapXep
            // 
            this.grSapXep.Controls.Add(this.btnThucHienSapXep);
            this.grSapXep.Controls.Add(this.rbtnGiamDan);
            this.grSapXep.Controls.Add(this.rbtnTangDan);
            this.grSapXep.Controls.Add(this.label6);
            this.grSapXep.Controls.Add(this.cbbTieuChiSapXep);
            this.grSapXep.Controls.Add(this.label5);
            this.grSapXep.Location = new System.Drawing.Point(763, 19);
            this.grSapXep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grSapXep.Name = "grSapXep";
            this.grSapXep.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grSapXep.Size = new System.Drawing.Size(338, 156);
            this.grSapXep.TabIndex = 2;
            this.grSapXep.TabStop = false;
            this.grSapXep.Text = "Sắp xếp";
            // 
            // btnThucHienSapXep
            // 
            this.btnThucHienSapXep.Location = new System.Drawing.Point(138, 101);
            this.btnThucHienSapXep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThucHienSapXep.Name = "btnThucHienSapXep";
            this.btnThucHienSapXep.Size = new System.Drawing.Size(90, 41);
            this.btnThucHienSapXep.TabIndex = 9;
            this.btnThucHienSapXep.Text = "Thực hiện";
            this.btnThucHienSapXep.UseVisualStyleBackColor = true;
            this.btnThucHienSapXep.Click += new System.EventHandler(this.btnThucHienSapXep_Click);
            // 
            // rbtnGiamDan
            // 
            this.rbtnGiamDan.AutoSize = true;
            this.rbtnGiamDan.Location = new System.Drawing.Point(220, 68);
            this.rbtnGiamDan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnGiamDan.Name = "rbtnGiamDan";
            this.rbtnGiamDan.Size = new System.Drawing.Size(117, 29);
            this.rbtnGiamDan.TabIndex = 4;
            this.rbtnGiamDan.TabStop = true;
            this.rbtnGiamDan.Text = "Giảm dần";
            this.rbtnGiamDan.UseVisualStyleBackColor = true;
            // 
            // rbtnTangDan
            // 
            this.rbtnTangDan.AutoSize = true;
            this.rbtnTangDan.Checked = true;
            this.rbtnTangDan.Location = new System.Drawing.Point(118, 68);
            this.rbtnTangDan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbtnTangDan.Name = "rbtnTangDan";
            this.rbtnTangDan.Size = new System.Drawing.Size(117, 29);
            this.rbtnTangDan.TabIndex = 3;
            this.rbtnTangDan.TabStop = true;
            this.rbtnTangDan.Text = "Tăng dần";
            this.rbtnTangDan.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Kiểu sắp xếp:";
            // 
            // cbbTieuChiSapXep
            // 
            this.cbbTieuChiSapXep.FormattingEnabled = true;
            this.cbbTieuChiSapXep.Items.AddRange(new object[] {
            "Họ tên",
            "Chức vụ",
            "Ngày sinh",
            "Hệ số lương"});
            this.cbbTieuChiSapXep.Location = new System.Drawing.Point(137, 18);
            this.cbbTieuChiSapXep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbbTieuChiSapXep.Name = "cbbTieuChiSapXep";
            this.cbbTieuChiSapXep.Size = new System.Drawing.Size(176, 33);
            this.cbbTieuChiSapXep.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tiêu chí sắp xếp:";
            // 
            // grTimKiem
            // 
            this.grTimKiem.Controls.Add(this.btnThucHienTimKiem);
            this.grTimKiem.Controls.Add(this.label8);
            this.grTimKiem.Controls.Add(this.txtNoiDungTim);
            this.grTimKiem.Location = new System.Drawing.Point(763, 198);
            this.grTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grTimKiem.Name = "grTimKiem";
            this.grTimKiem.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grTimKiem.Size = new System.Drawing.Size(338, 129);
            this.grTimKiem.TabIndex = 3;
            this.grTimKiem.TabStop = false;
            this.grTimKiem.Text = "Tìm kiếm";
            // 
            // btnThucHienTimKiem
            // 
            this.btnThucHienTimKiem.Location = new System.Drawing.Point(134, 74);
            this.btnThucHienTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThucHienTimKiem.Name = "btnThucHienTimKiem";
            this.btnThucHienTimKiem.Size = new System.Drawing.Size(90, 41);
            this.btnThucHienTimKiem.TabIndex = 10;
            this.btnThucHienTimKiem.Text = "Thực hiện";
            this.btnThucHienTimKiem.UseVisualStyleBackColor = true;
            this.btnThucHienTimKiem.Click += new System.EventHandler(this.btnThucHienTimKiem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Nội dung tìm:";
            // 
            // txtNoiDungTim
            // 
            this.txtNoiDungTim.Location = new System.Drawing.Point(133, 31);
            this.txtNoiDungTim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNoiDungTim.Name = "txtNoiDungTim";
            this.txtNoiDungTim.Size = new System.Drawing.Size(176, 30);
            this.txtNoiDungTim.TabIndex = 2;
            // 
            // grXoa
            // 
            this.grXoa.Controls.Add(this.btnThucHienXoa);
            this.grXoa.Controls.Add(this.txtTuKhoaXoa);
            this.grXoa.Controls.Add(this.label9);
            this.grXoa.Location = new System.Drawing.Point(763, 356);
            this.grXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grXoa.Name = "grXoa";
            this.grXoa.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grXoa.Size = new System.Drawing.Size(338, 119);
            this.grXoa.TabIndex = 4;
            this.grXoa.TabStop = false;
            this.grXoa.Text = "Xóa nhân viên";
            // 
            // btnThucHienXoa
            // 
            this.btnThucHienXoa.Location = new System.Drawing.Point(138, 68);
            this.btnThucHienXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThucHienXoa.Name = "btnThucHienXoa";
            this.btnThucHienXoa.Size = new System.Drawing.Size(90, 41);
            this.btnThucHienXoa.TabIndex = 11;
            this.btnThucHienXoa.Text = "Thực hiện";
            this.btnThucHienXoa.UseVisualStyleBackColor = true;
            this.btnThucHienXoa.Click += new System.EventHandler(this.btnThucHienXoa_Click);
            // 
            // txtTuKhoaXoa
            // 
            this.txtTuKhoaXoa.Location = new System.Drawing.Point(137, 21);
            this.txtTuKhoaXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTuKhoaXoa.Name = "txtTuKhoaXoa";
            this.txtTuKhoaXoa.Size = new System.Drawing.Size(176, 30);
            this.txtTuKhoaXoa.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Từ khóa:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_DocLaiFile);
            this.groupBox1.Controls.Add(this.btnLuuLai);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Location = new System.Drawing.Point(763, 499);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(338, 96);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btnLuuLai
            // 
            this.btnLuuLai.Location = new System.Drawing.Point(229, 38);
            this.btnLuuLai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuuLai.Name = "btnLuuLai";
            this.btnLuuLai.Size = new System.Drawing.Size(90, 41);
            this.btnLuuLai.TabIndex = 13;
            this.btnLuuLai.Text = "Lưu lại";
            this.btnLuuLai.UseVisualStyleBackColor = true;
            this.btnLuuLai.Click += new System.EventHandler(this.btnLuuLai_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(15, 38);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(90, 41);
            this.btnLamMoi.TabIndex = 12;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btn_DocLaiFile
            // 
            this.btn_DocLaiFile.Location = new System.Drawing.Point(123, 38);
            this.btn_DocLaiFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_DocLaiFile.Name = "btn_DocLaiFile";
            this.btn_DocLaiFile.Size = new System.Drawing.Size(90, 41);
            this.btn_DocLaiFile.TabIndex = 14;
            this.btn_DocLaiFile.Text = "Đọc lại";
            this.btn_DocLaiFile.UseVisualStyleBackColor = true;
            this.btn_DocLaiFile.Click += new System.EventHandler(this.btn_DocLaiFile_Click);
            // 
            // frmEmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grXoa);
            this.Controls.Add(this.grTimKiem);
            this.Controls.Add(this.grSapXep);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grThongTinNhanVien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEmployeeManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhân Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEmployeeManagement_FormClosing);
            this.Load += new System.EventHandler(this.frmEmployeeManagement_Load);
            this.grThongTinNhanVien.ResumeLayout(false);
            this.grThongTinNhanVien.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msdsNhanVien)).EndInit();
            this.grSapXep.ResumeLayout(false);
            this.grSapXep.PerformLayout();
            this.grTimKiem.ResumeLayout(false);
            this.grTimKiem.PerformLayout();
            this.grXoa.ResumeLayout(false);
            this.grXoa.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grThongTinNhanVien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbChucVu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dpNgaySinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView msdsNhanVien;
        private System.Windows.Forms.GroupBox grSapXep;
        private System.Windows.Forms.Button btnThucHienSapXep;
        private System.Windows.Forms.RadioButton rbtnGiamDan;
        private System.Windows.Forms.RadioButton rbtnTangDan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbTieuChiSapXep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grTimKiem;
        private System.Windows.Forms.Button btnThucHienTimKiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNoiDungTim;
        private System.Windows.Forms.GroupBox grXoa;
        private System.Windows.Forms.Button btnThucHienXoa;
        private System.Windows.Forms.TextBox txtTuKhoaXoa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLuuLai;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtHeSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Office;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.Button btn_DocLaiFile;
    }
}