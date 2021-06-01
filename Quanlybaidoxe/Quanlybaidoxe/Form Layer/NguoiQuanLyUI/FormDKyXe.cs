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
       // bool Add = false;
        public FormDKyXe()
        {
            InitializeComponent();
        }
        //  DataTable datatableXe = null;
        string err;
        bool check = true;
        BLXe blXe = new BLXe();
        private void FormDKyXe_Load(object sender, EventArgs e)
        {
            if (SHAREVAR.Add == false)
            {
                blXe = new BLXe();
                DataSet ds = blXe.GetVehicle(SHAREVAR.MaKH);
                txtMaXe.Text = ds.Tables[0].Rows[0][0].ToString();
                txtMaXe.Enabled = false;
                txtBienSo.Text = ds.Tables[0].Rows[0][1].ToString();
                txtTenXe.Text = ds.Tables[0].Rows[0][2].ToString();
                txtMauSac.Text = ds.Tables[0].Rows[0][3].ToString();
                cbLoaiXe.Enabled = false;
                if (ds.Tables[0].Rows[0][4].ToString() == "Xe máy")
                    cbLoaiXe.Text = "Xe máy";
                else cbLoaiXe.Text = "Ô tô";

            }
            else
            {
                txtTenXe.ResetText();
                txtMaXe.ResetText();
                txtMauSac.ResetText();
                txtBienSo.ResetText();
                cbLoaiXe.ResetText();
                cbLoaiXe.Items.Clear();
                for (int dem = 0; dem < blXe.GetVehicleCategory().Tables[0].Rows.Count; dem++) //Thêm loại xe vào combobox
                {
                    cbLoaiXe.Items.Add(blXe.GetVehicleCategory().Tables[0].Rows[dem][0].ToString());
                }
            }

        }
        //public bool CheckValues(string MaXe, string BienSo)
        //{

        //    BLXe blXe = new BLXe();
        //    if (blXe.CheckIdVehicle(MaXe).Tables[0].Rows.Count != 0)
        //    {
        //        MessageBox.Show("Mã xe này đã được sử dụng!!");               
        //    }  else if (blXe.CheckLicensePlate(BienSo).Tables[0].Rows.Count != 0)
        //    {
        //        MessageBox.Show("Biển số này đã được sử dụng!!");             
        //    }
        //    else check = true;
        //    return check;
        //}
        private bool KiemTraKyTuToiDa()
        {
            bool check = true;
            string thongbaoloi = "";
            if (txtMaXe.Text.Trim().Length > 10)
            {
                thongbaoloi += "\nMã xe tối đa 10 ký tự!!!";
                check = false;
            }
            if (txtTenXe.Text.Trim().Length > 30)
            {
                thongbaoloi += "\nTên xe tối đa 30 ký tự!!!";
                check = false;
            }
            if (txtBienSo.Text.Trim().Length > 20)
            {
                thongbaoloi += "\nBiển số tối đa 30 ký tự!!!";
                check = false;
            }
            if (txtMauSac.Text.Trim().Length > 20)
            {
                thongbaoloi += "\nMàu xe tối đa 30 ký tự!!!";
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
            if (txtTenXe.Text.Trim().Length == 0 || txtMaXe.Text.Trim().Length == 0 || txtMauSac.Text.Trim().Length == 0 || txtBienSo.Text.Trim().Length == 0 || cbLoaiXe.Text.Trim().Length == 0)
            {

                MessageBox.Show("Vui lòng điền đủ trước khi xác nhận!");
                return;
            }
            
            if (SHAREVAR.Add == true)
            {                
                if (check == true)
                {
                    if (blXe.AddVehicle(txtMaXe.Text, txtBienSo.Text, txtTenXe.Text, txtMauSac.Text, blXe.GetVehicleId(cbLoaiXe.Text).Tables[0].Rows[0][0].ToString(), ref err) == true)
                    {
                        SHAREVAR.maxe = txtMaXe.Text;
                        SHAREVAR.maloaixe = blXe.GetVehicleId(cbLoaiXe.Text).Tables[0].Rows[0][0].ToString();
                        SHAREVAR.DkyXe = true;
                        this.Dispose();
                        this.pnlDKyXe.Controls.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Có lỗi, không thể thêm được!");
                        SHAREVAR.DkyXe = false;
                    }

                }
            }
            else
            {
                if (blXe.UpdateVehicle(txtMaXe.Text, txtBienSo.Text, txtTenXe.Text, txtMauSac.Text, ref err) == true)
                {
                    SHAREVAR.maxe = txtMaXe.Text;
                    MessageBox.Show("Đã cập nhật thông tin xe!");
                    this.Dispose();
                    this.pnlDKyXe.Controls.Clear();
                }

                else MessageBox.Show("Lỗi, chưa thể cập nhật!");
            }

        }

        private void txtMaXe_Validating(object sender, CancelEventArgs e)
        {
            if (blXe.CheckIdVehicle(txtMaXe.Text).Tables[0].Rows.Count != 0)
            {
                errorProvider1.SetError(txtMaXe, "Mã xe này đã được sử dụng!");
                check = false;
            }
            else
            {
                errorProvider1.SetError(txtMaXe, null);
                check = true;
                
            }
        }

        private void txtBienSo_Validating(object sender, CancelEventArgs e)
        {
            if (blXe.CheckLicensePlate(txtBienSo.Text).Tables[0].Rows.Count != 0)
            {
                errorProvider1.SetError(txtBienSo, "Biển số này đã được sử dụng!");
                check = false;
            }
            else
            {
                errorProvider1.SetError(txtBienSo, null);
                check = true;
            }
        }
    }
}
