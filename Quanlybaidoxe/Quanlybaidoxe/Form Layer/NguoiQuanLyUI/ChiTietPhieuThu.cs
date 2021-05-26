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
    public partial class ChiTietPhieuThu : Form
    {
        public ChiTietPhieuThu()
        {
            InitializeComponent();
        }
        BLPhieuThanhToan blPhieuThanhToan = new BLPhieuThanhToan();
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChiTietPhieuThu_Load(object sender, EventArgs e)
        {
            LoadThongTin();
        }
        private void LoadThongTin()
        {
            getInfoVehicle();
            getInfoStaff();
        }
        private void getInfoVehicle()
        {
            DataTable tbXe = blPhieuThanhToan.getVehicleByIDReceipt(SHAREVAR.sharevarMaPhieuThanhToan.Trim()).Tables[0];
            if (tbXe.Rows.Count == 0)
            {
                return;
            }
            lbBienSo.Text = tbXe.Rows[0]["BienSo"].ToString();
            lbLoaiXe.Text = tbXe.Rows[0]["TenLoaiXe"].ToString();
            lbTenXe.Text = tbXe.Rows[0]["TenXe"].ToString();
            lbMauXe.Text = tbXe.Rows[0]["MauSac"].ToString();
            string giovao = "Không có thời gian";
            string giora = "Không có thời gian";
            try {
                giovao = Convert.ToDateTime(tbXe.Rows[0]["GioVao"].ToString()).ToString("dd/MM/yyyy h:mm tt");
                giora = Convert.ToDateTime(tbXe.Rows[0]["GioRa"].ToString()).ToString("dd/MM/yyyy h:mm tt");
            }
            catch
            {

            }
            lbThoiGianVao.Text = giovao;
            lbThoiGianRa.Text = giora;
            DateTime stardate = DateTime.Now;
            DateTime enddate = DateTime.Now;
            try 
            {
                stardate = Convert.ToDateTime(tbXe.Rows[0]["GioVao"].ToString());
                enddate = Convert.ToDateTime(tbXe.Rows[0]["GioRa"].ToString());
            }
            catch 
            { }
            TimeSpan Time = enddate - stardate;
            lbThoiLuongGui.Text = Time.Days + " Ngày " + Time.Hours + " Giờ " + Time.Minutes + " Phút "; 
            if(tbXe.Rows[0]["TraTheoThang"].ToString() == "True")
                lbVeThanhToan.Text = "Vé tháng";
            else
                lbVeThanhToan.Text = "Vé lượt";

            lbTienThu.Text = tbXe.Rows[0]["TienThu"].ToString() + " VNĐ";

        }
        private void getInfoStaff()
        {
            DataTable tbNV = blPhieuThanhToan.getStaffByIDReceipt(SHAREVAR.sharevarMaPhieuThanhToan.Trim()).Tables[0];
            if (tbNV.Rows.Count == 0)
            {
                return;
            }
            lbMaPhieu.Text = SHAREVAR.sharevarMaPhieuThanhToan.Trim();
            lbMaNV.Text = tbNV.Rows[0]["MaNV"].ToString();
            lbTenNV.Text = tbNV.Rows[0]["TenNV"].ToString();
            lbNgaySinh.Text = Convert.ToDateTime( tbNV.Rows[0]["NgaySinh"].ToString()).ToString("dd/MM/yyyy");
            lbGioiTinh.Text = tbNV.Rows[0]["GioiTinh"].ToString();
            lbCMND.Text = tbNV.Rows[0]["CMND"].ToString();
            lbSDT.Text = tbNV.Rows[0]["SDT"].ToString();
            lbDiaChi.Text = tbNV.Rows[0]["DiaChi"].ToString();
            lbChucVu.Text = tbNV.Rows[0]["TenCV"].ToString();
        }
    }
}
