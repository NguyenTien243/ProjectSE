using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Quanlybaidoxe.BS_Layer;

namespace Quanlybaidoxe.Form_Layer.NguoiQuanLyUI
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        BLNhanVien blNhanVien = new BLNhanVien();
        BLKhachHang blKhachHang = new BLKhachHang();
        BLViTriXe blViTri = new BLViTriXe();
        BLXe blXe = new BLXe();
        DataTable dataTablePositionAvailable = null;

        private void LoadData()
        {
            //Đếm số lượng Nhân viên
            lbSoLuongNhanVien.Text = blNhanVien.CountNhanVien().Tables[0].Rows[0][0].ToString();
            //Đếm số lượng khách hàng
            lbSoLuongKhachHang.Text = blKhachHang.CountKhachHang().Tables[0].Rows[0][0].ToString();
            //Đếm số lượng vị trí đỗ xe
            lbSoViTriDo.Text = blViTri.CountVitrido().Tables[0].Rows[0][0].ToString();
            //Đếm số lượng xe
            lbSoXeDangGui.Text = blXe.CountXe().Tables[0].Rows[0][0].ToString();
            BLDoXe blDoXe = new BLDoXe();
            dataTablePositionAvailable = blDoXe.GetPosition().Tables[0];
            if (dataTablePositionAvailable.Rows.Count == 0)
            {
                
                lbSoViTriDo.Text = "Hết chỗ!";
            }
            else
                lbSoViTriDo.Text = dataTablePositionAvailable.Rows.Count.ToString();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
