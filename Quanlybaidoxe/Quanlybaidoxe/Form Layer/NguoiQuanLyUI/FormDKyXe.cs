﻿using System;
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
        public bool CheckValues(string MaXe, string BienSo)
        {
            bool check = false;
            BLXe blXe = new BLXe();
            if (blXe.CheckIdVehicle(MaXe).Tables[0].Rows.Count != 0)
            {
                MessageBox.Show("Mã xe này đã được sử dụng!!");               
            }  else if (blXe.CheckLicensePlate(BienSo).Tables[0].Rows.Count != 0)
            {
                MessageBox.Show("Biển số này đã được sử dụng!!");             
            }
            else check = true;
            return check;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenXe.Text.Trim().Length == 0 || txtMaXe.Text.Trim().Length == 0 || txtMauSac.Text.Trim().Length == 0 || txtBienSo.Text.Trim().Length == 0 || cbLoaiXe.Text.Trim().Length == 0)
            {

                MessageBox.Show("Vui lòng điền đủ trước khi xác nhận!");
                return;
            }
            if (SHAREVAR.Add == true)
            {                
                if (CheckValues(txtMaXe.Text, txtBienSo.Text) == true)
                {
                    if (blXe.AddVehicle(txtMaXe.Text, txtBienSo.Text, txtTenXe.Text, txtMauSac.Text, blXe.GetVechicleId(cbLoaiXe.Text).Tables[0].Rows[0][0].ToString(), ref err) == true)
                    {
                        SHAREVAR.maxe = txtMaXe.Text;
                        SHAREVAR.maloaixe = blXe.GetVechicleId(cbLoaiXe.Text).Tables[0].Rows[0][0].ToString();
                        this.Dispose();
                        this.pnlDKyXe.Controls.Clear();

                    }
                    else MessageBox.Show("Có lỗi, không thể thêm được!");

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

    }
}