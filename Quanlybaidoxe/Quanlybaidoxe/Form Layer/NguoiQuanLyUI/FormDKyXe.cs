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
    public partial class FormDKyXe : Form
    {
        public FormDKyXe()
        {
            InitializeComponent();
        }
        //  DataTable datatableXe = null;
        string err;
        BLXe blXe = new BLXe();
        private void FormDKyXe_Load(object sender, EventArgs e)
        {
            txtTenXe.ResetText();
            txtMaXe.ResetText();
            txtMauSac.ResetText();
            txtBienSo.ResetText();
            radioBtnOto.Checked = false;
            radioBtnXeMay.Checked = false;
            

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            this.Dispose();
            string MaLoaiXe;
            if (radioBtnOto.Checked == true)
                MaLoaiXe = "LX0";
            else MaLoaiXe = "LXM";
            if (txtTenXe.Text.Trim().Length == 0 || txtMaXe.Text.Trim().Length == 0 || txtMauSac.Text.Trim().Length == 0 || txtBienSo.Text.Trim().Length == 0 || radioBtnOto.Checked==false || radioBtnXeMay.Checked==false)
            {
                if (blXe.AddVehicle(txtMaXe.Text, txtBienSo.Text, txtTenXe.Text, txtMauSac.Text, MaLoaiXe, ref err) == true)
                {
                    this.pnlDKyXe.Controls.Clear();
                    
                    QLKhachHang frmQLKH = new QLKhachHang();
                    frmQLKH.TopLevel = false;
                    
                    // Gắn vào panel
                    this.pnlDKyXe.Controls.Add(frmQLKH);

                    // Hiển thị form
                    frmQLKH.Show();
                }
                else MessageBox.Show("Có lỗi, không thể thêm được!");

            }
            else MessageBox.Show("Vui lòng điền đủ trước khi xác nhận!");
        }
    }
}
