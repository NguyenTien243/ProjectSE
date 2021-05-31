using Quanlybaidoxe.BS_Layer;
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
        BLNhanVien blNhanVien;
        
        string manv;
        void hienthi()
        {
            this.pnlChucNang.Controls.Clear();
            QLNhanVien formQLNV = new QLNhanVien();
            formQLNV.TopLevel = false;
            this.pnlChucNang.Controls.Add(formQLNV);
            formQLNV.Show();
        }
        private void DashBoard_Load(object sender, EventArgs e)
        {
            blNhanVien = new BLNhanVien();
            DataSet datasetInfo = blNhanVien.GetPositionStaff(manv); // lấy tên nhân viên và tên chức vụ của nhân viên
            lbUserName.Text += "  " + datasetInfo.Tables[0].Rows[0]["TenNV"].ToString();
            lbChucVu.Text += " " + datasetInfo.Tables[0].Rows[0]["TenCV"].ToString();
            if (SHAREVAR.sharevarVeChucVu != "Người Quản Lý")
            {
                btnBaiDoXe.Visible = false;
                btnDoanhThu.Visible = false;
                btnKhachHang.Visible = false;
                btnNhanVien.Visible = false;
                btnTheGuiXe.Visible = false;
                btnGiaVe.Visible = false;
                this.pnlChucNang.Controls.Clear();
                DoXe formDoXe = new DoXe();
                formDoXe.TopLevel = false;
                this.pnlChucNang.Controls.Add(formDoXe);
                formDoXe.Show();
            }                
        }
        public void fundata(string manv)
        {
            this.manv = manv;
            SHAREVAR.sharevarMaNV = manv.Trim();
        }





        //Di chuyển form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void DashBoard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        //Hết phần di chuyển form

        private void btnBaiDoXe_Click(object sender, EventArgs e)
        {
            this.pnlChucNang.Controls.Clear();
            BaiDoXe ad = new BaiDoXe();
            ad.TopLevel = false;
            this.pnlChucNang.Controls.Add(ad);
            ad.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            this.pnlChucNang.Controls.Clear();
            QLNhanVien FormNhanVien = new QLNhanVien();
            FormNhanVien.TopLevel = false;
            this.pnlChucNang.Controls.Add(FormNhanVien);
            FormNhanVien.Show();
        }




        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            this.pnlChucNang.Controls.Clear();
            ThongKe FormThongKe = new ThongKe();
            FormThongKe.TopLevel = false;
            this.pnlChucNang.Controls.Add(FormThongKe);
            FormThongKe.Show();
        }

        private void btnDoXe_Click(object sender, EventArgs e)
        {
            this.pnlChucNang.Controls.Clear();
            DoXe FormDoXe = new DoXe();
            FormDoXe.TopLevel = false;
            this.pnlChucNang.Controls.Add(FormDoXe);
            FormDoXe.Show();
        }

        private void btnGiaVe_Click(object sender, EventArgs e)
        {
            this.pnlChucNang.Controls.Clear();
            QLGiaVe FormAdmin = new QLGiaVe();
            FormAdmin.TopLevel = false;
            this.pnlChucNang.Controls.Add(FormAdmin);
            FormAdmin.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            this.pnlChucNang.Controls.Clear();
            QLKhachHang FormQLKhachHang = new QLKhachHang();
            FormQLKhachHang.TopLevel = false;
            this.pnlChucNang.Controls.Add(FormQLKhachHang);
            FormQLKhachHang.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Bạn có chắc thoát không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK)
            {
                this.Close();
                new DangNhap().Show();
            }
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            this.pnlChucNang.Controls.Clear();
            ThongKeDoanhThu tkdt = new ThongKeDoanhThu();
            tkdt.TopLevel = false;
            this.pnlChucNang.Controls.Add(tkdt);
            tkdt.Show();
        }

       

        

        private void btnTheGuiXe_Click(object sender, EventArgs e)
        {
            this.pnlChucNang.Controls.Clear();
            QLTheGuiXe tkdt = new QLTheGuiXe();
            tkdt.TopLevel = false;
            this.pnlChucNang.Controls.Add(tkdt);
            tkdt.Show();
        }

       
        private void btnPhieuThu_Click(object sender, EventArgs e)
        {
            this.pnlChucNang.Controls.Clear();
            QLPhieuThanhToan tkdt = new QLPhieuThanhToan();
            tkdt.TopLevel = false;
            this.pnlChucNang.Controls.Add(tkdt);
            tkdt.Show();
        }

        private void btnXemThongTin_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan ThongTinCaNhan = new ThongTinCaNhan();
            ThongTinCaNhan.ShowDialog();
        }

        private void btnThongTinXe_Click(object sender, EventArgs e)
        {
            this.pnlChucNang.Controls.Clear();
            ThongTinXe ThongTinXe = new ThongTinXe();
            ThongTinXe.TopLevel = false;
            this.pnlChucNang.Controls.Add(ThongTinXe);
            ThongTinXe.Show();

        }
    }
}
