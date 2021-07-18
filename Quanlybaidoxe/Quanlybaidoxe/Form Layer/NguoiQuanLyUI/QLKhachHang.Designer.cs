
namespace Quanlybaidoxe.Form_Layer.NguoiQuanLyUI
{
    partial class QLKhachHang
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlQuanLyKH = new System.Windows.Forms.Panel();
            this.dateTimePickerHetHan = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.dateTimePickerKH = new System.Windows.Forms.DateTimePicker();
            this.cbVeThang = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUuDai = new System.Windows.Forms.Label();
            this.txtGioToiDa = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGioToiThieu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.dgvQLKhachHang = new System.Windows.Forms.DataGridView();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.cboTimKiem = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGiaHan = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlQuanLyKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(349, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 50);
            this.label1.TabIndex = 41;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // pnlQuanLyKH
            // 
            this.pnlQuanLyKH.Controls.Add(this.dateTimePickerHetHan);
            this.pnlQuanLyKH.Controls.Add(this.label10);
            this.pnlQuanLyKH.Controls.Add(this.txtSDT);
            this.pnlQuanLyKH.Controls.Add(this.dateTimePickerKH);
            this.pnlQuanLyKH.Controls.Add(this.cbVeThang);
            this.pnlQuanLyKH.Controls.Add(this.label7);
            this.pnlQuanLyKH.Controls.Add(this.radNu);
            this.pnlQuanLyKH.Controls.Add(this.radNam);
            this.pnlQuanLyKH.Controls.Add(this.label6);
            this.pnlQuanLyKH.Controls.Add(this.txtUuDai);
            this.pnlQuanLyKH.Controls.Add(this.txtGioToiDa);
            this.pnlQuanLyKH.Controls.Add(this.label5);
            this.pnlQuanLyKH.Controls.Add(this.txtGioToiThieu);
            this.pnlQuanLyKH.Controls.Add(this.label4);
            this.pnlQuanLyKH.Controls.Add(this.txtDiaChi);
            this.pnlQuanLyKH.Controls.Add(this.label3);
            this.pnlQuanLyKH.Controls.Add(this.label2);
            this.pnlQuanLyKH.Controls.Add(this.txtMaXe);
            this.pnlQuanLyKH.Controls.Add(this.txtCMND);
            this.pnlQuanLyKH.Controls.Add(this.txtTenKH);
            this.pnlQuanLyKH.Controls.Add(this.txtMaKH);
            this.pnlQuanLyKH.Location = new System.Drawing.Point(2, 71);
            this.pnlQuanLyKH.Margin = new System.Windows.Forms.Padding(4);
            this.pnlQuanLyKH.Name = "pnlQuanLyKH";
            this.pnlQuanLyKH.Size = new System.Drawing.Size(1180, 290);
            this.pnlQuanLyKH.TabIndex = 49;
            this.pnlQuanLyKH.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.pnlQuanLyKH_ControlRemoved);
            // 
            // dateTimePickerHetHan
            // 
            this.dateTimePickerHetHan.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHetHan.Location = new System.Drawing.Point(848, 238);
            this.dateTimePickerHetHan.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerHetHan.Name = "dateTimePickerHetHan";
            this.dateTimePickerHetHan.Size = new System.Drawing.Size(314, 31);
            this.dateTimePickerHetHan.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(621, 80);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 31);
            this.label10.TabIndex = 25;
            this.label10.Text = "Số điện thoại:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(848, 80);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(314, 31);
            this.txtSDT.TabIndex = 8;
            this.txtSDT.Validating += new System.ComponentModel.CancelEventHandler(this.txtSDT_Validating);
            // 
            // dateTimePickerKH
            // 
            this.dateTimePickerKH.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerKH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerKH.Location = new System.Drawing.Point(212, 148);
            this.dateTimePickerKH.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerKH.Name = "dateTimePickerKH";
            this.dateTimePickerKH.Size = new System.Drawing.Size(314, 31);
            this.dateTimePickerKH.TabIndex = 3;
            this.dateTimePickerKH.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePickerKH_Validating);
            // 
            // cbVeThang
            // 
            this.cbVeThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVeThang.FormattingEnabled = true;
            this.cbVeThang.Location = new System.Drawing.Point(849, 190);
            this.cbVeThang.Margin = new System.Windows.Forms.Padding(2);
            this.cbVeThang.Name = "cbVeThang";
            this.cbVeThang.Size = new System.Drawing.Size(313, 33);
            this.cbVeThang.TabIndex = 10;
            this.cbVeThang.SelectedIndexChanged += new System.EventHandler(this.cbVeThang_SelectedIndexChanged);
            this.cbVeThang.Validating += new System.ComponentModel.CancelEventHandler(this.cbVeThang_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(622, 190);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 31);
            this.label7.TabIndex = 26;
            this.label7.Text = "Loại vé tháng:";
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(464, 201);
            this.radNu.Margin = new System.Windows.Forms.Padding(4);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(57, 29);
            this.radNu.TabIndex = 5;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Location = new System.Drawing.Point(212, 201);
            this.radNam.Margin = new System.Windows.Forms.Padding(4);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(71, 29);
            this.radNam.TabIndex = 4;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(4, 199);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 31);
            this.label6.TabIndex = 26;
            this.label6.Text = "Giới tính:";
            // 
            // txtUuDai
            // 
            this.txtUuDai.AutoSize = true;
            this.txtUuDai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtUuDai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.txtUuDai.Location = new System.Drawing.Point(4, 138);
            this.txtUuDai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtUuDai.Name = "txtUuDai";
            this.txtUuDai.Size = new System.Drawing.Size(127, 31);
            this.txtUuDai.TabIndex = 26;
            this.txtUuDai.Text = "Ngày sinh:";
            // 
            // txtGioToiDa
            // 
            this.txtGioToiDa.AutoSize = true;
            this.txtGioToiDa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtGioToiDa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.txtGioToiDa.Location = new System.Drawing.Point(622, 238);
            this.txtGioToiDa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtGioToiDa.Name = "txtGioToiDa";
            this.txtGioToiDa.Size = new System.Drawing.Size(163, 31);
            this.txtGioToiDa.TabIndex = 26;
            this.txtGioToiDa.Text = "Ngày hết hạn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(622, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 31);
            this.label5.TabIndex = 26;
            this.label5.Text = "Mã xe:";
            // 
            // txtGioToiThieu
            // 
            this.txtGioToiThieu.AutoSize = true;
            this.txtGioToiThieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtGioToiThieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.txtGioToiThieu.Location = new System.Drawing.Point(622, 26);
            this.txtGioToiThieu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtGioToiThieu.Name = "txtGioToiThieu";
            this.txtGioToiThieu.Size = new System.Drawing.Size(94, 31);
            this.txtGioToiThieu.TabIndex = 25;
            this.txtGioToiThieu.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(4, 249);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 31);
            this.label4.TabIndex = 25;
            this.label4.Text = "CMND:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(848, 26);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(313, 39);
            this.txtDiaChi.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(1, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 31);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tên khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(1, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 31);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mã khách hàng:";
            // 
            // txtMaXe
            // 
            this.txtMaXe.Location = new System.Drawing.Point(849, 136);
            this.txtMaXe.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.PlaceholderText = "Nhấp để đăng ký xe";
            this.txtMaXe.Size = new System.Drawing.Size(313, 31);
            this.txtMaXe.TabIndex = 9;
            this.txtMaXe.Click += new System.EventHandler(this.txtMaXe_Click);
            this.txtMaXe.TextChanged += new System.EventHandler(this.txtMaXe_TextChanged);
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(211, 250);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(314, 31);
            this.txtCMND.TabIndex = 6;
            this.txtCMND.Validating += new System.ComponentModel.CancelEventHandler(this.txtCMND_Validating);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(212, 85);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(313, 31);
            this.txtTenKH.TabIndex = 2;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(211, 26);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(314, 31);
            this.txtMaKH.TabIndex = 1;
            this.txtMaKH.Validating += new System.ComponentModel.CancelEventHandler(this.txtMaKH_Validating);
            // 
            // dgvQLKhachHang
            // 
            this.dgvQLKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvQLKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQLKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLKhachHang.Location = new System.Drawing.Point(15, 518);
            this.dgvQLKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgvQLKhachHang.Name = "dgvQLKhachHang";
            this.dgvQLKhachHang.RowHeadersWidth = 51;
            this.dgvQLKhachHang.Size = new System.Drawing.Size(1154, 361);
            this.dgvQLKhachHang.TabIndex = 50;
            this.dgvQLKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLKhachHang_CellClick);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(366, 459);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(118, 51);
            this.btnReload.TabIndex = 20;
            this.btnReload.Text = "Làm mới";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(204, 459);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(118, 51);
            this.btnHuy.TabIndex = 19;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(15, 459);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(118, 51);
            this.btnLuu.TabIndex = 18;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(441, 369);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(118, 51);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(168, 369);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(118, 51);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Location = new System.Drawing.Point(15, 369);
            this.btnDangKy.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(118, 51);
            this.btnDangKy.TabIndex = 15;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(578, 471);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 31);
            this.label9.TabIndex = 61;
            this.label9.Text = "Nhập nội dung :";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(805, 472);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(222, 31);
            this.txtTimKiem.TabIndex = 13;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(1045, 459);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(118, 51);
            this.btnTim.TabIndex = 14;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            // 
            // cboTimKiem
            // 
            this.cboTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimKiem.FormattingEnabled = true;
            this.cboTimKiem.Items.AddRange(new object[] {
            "Mã Khách Hàng",
            "Tên Khách Hàng"});
            this.cboTimKiem.Location = new System.Drawing.Point(805, 385);
            this.cboTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(222, 33);
            this.cboTimKiem.TabIndex = 12;
            this.cboTimKiem.Validating += new System.ComponentModel.CancelEventHandler(this.cboTimKiem_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(582, 385);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 31);
            this.label8.TabIndex = 58;
            this.label8.Text = "Tìm kiếm theo :";
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.btnGiaHan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiaHan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGiaHan.ForeColor = System.Drawing.Color.White;
            this.btnGiaHan.Location = new System.Drawing.Point(305, 369);
            this.btnGiaHan.Margin = new System.Windows.Forms.Padding(4);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(118, 51);
            this.btnGiaHan.TabIndex = 17;
            this.btnGiaHan.Text = "Gia hạn";
            this.btnGiaHan.UseVisualStyleBackColor = false;
            this.btnGiaHan.Click += new System.EventHandler(this.btnGiaHan_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // QLKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 894);
            this.Controls.Add(this.btnGiaHan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.cboTimKiem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.dgvQLKhachHang);
            this.Controls.Add(this.pnlQuanLyKH);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QLKhachHang";
            this.Text = "QLKhachHang";
            this.Load += new System.EventHandler(this.QLKhachHang_Load);
            this.pnlQuanLyKH.ResumeLayout(false);
            this.pnlQuanLyKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlQuanLyKH;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtUuDai;
        private System.Windows.Forms.Label txtGioToiDa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtGioToiThieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DataGridView dgvQLKhachHang;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.ComboBox cboTimKiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGiaHan;
        private System.Windows.Forms.ComboBox cbVeThang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerKH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DateTimePicker dateTimePickerHetHan;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}