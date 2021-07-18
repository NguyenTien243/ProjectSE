       using Quanlybaidoxe.BS_Layer;
using Quanlybaidoxe.Form_Layer;
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
        string manv;
        DashBoard formquanly;
        public DangNhap()
        {
            InitializeComponent();
        }
        DataTable dtTaiKhoan = null;
        BLTaiKhoan dbBaiDoXe = new BLTaiKhoan();
       
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
        private bool KiemTraKyTuToiDa()
        {
            bool check = true;
            string thongbaoloi = "";
            if (txtTenDangNhap.Text.Trim().Length > 30)
            {
                thongbaoloi += "\nTên đăng nhập tối đa 30 ký tự!!!";
                check = false;
            }
            if (txtMatKhau.Text.Trim().Length > 30)
            {
                thongbaoloi += "\nMật khẩu tối đa 30 ký tự!!!";
                check = false;
            }

            if (check == false)
            {
                MessageBox.Show(thongbaoloi);
            }
            return check;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim().Length == 0 || txtMatKhau.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
                return;
            }
            if (KiemTraKyTuToiDa() == false)
                return;

            // tham khảo từ https://stackoverflow.com/questions/42895750/c-sharp-datatable-select-with-multiple-conditions-on-a-single-column
            DataRow rowAccount = dtTaiKhoan.AsEnumerable().FirstOrDefault(c => c.Field<string>("TaiKhoan").Trim() == txtTenDangNhap.Text.Trim() && c.Field<string>("MatKhau").Trim() == txtMatKhau.Text.Trim());
            if(rowAccount != null)
            {
                if (rowAccount["MaCV"].ToString().Trim() == "CV01")
                {
                    MessageBox.Show("Đăng nhập thành công với tài khoản quản trị viên !!!");
                    SHAREVAR.sharevarVeChucVu = "Người Quản Lý";
                    
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công với tài khoản nhân viên !!!");
                    SHAREVAR.sharevarVeChucVu = "Nhân Viên";
                    
                }
                manv = rowAccount["MaNV"].ToString();
                SHAREVAR.MaNV = manv;
                //txtTenDangNhap.ResetText();
                //txtMatKhau.ResetText();
                //txtTenDangNhap.Focus();
                formquanly = new DashBoard();
                // chuyền mã nhân viên sang form DashBoard
                delPassData delpassdata = new delPassData(formquanly.fundata); //https://daynhauhoc.com/t/cach-truyen-du-lieu-giua-2-form-trong-c/33911
                delpassdata(manv);
                this.Hide();
                formquanly.ShowDialog();
                
            }
            else
            MessageBox.Show("Sai tài khoản hoặc mật khẩu !!!");

            //for (int i = 0; i < dtTaiKhoan.Rows.Count; i++)
            //{
            //    if (txtTenDangNhap.Text.Trim() == dtTaiKhoan.Rows[i]["TaiKhoan"].ToString().Trim() && txtMatKhau.Text.Trim() == dtTaiKhoan.Rows[i]["MatKhau"].ToString().Trim())
            //    {
                    
                    
            //        manv = dtTaiKhoan.Rows[i]["MaNV"].ToString().Trim();
            //        if (dtTaiKhoan.Rows[i]["MaCV"].ToString().Trim() == "CV01")
            //            {
            //            MessageBox.Show("Đăng nhập thành công !!");
            //            //txtTenDangNhap.ResetText();
            //            //txtMatKhau.ResetText();
            //            //txtTenDangNhap.Focus();
            //            formquanly = new DashBoard();  
            //            // chuyền mã nhân viên sang form DashBoard
            //            delPassData delpassdata = new delPassData(formquanly.fundata); //https://daynhauhoc.com/t/cach-truyen-du-lieu-giua-2-form-trong-c/33911
            //            delpassdata(manv);  
            //            this.Hide();
            //            formquanly.ShowDialog();
   
                      
            //            return;
            //        }
            //        else
            //        {
            //            MessageBox.Show("Đăng nhập thành công với tài khoản nhân viên, giao diện nhân viên chưa hoàn thành !!");
            //            return;
            //        }    
            //    }
            //}
            //MessageBox.Show("Sai tài khoản hoặc mật khẩu !!!");
            
        }


        public delegate void delPassData(string manv);
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
                dbBaiDoXe = new BLTaiKhoan();
                DataSet dsANV = dbBaiDoXe.GetStaffAccounts();
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

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            // Khai báo biến traloi
            DialogResult traloi;
            // Hiện hộp thoại hỏi đáp
            traloi = MessageBox.Show("Bạn có chắc thoát không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            // Kiểm tra có nhắp chọn nút Ok không?
            if (traloi == DialogResult.OK) Application.Exit();
        }

        
    }
}
