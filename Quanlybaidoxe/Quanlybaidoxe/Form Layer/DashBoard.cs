using Quanlybaidoxe.Form_Layer.NguoiQuanLyUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quanlybaidoxe.Form_Layer
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            hienthi();
        }
        void hienthi()
        {
            this.pnlChucNang.Controls.Clear();
            QLNhanVien ad = new QLNhanVien();
            ad.TopLevel = false;
            this.pnlChucNang.Controls.Add(ad);
            ad.Show();
        }
        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void pnlChucNang_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
