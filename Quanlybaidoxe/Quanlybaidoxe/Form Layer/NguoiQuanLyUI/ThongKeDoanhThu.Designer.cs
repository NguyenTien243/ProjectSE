﻿
namespace Quanlybaidoxe.Form_Layer.NguoiQuanLyUI
{
    partial class ThongKeDoanhThu
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
            this.dgvTongThu = new System.Windows.Forms.DataGridView();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dtgiora = new System.Windows.Forms.DateTimePicker();
            this.dtgiovao = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTongThu
            // 
            this.dgvTongThu.BackgroundColor = System.Drawing.Color.White;
            this.dgvTongThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTongThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTongThu.Location = new System.Drawing.Point(730, 214);
            this.dgvTongThu.Name = "dgvTongThu";
            this.dgvTongThu.RowHeadersWidth = 51;
            this.dgvTongThu.Size = new System.Drawing.Size(205, 490);
            this.dgvTongThu.TabIndex = 61;
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThu.Location = new System.Drawing.Point(12, 214);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.RowHeadersWidth = 51;
            this.dgvDoanhThu.Size = new System.Drawing.Size(712, 490);
            this.dgvDoanhThu.TabIndex = 60;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(426, 100);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(94, 41);
            this.btnThongKe.TabIndex = 59;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dtgiora
            // 
            this.dtgiora.CustomFormat = "yyyy-MM-dd  HH:mm:ss";
            this.dtgiora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtgiora.Location = new System.Drawing.Point(648, 114);
            this.dtgiora.Name = "dtgiora";
            this.dtgiora.Size = new System.Drawing.Size(201, 27);
            this.dtgiora.TabIndex = 57;
            this.dtgiora.Validating += new System.ComponentModel.CancelEventHandler(this.dtgiora_Validating);
            // 
            // dtgiovao
            // 
            this.dtgiovao.CustomFormat = "yyyy-MM-dd  HH:mm:ss";
            this.dtgiovao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtgiovao.Location = new System.Drawing.Point(97, 114);
            this.dtgiovao.Name = "dtgiovao";
            this.dtgiovao.Size = new System.Drawing.Size(203, 27);
            this.dtgiovao.TabIndex = 58;
            this.dtgiovao.Value = new System.DateTime(2021, 5, 14, 0, 26, 31, 0);
            this.dtgiovao.Validating += new System.ComponentModel.CancelEventHandler(this.dtgiovao_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(350, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 45);
            this.label1.TabIndex = 56;
            this.label1.Text = "DOANH THU";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(947, 715);
            this.Controls.Add(this.dgvTongThu);
            this.Controls.Add(this.dgvDoanhThu);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.dtgiora);
            this.Controls.Add(this.dtgiovao);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKeDoanhThu";
            this.Text = "ThongKeDoanhThu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTongThu;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DateTimePicker dtgiora;
        private System.Windows.Forms.DateTimePicker dtgiovao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}