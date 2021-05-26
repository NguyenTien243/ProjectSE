
namespace Quanlybaidoxe.Form_Layer.NguoiQuanLyUI
{
    partial class QLPhieuThanhToan
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
            this.timerThoiGianThuc = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.labelUudai = new System.Windows.Forms.Label();
            this.txtGioVao = new System.Windows.Forms.TextBox();
            this.txtMaPhieuThu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaXe = new System.Windows.Forms.TextBox();
            this.txtGioRa = new System.Windows.Forms.TextBox();
            this.txtBienSo = new System.Windows.Forms.TextBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.pnlQuanLyDoXe = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaNVThu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLoaiVe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTienThu = new System.Windows.Forms.TextBox();
            this.dgvQLPhieuThanhToan = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cboTimKiem = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePickerNgay = new System.Windows.Forms.DateTimePicker();
            this.btnTim = new System.Windows.Forms.Button();
            this.lbNoiDung = new System.Windows.Forms.Label();
            this.btnChiTietPhieuThu = new System.Windows.Forms.Button();
            this.pnlQuanLyDoXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLPhieuThanhToan)).BeginInit();
            this.SuspendLayout();
            // 
            // timerThoiGianThuc
            // 
            this.timerThoiGianThuc.Interval = 1000;
            this.timerThoiGianThuc.Tick += new System.EventHandler(this.timerThoiGianThuc_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(3, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 28);
            this.label6.TabIndex = 26;
            this.label6.Text = "Giờ vào";
            // 
            // labelUudai
            // 
            this.labelUudai.AutoSize = true;
            this.labelUudai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUudai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.labelUudai.Location = new System.Drawing.Point(3, 24);
            this.labelUudai.Name = "labelUudai";
            this.labelUudai.Size = new System.Drawing.Size(144, 28);
            this.labelUudai.TabIndex = 26;
            this.labelUudai.Text = "Mã Phiếu thu:";
            // 
            // txtGioVao
            // 
            this.txtGioVao.Enabled = false;
            this.txtGioVao.Location = new System.Drawing.Point(161, 156);
            this.txtGioVao.Name = "txtGioVao";
            this.txtGioVao.Size = new System.Drawing.Size(251, 27);
            this.txtGioVao.TabIndex = 4;
            // 
            // txtMaPhieuThu
            // 
            this.txtMaPhieuThu.Enabled = false;
            this.txtMaPhieuThu.Location = new System.Drawing.Point(161, 25);
            this.txtMaPhieuThu.Name = "txtMaPhieuThu";
            this.txtMaPhieuThu.Size = new System.Drawing.Size(251, 27);
            this.txtMaPhieuThu.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(489, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 28);
            this.label4.TabIndex = 25;
            this.label4.Text = "Giờ ra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(4, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 28);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mã xe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(1, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 28);
            this.label2.TabIndex = 25;
            this.label2.Text = "Biển số:";
            // 
            // txtMaXe
            // 
            this.txtMaXe.Enabled = false;
            this.txtMaXe.Location = new System.Drawing.Point(161, 118);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(252, 27);
            this.txtMaXe.TabIndex = 2;
            // 
            // txtGioRa
            // 
            this.txtGioRa.Enabled = false;
            this.txtGioRa.Location = new System.Drawing.Point(646, 157);
            this.txtGioRa.Name = "txtGioRa";
            this.txtGioRa.Size = new System.Drawing.Size(252, 27);
            this.txtGioRa.TabIndex = 5;
            // 
            // txtBienSo
            // 
            this.txtBienSo.Enabled = false;
            this.txtBienSo.Location = new System.Drawing.Point(161, 72);
            this.txtBienSo.Name = "txtBienSo";
            this.txtBienSo.Size = new System.Drawing.Size(252, 27);
            this.txtBienSo.TabIndex = 1;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.lbTime.Location = new System.Drawing.Point(681, 19);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(107, 28);
            this.lbTime.TabIndex = 83;
            this.lbTime.Text = "Thời gian:";
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(301, 390);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(80, 28);
            this.btnReload.TabIndex = 80;
            this.btnReload.Text = "Làm mới";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // pnlQuanLyDoXe
            // 
            this.pnlQuanLyDoXe.Controls.Add(this.label12);
            this.pnlQuanLyDoXe.Controls.Add(this.txtMaNVThu);
            this.pnlQuanLyDoXe.Controls.Add(this.label8);
            this.pnlQuanLyDoXe.Controls.Add(this.txtLoaiVe);
            this.pnlQuanLyDoXe.Controls.Add(this.label5);
            this.pnlQuanLyDoXe.Controls.Add(this.txtTienThu);
            this.pnlQuanLyDoXe.Controls.Add(this.label6);
            this.pnlQuanLyDoXe.Controls.Add(this.labelUudai);
            this.pnlQuanLyDoXe.Controls.Add(this.txtGioVao);
            this.pnlQuanLyDoXe.Controls.Add(this.txtMaPhieuThu);
            this.pnlQuanLyDoXe.Controls.Add(this.label4);
            this.pnlQuanLyDoXe.Controls.Add(this.label3);
            this.pnlQuanLyDoXe.Controls.Add(this.label2);
            this.pnlQuanLyDoXe.Controls.Add(this.txtGioRa);
            this.pnlQuanLyDoXe.Controls.Add(this.txtMaXe);
            this.pnlQuanLyDoXe.Controls.Add(this.txtBienSo);
            this.pnlQuanLyDoXe.Location = new System.Drawing.Point(12, 54);
            this.pnlQuanLyDoXe.Name = "pnlQuanLyDoXe";
            this.pnlQuanLyDoXe.Size = new System.Drawing.Size(944, 208);
            this.pnlQuanLyDoXe.TabIndex = 79;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(489, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 28);
            this.label12.TabIndex = 32;
            this.label12.Text = "Mã NV thu:";
            // 
            // txtMaNVThu
            // 
            this.txtMaNVThu.Enabled = false;
            this.txtMaNVThu.Location = new System.Drawing.Point(646, 119);
            this.txtMaNVThu.Name = "txtMaNVThu";
            this.txtMaNVThu.Size = new System.Drawing.Size(252, 27);
            this.txtMaNVThu.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(489, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 28);
            this.label8.TabIndex = 30;
            this.label8.Text = "Loại vé:";
            // 
            // txtLoaiVe
            // 
            this.txtLoaiVe.Enabled = false;
            this.txtLoaiVe.Location = new System.Drawing.Point(646, 73);
            this.txtLoaiVe.Name = "txtLoaiVe";
            this.txtLoaiVe.Size = new System.Drawing.Size(252, 27);
            this.txtLoaiVe.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(489, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 28);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tiền thu:";
            // 
            // txtTienThu
            // 
            this.txtTienThu.Enabled = false;
            this.txtTienThu.Location = new System.Drawing.Point(646, 26);
            this.txtTienThu.Name = "txtTienThu";
            this.txtTienThu.Size = new System.Drawing.Size(252, 27);
            this.txtTienThu.TabIndex = 27;
            // 
            // dgvQLPhieuThanhToan
            // 
            this.dgvQLPhieuThanhToan.BackgroundColor = System.Drawing.Color.White;
            this.dgvQLPhieuThanhToan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQLPhieuThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLPhieuThanhToan.Location = new System.Drawing.Point(11, 424);
            this.dgvQLPhieuThanhToan.Name = "dgvQLPhieuThanhToan";
            this.dgvQLPhieuThanhToan.RowHeadersWidth = 51;
            this.dgvQLPhieuThanhToan.Size = new System.Drawing.Size(923, 326);
            this.dgvQLPhieuThanhToan.TabIndex = 78;
            this.dgvQLPhieuThanhToan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLPhieuThanhToan_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(319, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 45);
            this.label1.TabIndex = 77;
            this.label1.Text = "PHIẾU THANH TOÁN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(11, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(284, 28);
            this.label7.TabIndex = 76;
            this.label7.Text = "Danh sách phiếu thanh toán:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(194, 351);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(178, 27);
            this.txtTimKiem.TabIndex = 91;
            // 
            // cboTimKiem
            // 
            this.cboTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTimKiem.FormattingEnabled = true;
            this.cboTimKiem.Items.AddRange(new object[] {
            "Mã phiếu thu",
            "Biển số",
            "Mã xe",
            "Mã NV thu",
            "Ngày xuất bến",
            "Ngày vào bến"});
            this.cboTimKiem.Location = new System.Drawing.Point(194, 285);
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(178, 28);
            this.cboTimKiem.TabIndex = 93;
            this.cboTimKiem.SelectedIndexChanged += new System.EventHandler(this.cboTimKiem_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(16, 285);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 28);
            this.label14.TabIndex = 92;
            this.label14.Text = "Tìm kiếm theo :";
            // 
            // dateTimePickerNgay
            // 
            this.dateTimePickerNgay.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgay.Location = new System.Drawing.Point(389, 287);
            this.dateTimePickerNgay.Name = "dateTimePickerNgay";
            this.dateTimePickerNgay.Size = new System.Drawing.Size(178, 27);
            this.dateTimePickerNgay.TabIndex = 96;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(389, 349);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(94, 31);
            this.btnTim.TabIndex = 94;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // lbNoiDung
            // 
            this.lbNoiDung.AutoSize = true;
            this.lbNoiDung.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNoiDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.lbNoiDung.Location = new System.Drawing.Point(16, 347);
            this.lbNoiDung.Name = "lbNoiDung";
            this.lbNoiDung.Size = new System.Drawing.Size(164, 28);
            this.lbNoiDung.TabIndex = 95;
            this.lbNoiDung.Text = "Nhập nội dung :";
            // 
            // btnChiTietPhieuThu
            // 
            this.btnChiTietPhieuThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.btnChiTietPhieuThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTietPhieuThu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChiTietPhieuThu.ForeColor = System.Drawing.Color.White;
            this.btnChiTietPhieuThu.Location = new System.Drawing.Point(658, 278);
            this.btnChiTietPhieuThu.Name = "btnChiTietPhieuThu";
            this.btnChiTietPhieuThu.Size = new System.Drawing.Size(295, 49);
            this.btnChiTietPhieuThu.TabIndex = 97;
            this.btnChiTietPhieuThu.Text = "Xem chi tiết phiếu thu";
            this.btnChiTietPhieuThu.UseVisualStyleBackColor = false;
            this.btnChiTietPhieuThu.Click += new System.EventHandler(this.btnChiTietPhieuThu_Click);
            // 
            // QLPhieuThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(965, 762);
            this.Controls.Add(this.btnChiTietPhieuThu);
            this.Controls.Add(this.dateTimePickerNgay);
            this.Controls.Add(this.lbNoiDung);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.cboTimKiem);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.pnlQuanLyDoXe);
            this.Controls.Add(this.dgvQLPhieuThanhToan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QLPhieuThanhToan";
            this.Load += new System.EventHandler(this.QLPhieuThanhToan_Load);
            this.pnlQuanLyDoXe.ResumeLayout(false);
            this.pnlQuanLyDoXe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLPhieuThanhToan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerThoiGianThuc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelUudai;
        private System.Windows.Forms.TextBox txtGioVao;
        private System.Windows.Forms.TextBox txtMaPhieuThu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaXe;
        private System.Windows.Forms.TextBox txtGioRa;
        private System.Windows.Forms.TextBox txtBienSo;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Panel pnlQuanLyDoXe;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaNVThu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLoaiVe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTienThu;
        private System.Windows.Forms.DataGridView dgvQLPhieuThanhToan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cboTimKiem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgay;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label lbNoiDung;
        private System.Windows.Forms.Button btnChiTietPhieuThu;
    }
}