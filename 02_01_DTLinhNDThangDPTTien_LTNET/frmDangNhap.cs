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
//02_01_DTLinhNDThangDPTTien
//Đinh Tùng Linh 19103100098
//Nguyễn Đức Thắng 19103100106
//Đào Phan Trường Tiến 19103100032
//Tin 13a2

namespace _02_01_DTLinhNDThangDPTTien_LTNET
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=LAPTOP-F171DVDP\LINHTOT;Initial Catalog=qlsv_02_DTLinhNDThangDPTTien;Integrated Security=True");
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }    
        }
        SqlConnection conn;
        SqlCommand cmd;
        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                MessageBox.Show("vui lòng nhập tài khoản");
                txtTaiKhoan.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("vui lòng nhập Mật Khẩu");
                txtTaiKhoan.Focus();
                return;
            }

            string sql = "select * from dangnhap where username = @username and password = @password";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", txtTaiKhoan.Text);
            cmd.Parameters.AddWithValue("@password", txtMatKhau.Text);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            var rs = dt.Rows.Count;
            if (rs > 0)
            {
                string username = txtTaiKhoan.Text;
                string sql1 = "select mod from dangnhap where username = @username";
                SqlCommand cmd1 = new SqlCommand(@sql1, conn);
                cmd1.Parameters.AddWithValue("@username", txtTaiKhoan.Text);
                string mod = cmd1.ExecuteScalar().ToString();
                new frmMain(mod,username).Show();
                MessageBox.Show("Đăng nhập thành công với "+ txtTaiKhoan.Text);
            }
            else
            {
                MessageBox.Show("tài khoản hoặc mật khẩu không chính xác");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
