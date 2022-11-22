using System;
using System.Data;
using System.Data.Entity;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace PMQL_MayChieu
{
    public partial class ThietBi : Form
    {
        public ThietBi()
        {
            InitializeComponent();

        }
        private KetNoi kn = new KetNoi();
        private void getdata()
        {
            string sql = "select IdThietBi, TenThietBi , Gia, TenNhaCungCap, SoNamBaoHanh, NgayMua, TenTrangThai, TenPhong, TenToa\r\nfrom ThietBi, Phong, Toa, TrangThaiTB, NhaCungCap\r\nwhere ThietBi.IdNhaCungCap = NhaCungCap.IdNCC\r\n\tand ThietBi.IdTrangThai = TrangThaiTB.IdTrangThai\r\n\tand ThietBi.IdPhong = Phong.IdPhong\r\n\tand ThietBi.IdToa = Toa.IdToa";
            DataSet ds = kn.LayDuLieu(sql, "ThietBi");
            DGV_ThietBi.DataSource = ds.Tables["ThietBi"];
            cbb_Phong.Text = "Chọn Tòa sau đó chọn Phòng";
            //FillCBB_Phong();
            FillCBB_Toa();
            FillCBB_NCC();
            FillCBB_TT();
            txt_Gia.Text = "";
            txt_NamBH.Text = "";
            txt_Ten.Text = "";
            txtTimkiem.Text = "Tìm kiếm ....";
        }
        private void FillCBB_NCC()
        {
            //cbb_NCC.Items.Clear();
            SqlConnection conn = new SqlConnection("Data Source=TINI\\SQLEXPRESS;Initial Catalog=QlyMayChieuEPU;User ID=sa;Password=123456");
            conn.Open();
            string sql = "SELECT IdNCC,TenNhaCungCap FROM NhaCungCap ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            ////DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(dt);

            //foreach (DataRow dr in dt.Rows)
            //{
            //    cbb_NCC.Items.Add(dr["TenNhaCungCap"].ToString());
            //}
            //OleDbConnection conn = new OleDbConnection(@"Data Source=TINI\\SQLEXPRESS;Initial Catalog=QlyMayChieuEPU;User ID=sa;Password=123456");
            //OleDbDataAdapter da = new OleDbDataAdapter("")
            DataSet dt = new DataSet();
            da.Fill(dt, "TenNhaCungCap");
            cbb_NCC.DataSource = dt.Tables["TenNhaCungCap"];
            cbb_NCC.DisplayMember = "TenNhaCungCap";
            cbb_NCC.ValueMember = "IdNCC";
            cbb_NCC.Text = "Chọn nhà cung cấp";
            conn.Close(); 
        }

        private void FillCBB_TT()
        {
            //cbb_TrangThai.Items.Clear();
            SqlConnection conn = new SqlConnection("Data Source=TINI\\SQLEXPRESS;Initial Catalog=QlyMayChieuEPU;User ID=sa;Password=123456");
            conn.Open();
            string sql = "SELECT Meta, TenTrangThai FROM TrangThaiTB ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);

            //foreach (DataRow dr in dt.Rows)
            //{
            //    cbb_TrangThai.Items.Add(dr["TenTrangThai"].ToString());
            //}
            DataSet dt = new DataSet();
            da.Fill(dt, "TenTrangThai");
            cbb_TrangThai.DataSource = dt.Tables["TenTrangThai"];
            cbb_TrangThai.DisplayMember = "TenTrangThai";
            cbb_TrangThai.ValueMember = "Meta";
            cbb_TrangThai.Text = "Chọn trạng thái";
            conn.Close();
        }
        private void FillCBB_Phong()
        {
            cbb_Phong.Items.Clear();
            SqlConnection conn = new SqlConnection("Data Source=TINI\\SQLEXPRESS;Initial Catalog=QlyMayChieuEPU;User ID=sa;Password=123456");
            conn.Open();
            string sql = "SELECT IdPhong,TenPhong FROM Phong WHERE (Toa.TenToa = N'\" + cbb_Toa.Text + @\"')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //;
            //da.Fill(dt);

            //foreach (DataRow dr in dt.Rows)
            //{
            //    cbb_Phong.Items.Add(dr["TenPhong"].ToString());
            //}
            DataSet dt = new DataSet();
            da.Fill(dt, "TenPhong");
            cbb_Phong.DataSource = dt.Tables["TenPhong"];
            cbb_Phong.DisplayMember = "TenPhong";
            cbb_Phong.ValueMember = "IdPhong";
            cbb_Phong.Text = "Chọn phòng";
            conn.Close();
        }
        private void FillCBB_Toa()
        {
            //cbb_Toa.Items.Clear();
            SqlConnection conn = new SqlConnection("Data Source=TINI\\SQLEXPRESS;Initial Catalog=QlyMayChieuEPU;User ID=sa;Password=123456");
            conn.Open();
            string sql = "SELECT IdToa, TenToa FROM Toa ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();           
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            System.Data.DataTable dt = new DataTable();
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                cbb_Toa.Items.Add(dr["TenToa"].ToString());
                cbb_Toa.DisplayMember = "TenToa";
                cbb_Toa.ValueMember = "IdToa";
                cbb_Toa.Text = "Chọn Tòa";
            }

            //DataSet dt = new DataSet();
            //da.Fill(dt, "TenToa");
            //cbb_Toa.DataSource = dt.Tables["TenToa"];

            conn.Close();
        }

        private void ThietBi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet15.TrangThaiTB' table. You can move, or remove it, as needed.
            this.trangThaiTBTableAdapter2.Fill(this.dataSet15.TrangThaiTB);
            // TODO: This line of code loads data into the 'dataSet15.Toa' table. You can move, or remove it, as needed.
            this.toaTableAdapter2.Fill(this.dataSet15.Toa);
            // TODO: This line of code loads data into the 'dataSet15.NhaCungCap' table. You can move, or remove it, as needed.
            this.nhaCungCapTableAdapter3.Fill(this.dataSet15.NhaCungCap);
            //FillCBB_Phong();
            setLableText();
            getdata();

        }
        private void setLableText()
        {
            SqlConnection conn = new SqlConnection("Data Source=TINI\\SQLEXPRESS;Initial Catalog=QlyMayChieuEPU;User ID=sa;Password=123456");
            conn.Open();
            string sql = "SELECT SUM(ChiPhi) AS Tongtien FROM Phieu where IdLoaiPhieu in ('2', '1') ";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lbl_test.Text = dr.GetValue(0).ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sql = string.Format("select IdThietBi, TenThietBi , Gia, TenNhaCungCap, SoNamBaoHanh, NgayMua, TenTrangThai, TenPhong, TenToa\r\nfrom ThietBi, Phong, Toa, TrangThaiTB, NhaCungCap\r\nwhere ThietBi.IdNhaCungCap = NhaCungCap.IdNCC\r\n\tand ThietBi.IdTrangThai = TrangThaiTB.IdTrangThai\r\n\tand ThietBi.IdPhong = Phong.IdPhong\r\n\tand ThietBi.IdToa = Toa.IdToa and ThietBi.TenThietBi = '"+txtTimkiem.Text+"'");
            DataSet ds = kn.LayDuLieu(sql, "ThietBi");
            DGV_ThietBi.DataSource = ds.Tables["ThietBi"];
        }

        private string IdThietBi = "";
        private void DGV_ThietBi_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i = DGV_ThietBi.CurrentRow.Index;
            IdThietBi = DGV_ThietBi.Rows[i].Cells["Id"].Value.ToString();
            txt_Ten.Text = DGV_ThietBi.Rows[i].Cells["TenThietBi"].Value.ToString();
            txt_Gia.Text = DGV_ThietBi.Rows[i].Cells["Gia"].Value.ToString();
            cbb_NCC.Text = DGV_ThietBi.Rows[i].Cells["NhaCungCap"].Value.ToString();
            txt_NamBH.Text = DGV_ThietBi.Rows[i].Cells["SoNamBaoHanh"].Value.ToString();
            dpk_NgayMua.Text = DGV_ThietBi.Rows[i].Cells["NgayMua"].Value.ToString();
            cbb_TrangThai.Text = DGV_ThietBi.Rows[i].Cells["TrangThai"].Value.ToString();
            cbb_Phong.Text = DGV_ThietBi.Rows[i].Cells["Phong"].Value.ToString();
            cbb_Toa.Text = DGV_ThietBi.Rows[i].Cells["Toa"].Value.ToString();
        }

        private void cbb_Toa_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=TINI\\SQLEXPRESS;Initial Catalog=QlyMayChieuEPU;User ID=sa;Password=123456");
            cbb_Phong.Text = "Chọn phòng";
            cbb_Phong.Items.Clear();
            conn.Open();
            String sql = "Select Toa.TenToa, Phong.TenPhong, Phong.IdPhong " +
                "FROM Toa Inner Join Phong ON Toa.IdToa = Phong.IdToa WHERE (Toa.TenToa = N'" + cbb_Toa.Text + @"')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read())
            {
                cbb_Phong.Items.Add(dr[1].ToString());
                i++;
                cbb_Phong.DisplayMember = "TenPhong";
                cbb_Phong.ValueMember = "IdPhong";
                cbb_Phong.Text = "Chọn Phòng";
            }
            conn.Close();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            string idnhacungcap = cbb_NCC.GetItemText(cbb_NCC.SelectedItem);
            string idtrangthai = cbb_TrangThai.GetItemText(cbb_TrangThai.SelectedValue);
            string idtoa = cbb_Toa.GetItemText(cbb_Toa.SelectedItem);
            string idphong = cbb_Phong.GetItemText(cbb_Phong.SelectedItem);
            string ten = txt_Ten.Text;
            string Gia = txt_Gia.Text;
            string NamBH = txt_NamBH.Text;
            string date = dpk_NgayMua.Value.ToShortDateString();
            string query = "\r\nDECLARE @idToa BIGINT;\r\nset @idToa = (select IdToa\r\nfrom Toa\r\nwhere TenToa = '" + idtoa + "')\r\n" +
                "DECLARE @idncc BIGINT;\r\nset @idncc = (select IdNCC\r\nfrom NhaCungCap\r\nwhere TenNhaCungCap = '" + idnhacungcap + "')\r\n" +
                "DECLARE @idtt BIGINT;\r\nset @idtt = (select IdTrangThai\r\nfrom TrangThaiTB\r\nwhere Meta = '" + idtrangthai + "')\r\n" +
                "DECLARE @idphong BIGINT;\r\nset @idphong = (select IdPhong\r\nfrom Phong\r\nwhere TenPhong = '" + idphong + "')\r\n" +
                "INSERT INTO ThietBi \r\nVALUES (N'" + ten + "'," + Gia + ", @idncc," + NamBH + ",'" + date + "',@idtt,@idphong,@idToa)";
            if (ten == "" || Gia == "" || NamBH == "" || cbb_NCC.SelectedItem == null || cbb_TrangThai.SelectedItem == null || cbb_Toa.SelectedItem == null || cbb_Phong.SelectedItem == null)
            {
                MessageBox.Show("Cần nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                bool kt = kn.ThucThi(query);
                if (kt == true)
                {
                    MessageBox.Show("Them thanh cong", "Thong bao", MessageBoxButtons.OK);
                    getdata();
                }
                else
                {
                    MessageBox.Show("Them that bai", "Thong bao", MessageBoxButtons.OK);
                }
            }
        }

        private void txtTimkiem_MouseClick(object sender, MouseEventArgs e)
        {
            getdata();
            txtTimkiem.Clear();
        }
        private void panel3_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Danh sách thiết bị";
            //
            // storing header part in Excel  
            for (int i = 1; i < DGV_ThietBi.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = DGV_ThietBi.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < DGV_ThietBi.Rows.Count; i++)
            {
                for (int j = 0; j < DGV_ThietBi.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = DGV_ThietBi.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            //  workbook.SaveAs("C:\\Users\\lionel\\Desktop\\Test\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            //  app.Quit(); 
        }

        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            string idnhacungcap = cbb_NCC.GetItemText(cbb_NCC.SelectedItem);
            string idtrangthai = cbb_TrangThai.GetItemText(cbb_TrangThai.SelectedValue);
            string idtoa = cbb_Toa.GetItemText(cbb_Toa.SelectedItem);
            string idphong = cbb_Phong.GetItemText(cbb_Phong.SelectedItem);
            string ten = txt_Ten.Text;
            string Gia = txt_Gia.Text;
            string NamBH = txt_NamBH.Text;
            string date = dpk_NgayMua.Value.ToShortDateString();
            string query = "\r\nDECLARE @idToa BIGINT;\r\nset @idToa = (select IdToa\r\nfrom Toa\r\nwhere TenToa = '" + idtoa + "')\r\n" +
                "DECLARE @idncc BIGINT;\r\nset @idncc = (select IdNCC\r\nfrom NhaCungCap\r\nwhere TenNhaCungCap = '" + idnhacungcap + "')\r\n" +
                "DECLARE @idtt BIGINT;\r\nset @idtt = (select IdTrangThai\r\nfrom TrangThaiTB\r\nwhere Meta = '" + idtrangthai + "')\r\n" +
                "DECLARE @idphong BIGINT;\r\nset @idphong = (select IdPhong\r\nfrom Phong\r\nwhere TenPhong = '" + idphong + "')\r\n" +
                "update ThietBi set TenThietBi = N'" +ten+"' , Gia = " + Gia + ", IdNhaCungCap = @idncc , SoNamBaoHanh = " + NamBH + ", NgayMua = '" + date + "', IdTrangThai = @idtt, IdPhong = @idphong, IdToa = @idToa WHERE IdThietBi = '"+IdThietBi+"'";
            if (ten == "" || Gia == "" || NamBH == "" || cbb_NCC.SelectedItem == null || cbb_TrangThai.SelectedItem == null || cbb_Toa.SelectedItem == null || cbb_Phong.SelectedItem == null)
            {
                MessageBox.Show("Cần nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                bool kt = kn.ThucThi(query);
                if (kt == true)
                {
                    MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK);
                    getdata();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin thất bại", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void panel9_MouseClick(object sender, MouseEventArgs e)
        {
            getdata();
        }
        private void GetPhong()
        {
            SqlConnection conn = new SqlConnection("Data Source=TINI\\SQLEXPRESS;Initial Catalog=QlyMayChieuEPU;User ID=sa;Password=123456");
            cbb_Phong.Text = "Chọn Tòa sau đó chọn Phòng";
            cbb_Phong.Items.Clear();
            conn.Open();
            String sql = "Select Toa.TenToa, Phong.TenPhong, Phong.IdPhong " +
                "FROM Toa Inner Join Phong ON Toa.IdToa = Phong.IdToa WHERE (Toa.TenToa = N'" + cbb_Toa.Text + @"')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            while (dr.Read() && cbb_Toa.Text !=null)
            {
                cbb_Phong.Items.Add(dr[1].ToString());
                i++;
                cbb_Phong.DisplayMember = "TenPhong";
                cbb_Phong.ValueMember = "IdPhong";
                cbb_Phong.Text = "Chọn Phòng";
            }
            conn.Close();
        }
        private void cbb_Phong_Click(object sender, EventArgs e)
        {
            string idtoa = cbb_Toa.GetItemText(cbb_Toa.SelectedItem);
            GetPhong();
        }

        private void panel9_Click(object sender, EventArgs e)
        {

            string query = string.Format("delete from ThietBi where IdThietBi = '"+IdThietBi+"'");
            bool kt = kn.ThucThi(query);
            if (kt == true)
            {
                MessageBox.Show("Xóa thành công ");
                getdata();
            }
            else
            {
                MessageBox.Show("Xóa thất bại ");
            }
        }
    }
}