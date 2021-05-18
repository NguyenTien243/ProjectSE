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
    public partial class ThanhToanXeRa : Form
    {
        public ThanhToanXeRa()
        {
            InitializeComponent();
        }
        BLDoXe blDoXe = new BLDoXe();
        string err;

        private void ThanhToanXeRa_Load(object sender, EventArgs e)
        {
            LoadData();
            
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            DateTime stardate = Convert.ToDateTime(lbThoiGianVao.Text);
            DateTime enddate = Convert.ToDateTime(lbThoiGianRa.Text);
            blDoXe = new BLDoXe();
            float tienthu = float.Parse(SHAREVAR.sharevarVeTienThu.Trim());
            bool result = blDoXe.CheckOutAndFree(SHAREVAR.sharevarMaXe.Trim(), stardate, enddate, SHAREVAR.sharevarMaNV, SHAREVAR.sharevarVeThang, tienthu, ref err);
            if (result)
            {
                MessageBox.Show("Tính tiền thành công, mời xe ra.");
                
            }    
            else
                MessageBox.Show("Tính tiền gặp lỗi, vui lòng thử lại !.");
            this.Close();
        }

        private void LoadData()
        {
            lbBienSo.Text = SHAREVAR.sharevarBienSo;
            lbLoaiXe.Text = SHAREVAR.sharevarLoaiXe;
            lbMauXe.Text = SHAREVAR.sharevarMauXe;
            lbTenXe.Text = SHAREVAR.sharevarTenXe;
            lbThoiGianRa.Text = SHAREVAR.sharevarTGRa;
            lbThoiGianVao.Text = SHAREVAR.sharevarTGVao;
            lbThoiLuongGui.Text = SHAREVAR.sharevarThoiLuongGui;
            lbTienThu.Text = SHAREVAR.sharevarVeTienThu + " VND";
            lbVeThanhToan.Text = SHAREVAR.sharevarVeThanhToan;
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Bạn có chắc thoát không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK)
            {
                MessageBox.Show("Hủy bỏ thao tác cho xe ra bãi!");
                this.Close();
            }
        }
    }
}
