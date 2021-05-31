namespace Quanlybaidoxe.Form_Layer.NguoiQuanLyUI
{
    partial class ThongTinXe
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
            this.dgvXeDK = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvXeChuaDK = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXeDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXeChuaDK)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvXeDK
            // 
            this.dgvXeDK.BackgroundColor = System.Drawing.Color.White;
            this.dgvXeDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXeDK.Location = new System.Drawing.Point(217, 148);
            this.dgvXeDK.Name = "dgvXeDK";
            this.dgvXeDK.RowHeadersWidth = 57;
            this.dgvXeDK.Size = new System.Drawing.Size(715, 256);
            this.dgvXeDK.TabIndex = 0;
            this.dgvXeDK.Text = "dataGridView1";
            this.dgvXeDK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXeDK_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(449, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 50);
            this.label1.TabIndex = 41;
            this.label1.Text = "THÔNG TIN XE";
            // 
            // dgvXeChuaDK
            // 
            this.dgvXeChuaDK.BackgroundColor = System.Drawing.Color.White;
            this.dgvXeChuaDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXeChuaDK.Location = new System.Drawing.Point(217, 525);
            this.dgvXeChuaDK.Name = "dgvXeChuaDK";
            this.dgvXeChuaDK.RowHeadersWidth = 57;
            this.dgvXeChuaDK.Size = new System.Drawing.Size(715, 256);
            this.dgvXeChuaDK.TabIndex = 0;
            this.dgvXeChuaDK.Text = "dataGridView2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.1194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 41);
            this.label2.TabIndex = 41;
            this.label2.Text = "Xe đã đăng ký thẻ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.1194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(12, 437);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 41);
            this.label3.TabIndex = 41;
            this.label3.Text = "Xe chưa đăng ký thẻ";
            // 
            // ThongTinXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1186, 900);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvXeChuaDK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvXeDK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongTinXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin xe";
            this.Load += new System.EventHandler(this.ThongTinXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXeDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXeChuaDK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvXeDK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvXeChuaDK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}