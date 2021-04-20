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

        private void button4_Click(object sender, EventArgs e)
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
            //f.Show();
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
    }
}
