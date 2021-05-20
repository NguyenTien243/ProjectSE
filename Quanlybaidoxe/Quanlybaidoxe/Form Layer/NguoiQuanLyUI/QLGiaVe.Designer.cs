
namespace Quanlybaidoxe.Form_Layer.NguoiQuanLyUI
{
    partial class QLGiaVe
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
            this.dgvGiaVe = new System.Windows.Forms.DataGridView();
            this.pnlQuanLyGiaVe = new System.Windows.Forms.Panel();
            this.txtSoThang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxVeThang = new System.Windows.Forms.CheckBox();
            this.cboLoaiXe = new System.Windows.Forms.ComboBox();
            this.txt3 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.Label();
            this.txtUuDai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGioToiDa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGioToiThieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiaVe = new System.Windows.Forms.TextBox();
            this.txtTenGiaVe = new System.Windows.Forms.TextBox();
            this.txtMaGiaVe = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaVe)).BeginInit();
            this.pnlQuanLyGiaVe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(340, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 45);
            this.label1.TabIndex = 39;
            this.label1.Text = "QUẢN LÝ GIÁ VÉ";
            // 
            // dgvGiaVe
            // 
            this.dgvGiaVe.BackgroundColor = System.Drawing.Color.White;
            this.dgvGiaVe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGiaVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGiaVe.Location = new System.Drawing.Point(12, 432);
            this.dgvGiaVe.Name = "dgvGiaVe";
            this.dgvGiaVe.RowHeadersWidth = 51;
            this.dgvGiaVe.Size = new System.Drawing.Size(923, 318);
            this.dgvGiaVe.TabIndex = 46;
            this.dgvGiaVe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGiaVe_CellClick);
            // 
            // pnlQuanLyGiaVe
            // 
            this.pnlQuanLyGiaVe.Controls.Add(this.txtSoThang);
            this.pnlQuanLyGiaVe.Controls.Add(this.label6);
            this.pnlQuanLyGiaVe.Controls.Add(this.checkBoxVeThang);
            this.pnlQuanLyGiaVe.Controls.Add(this.cboLoaiXe);
            this.pnlQuanLyGiaVe.Controls.Add(this.txt3);
            this.pnlQuanLyGiaVe.Controls.Add(this.txt1);
            this.pnlQuanLyGiaVe.Controls.Add(this.label5);
            this.pnlQuanLyGiaVe.Controls.Add(this.txt2);
            this.pnlQuanLyGiaVe.Controls.Add(this.txtUuDai);
            this.pnlQuanLyGiaVe.Controls.Add(this.label4);
            this.pnlQuanLyGiaVe.Controls.Add(this.txtGioToiDa);
            this.pnlQuanLyGiaVe.Controls.Add(this.label3);
            this.pnlQuanLyGiaVe.Controls.Add(this.txtGioToiThieu);
            this.pnlQuanLyGiaVe.Controls.Add(this.label2);
            this.pnlQuanLyGiaVe.Controls.Add(this.txtGiaVe);
            this.pnlQuanLyGiaVe.Controls.Add(this.txtTenGiaVe);
            this.pnlQuanLyGiaVe.Controls.Add(this.txtMaGiaVe);
            this.pnlQuanLyGiaVe.Location = new System.Drawing.Point(12, 57);
            this.pnlQuanLyGiaVe.Name = "pnlQuanLyGiaVe";
            this.pnlQuanLyGiaVe.Size = new System.Drawing.Size(944, 232);
            this.pnlQuanLyGiaVe.TabIndex = 47;
            // 
            // txtSoThang
            // 
            this.txtSoThang.Location = new System.Drawing.Point(669, 186);
            this.txtSoThang.Name = "txtSoThang";
            this.txtSoThang.Size = new System.Drawing.Size(251, 27);
            this.txtSoThang.TabIndex = 7;
            this.txtSoThang.Validating += new System.ComponentModel.CancelEventHandler(this.txtSoThang_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(510, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 28);
            this.label6.TabIndex = 26;
            this.label6.Text = "Số tháng:";
            // 
            // checkBoxVeThang
            // 
            this.checkBoxVeThang.AutoSize = true;
            this.checkBoxVeThang.Font = new System.Drawing.Font("Segoe UI", 11.8209F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.checkBoxVeThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.checkBoxVeThang.Location = new System.Drawing.Point(498, 153);
            this.checkBoxVeThang.Name = "checkBoxVeThang";
            this.checkBoxVeThang.Size = new System.Drawing.Size(119, 32);
            this.checkBoxVeThang.TabIndex = 8;
            this.checkBoxVeThang.Text = "Vé tháng";
            this.checkBoxVeThang.UseVisualStyleBackColor = true;
            this.checkBoxVeThang.CheckedChanged += new System.EventHandler(this.checkBoxVeThang_CheckedChanged);
            // 
            // cboLoaiXe
            // 
            this.cboLoaiXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiXe.FormattingEnabled = true;
            this.cboLoaiXe.Location = new System.Drawing.Point(161, 154);
            this.cboLoaiXe.Name = "cboLoaiXe";
            this.cboLoaiXe.Size = new System.Drawing.Size(252, 28);
            this.cboLoaiXe.TabIndex = 4;
            // 
            // txt3
            // 
            this.txt3.AutoSize = true;
            this.txt3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.txt3.Location = new System.Drawing.Point(498, 113);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(81, 28);
            this.txt3.TabIndex = 26;
            this.txt3.Text = "Ưu đãi:";
            // 
            // txt1
            // 
            this.txt1.AutoSize = true;
            this.txt1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.txt1.Location = new System.Drawing.Point(498, 65);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(112, 28);
            this.txt1.TabIndex = 26;
            this.txt1.Text = "Giờ tối đa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(1, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 28);
            this.label5.TabIndex = 26;
            this.label5.Text = "Loại xe:";
            // 
            // txt2
            // 
            this.txt2.AutoSize = true;
            this.txt2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.txt2.Location = new System.Drawing.Point(498, 20);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(137, 28);
            this.txt2.TabIndex = 25;
            this.txt2.Text = "Giờ tối thiểu:";
            // 
            // txtUuDai
            // 
            this.txtUuDai.Location = new System.Drawing.Point(669, 113);
            this.txtUuDai.Name = "txtUuDai";
            this.txtUuDai.Size = new System.Drawing.Size(251, 27);
            this.txtUuDai.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(1, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 28);
            this.label4.TabIndex = 25;
            this.label4.Text = "Giá vé:";
            // 
            // txtGioToiDa
            // 
            this.txtGioToiDa.Location = new System.Drawing.Point(669, 68);
            this.txtGioToiDa.Name = "txtGioToiDa";
            this.txtGioToiDa.Size = new System.Drawing.Size(251, 27);
            this.txtGioToiDa.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(1, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 28);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tên giá vé:";
            // 
            // txtGioToiThieu
            // 
            this.txtGioToiThieu.Location = new System.Drawing.Point(668, 19);
            this.txtGioToiThieu.Name = "txtGioToiThieu";
            this.txtGioToiThieu.Size = new System.Drawing.Size(252, 27);
            this.txtGioToiThieu.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(1, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 28);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mã giá vé:";
            // 
            // txtGiaVe
            // 
            this.txtGiaVe.Location = new System.Drawing.Point(161, 110);
            this.txtGiaVe.Name = "txtGiaVe";
            this.txtGiaVe.Size = new System.Drawing.Size(252, 27);
            this.txtGiaVe.TabIndex = 3;
            // 
            // txtTenGiaVe
            // 
            this.txtTenGiaVe.Location = new System.Drawing.Point(161, 66);
            this.txtTenGiaVe.Name = "txtTenGiaVe";
            this.txtTenGiaVe.Size = new System.Drawing.Size(251, 27);
            this.txtTenGiaVe.TabIndex = 2;
            // 
            // txtMaGiaVe
            // 
            this.txtMaGiaVe.Location = new System.Drawing.Point(161, 20);
            this.txtMaGiaVe.Name = "txtMaGiaVe";
            this.txtMaGiaVe.Size = new System.Drawing.Size(252, 27);
            this.txtMaGiaVe.TabIndex = 1;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(354, 367);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(94, 41);
            this.btnReload.TabIndex = 55;
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
            this.btnHuy.Location = new System.Drawing.Point(186, 367);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(94, 41);
            this.btnHuy.TabIndex = 54;
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
            this.btnLuu.Location = new System.Drawing.Point(13, 367);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(94, 41);
            this.btnLuu.TabIndex = 53;
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
            this.btnXoa.Location = new System.Drawing.Point(354, 295);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 41);
            this.btnXoa.TabIndex = 52;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(186, 295);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 41);
            this.btnSua.TabIndex = 51;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(13, 295);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 41);
            this.btnThem.TabIndex = 50;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // QLGiaVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(965, 762);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.pnlQuanLyGiaVe);
            this.Controls.Add(this.dgvGiaVe);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QLGiaVe";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGiaVe)).EndInit();
            this.pnlQuanLyGiaVe.ResumeLayout(false);
            this.pnlQuanLyGiaVe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGiaVe;
        private System.Windows.Forms.Panel pnlQuanLyNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenGiaVe;
        private System.Windows.Forms.TextBox txtMaGiaVe;
        private System.Windows.Forms.Label txt3;
        private System.Windows.Forms.Label txt1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txt2;
        private System.Windows.Forms.TextBox txtUuDai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGioToiDa;
        private System.Windows.Forms.TextBox txtGioToiThieu;
        private System.Windows.Forms.TextBox txtGiaVe;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cboLoaiXe;
        private System.Windows.Forms.CheckBox checkBoxVeThang;
        private System.Windows.Forms.Panel pnlQuanLyGiaVe;
        private System.Windows.Forms.TextBox txtSoThang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}