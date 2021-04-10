using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Quanlybaidoxe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
        //Di chuyển form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void cboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxShowPass.Checked)
            {
                txtMatKhau.PasswordChar = '\0';
                txtNhapLaiMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '•';
                txtNhapLaiMatKhau.PasswordChar = '•';
            }
        }
    }
}
