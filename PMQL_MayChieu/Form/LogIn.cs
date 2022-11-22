using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PMQL_MayChieu
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            password_txt.UseSystemPasswordChar = false;
        }

        private void user_btn_Click(object sender, EventArgs e)
        {
            user_txt.BackColor = Color.White;
            panel_user.BackColor = Color.White;
            password_txt.BackColor = SystemColors.Control;
            panel_password.BackColor = SystemColors.Control;
        }

        private void password_btn_Click(object sender, EventArgs e)
        {
            password_txt.BackColor = Color.White;
            panel_password.BackColor = Color.White;
            user_txt.BackColor = SystemColors.Control;
            panel_user.BackColor = SystemColors.Control;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            password_txt.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=TINI\\SQLEXPRESS;Initial Catalog=QlyMayChieuEPU;User ID=sa;Password=123456");
            try
            {
                conn.Open();
                string tk = user_txt.Text;
                string mk = password_txt.Text;
                string sql = "select * from NguoiQuanLy where  TaiKhoan = '"+tk+"' and MatKhau  ='"+mk+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.Read() == true)
                {
                    this.Hide();
                    Home h = new Home();
                    h.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");

            }
        }
    }
}
