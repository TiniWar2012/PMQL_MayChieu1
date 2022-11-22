using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PMQL_MayChieu
{
    public partial class Home : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );



        public Home()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = TrangChu_btn.Height;
            PnlNav.Top = TrangChu_btn.Top;
            PnlNav.Left = TrangChu_btn.Left;
            TrangChu_btn.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void TrangChu_btn_Click(object sender, EventArgs e)
        {
            PnlNav.Height = TrangChu_btn.Height;
            PnlNav.Top = TrangChu_btn.Top;
            PnlNav.Left = TrangChu_btn.Left;
            TrangChu_btn.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PnlNav.Height = Device_btn.Height;
            PnlNav.Top = Device_btn.Top;
            PnlNav.Left = Device_btn.Left;
            Device_btn.BackColor = Color.FromArgb(46, 51, 73);
            TrangChu_btn.BackColor = Color.FromArgb(24, 30, 54);

            lbl_Title.Text = "Thiết bị";
            this.PnlFormLoader.Controls.Clear();
            ThietBi tb = new ThietBi() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            tb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(tb);
            tb.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PnlNav.Height = Supplier_btn.Height;
            PnlNav.Top = Supplier_btn.Top;
            PnlNav.Left = Supplier_btn.Left;
            Supplier_btn.BackColor = Color.FromArgb(46, 51, 73);
            TrangChu_btn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PnlNav.Height = Note_btn.Height;
            PnlNav.Top = Note_btn.Top;
            PnlNav.Left = Note_btn.Left;
            Note_btn.BackColor = Color.FromArgb(46, 51, 73);
            TrangChu_btn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PnlNav.Height = Staff_btn.Height;
            PnlNav.Top = Staff_btn.Top;
            PnlNav.Left = Staff_btn.Left;
            Staff_btn.BackColor = Color.FromArgb(46, 51, 73);
            TrangChu_btn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Room_btn_Click(object sender, EventArgs e)
        {
            PnlNav.Height = Room_btn.Height;
            PnlNav.Top = Room_btn.Top;
            PnlNav.Left = Room_btn.Left;
            Room_btn.BackColor = Color.FromArgb(46, 51, 73);
            TrangChu_btn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Chart_btn_Click(object sender, EventArgs e)
        {
            PnlNav.Height = Chart_btn.Height;
            PnlNav.Top = Chart_btn.Top;
            PnlNav.Left = Chart_btn.Left;
            Chart_btn.BackColor = Color.FromArgb(46, 51, 73);
            TrangChu_btn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult cf = MessageBox.Show("Đăng xuất khỏi tài khoản ?", "Cảnh báo", MessageBoxButtons.OKCancel);
            if( cf == DialogResult.OK)
            {
                this.Hide();
                LogIn li = new LogIn();
                li.Show();
            }
            PnlNav.Height = Logout_btn.Height;
            PnlNav.Top = Logout_btn.Top;
            PnlNav.Left = Logout_btn.Left;
            Logout_btn.BackColor = Color.FromArgb(46, 51, 73);
            TrangChu_btn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void TrangChu_btn_Leave(object sender, EventArgs e)
        {
            TrangChu_btn.BackColor = Color.FromArgb(24,30,54);
        }

        private void Device_btn_Leave(object sender, EventArgs e)
        {
            Device_btn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Supplier_btn_Leave(object sender, EventArgs e)
        {
            Supplier_btn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Note_btn_Leave(object sender, EventArgs e)
        {
            Note_btn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Staff_btn_Leave(object sender, EventArgs e)
        {
            Staff_btn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Room_btn_Leave(object sender, EventArgs e)
        {
            Room_btn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Chart_btn_Leave(object sender, EventArgs e)
        {
            Chart_btn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Logout_btn_Leave(object sender, EventArgs e)
        {
            Logout_btn.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            DialogResult cf = MessageBox.Show("Thoát ứng dụng và đăng xuất khỏi tài khoản ?", "Cảnh báo", MessageBoxButtons.OKCancel);
            if (cf == DialogResult.OK)
            {
                Application.Exit();
            }
        }

    }
}
