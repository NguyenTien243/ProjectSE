using Quanlybaidoxe.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quanlybaidoxe.Form_Layer.NguoiQuanLyUI
{
    public partial class ThongTinCaNhan : Form
    {
        public ThongTinCaNhan()
        {
            InitializeComponent();
        }
        BLNhanVien blNV = new BLNhanVien();
        private void LoadData()
        {
            DataTable db = blNV.GetInfoStaff(SHAREVAR.MaNV).Tables[0];
            lbMaNV.Text = db.Rows[0][0].ToString();
            lbTenNV.Text = db.Rows[0][1].ToString();
            lbNgaySinh.Text = Convert.ToDateTime(db.Rows[0][2].ToString()).ToString("dd/MM/yyyy");
            lbGioiTinh.Text = db.Rows[0][3].ToString();
            lbCMND.Text = db.Rows[0][4].ToString();
            lbSDT.Text = db.Rows[0][5].ToString();
            lbDiaChi.Text = db.Rows[0][6].ToString();
            lbChucVu.Text = SHAREVAR.sharevarVeChucVu;
            // lenNV.Text = db.Rows[0][0].ToString();
        }

        private void ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
