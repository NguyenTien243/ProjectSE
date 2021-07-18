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
    public partial class QLTheGuiXe : Form
    {
        public QLTheGuiXe()
        {
            InitializeComponent();
        }
        DataTable datatableTheGuiXe = null;

        BLTheGuiXe blTheGuiXe = new BLTheGuiXe();
        bool Add;
        string err;
        bool check = true;
        private void LoadData()
        {
            try
            {
                txtMaThe.ResetText();
                dgvTheGuiXe.Enabled = true;
                datatableTheGuiXe = new DataTable();
                datatableTheGuiXe.Clear();
                DataSet ds = blTheGuiXe.GetAllCard();
                datatableTheGuiXe = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvTheGuiXe.DataSource = datatableTheGuiXe;
                // Thay đổi độ rộng cột
                dgvTheGuiXe.AutoResizeColumns();

                btnThem.Enabled = true;
                btnXoa.Enabled = true;
               
                btnHuy.Enabled = false;
                btnLuu.Enabled = false;
                txtMaThe.Enabled = false;

              

                dgvTheGuiXe_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung. Lỗi rồi!");
            }
        }
        private void dgvTheGuiXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Thứ tự dòng hiện hành
                int r;
                if (dgvTheGuiXe.CurrentCell == null)
                    return;
                else
                    r = dgvTheGuiXe.CurrentCell.RowIndex;

                this.txtMaThe.Text = dgvTheGuiXe.Rows[r].Cells[0].Value.ToString();              
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung!");
            }
        }

        private void QLTheGuiXe_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;       
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            txtMaThe.Enabled = true;
            txtMaThe.ResetText();

            Add = true;
        }
        private bool KiemTraKyTuToiDa()
        {
            bool check = true;
            string thongbaoloi = "";
            if (txtMaThe.Text.Trim().Length > 10)
            {
                thongbaoloi += "\nMã thẻ gửi xe tối đa 10 ký tự!!!";
                check = false;
            }
            

            if (check == false)
            {
                MessageBox.Show(thongbaoloi);
            }
            return check;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (KiemTraKyTuToiDa() == false)
                return;
            if (txtMaThe.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập mã thẻ!!");
                return;
            }
            
            if (Add == true && check == true)
            {
                blTheGuiXe = new BLTheGuiXe();
                //  try 
               if(blTheGuiXe.AddCard(txtMaThe.Text, ref err) == true)
                {
                    MessageBox.Show("Đã thêm thẻ gửi xe thành công");
                    Add = false;
                    LoadData();
                }    
               else MessageBox.Show("Đã thêm thẻ gửi xe thất bại!");

            }
            //else
            //{


            //    blViTri = new BLViTriXe();
            //    int r = dgvQLBDX.CurrentCell.RowIndex;
            //    string MaViTri = dgvQLBDX.Rows[r].Cells[0].Value.ToString();
            //    if (blViTri.EditPosition(MaViTri, txtTenViTri.Text, ref err) == true)
            //    {
            //        MessageBox.Show("Chỉnh sửa thành công, đã cập nhật lại thông tin");
            //        LoadData();
            //    }
            //    else MessageBox.Show("Không thể chỉnh sửa!!");
            //}
        }

        private void txtMaThe_Validating(object sender, CancelEventArgs e)
        {
            if (blTheGuiXe.CheckIdCard(txtMaThe.Text)==false)
            {
                errorProvider1.SetError(txtMaThe, "Mã Thẻ xe bị trùng!!!");
                check = false;
            }
            else
            {
                errorProvider1.SetError(txtMaThe, null);
                check = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.btnThem.Enabled = true;

            this.btnXoa.Enabled = true;
            this.dgvTheGuiXe.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            txtMaThe.Enabled = false;
            dgvTheGuiXe_CellClick(null, null);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int row = dgvTheGuiXe.CurrentCell.RowIndex;
                blTheGuiXe = new BLTheGuiXe();
                // nếu mã vị trí hiện đang có xe thì không cho xóa
                if (blTheGuiXe.CheckVehicle(txtMaThe.Text) == true)
                {
                    MessageBox.Show("Không cho phép xóa do có xe đang sử dụng thẻ!");
                    return;
                }
                // Viết câu lệnh SQL
                // Hiện thông báo xác nhận việc xóa mẫu tin
                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu thẻ gửi xe không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {

                    blTheGuiXe = new BLTheGuiXe();
                    if (blTheGuiXe.DeleteCard(this.txtMaThe.Text, ref err))
                        // Thông báo
                        MessageBox.Show("Đã xóa xong!");
                    else
                        // Thông báo
                        MessageBox.Show("Xóa bị lỗi!");
                    // Cập nhật lại DataGridView
                    LoadData();
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Đã hủy thao tác xóa thẻ!");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
