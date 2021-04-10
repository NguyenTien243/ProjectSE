using Quanlybaidoxe.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlybaidoxe
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        DataTable dtTaiKhoan = null;
        BLTaiKhoan dbBaiDoXe = new BLTaiKhoan();
        private void label3_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Bạn có chắc thoát không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK) Application.Exit();

        }
        //Di chuyển form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }
        //Hết phần di chuyển form
        private void cboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxShowPass.Checked)
            {
                txtMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '•';
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtTaiKhoan.Rows.Count; i++)
            {
                if (txtTenDangNhap.Text.Trim() == dtTaiKhoan.Rows[i]["TaiKhoan"].ToString().Trim() && txtMatKhau.Text.Trim() == dtTaiKhoan.Rows[i]["MatKhau"].ToString().Trim())
                {
                    MessageBox.Show("Đăng nhập thành công !!");
                    return;
                }
            }
            MessageBox.Show("Sai tài khoản hoặc mật khẩu !!!");
            //frm_Management = new Form_Management();
            ////frm_Management.getForm(this, dtNV.Rows[i][2].ToString());
            //frm_Management.Show();
            //this.Hide();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                //Lấy account nhân viên
                dtTaiKhoan = new DataTable();
                dtTaiKhoan.Clear();
                DataSet dsANV = dbBaiDoXe.LayTaiKkhoanNV();
                dtTaiKhoan = dsANV.Tables[0];
                // Xóa trống các đối tượng trong Panel
                this.txtTenDangNhap.ResetText();
                this.txtMatKhau.ResetText();
           
               
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table. Lỗi rồi!!!");
            }
        }
    }
}
