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
    public partial class frmDoiMK : Form
    {
        public frmDoiMK(string username)
        {
            this.username = username;
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=LAPTOP-F171DVDP\LINHTOT;Initial Catalog=qlsv_02_DTLinhNDThangDPTTien;Integrated Security=True");
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        string username;
        SqlConnection conn;
        SqlCommand cmd;
        private void frmDoiMK_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from dangnhap where username = @username";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", txtmkcu.Text);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            var rs = dt.Rows.Count.ToString();
            if(int.Parse(rs)>=0)
            {
                if(txtmkmoi.Text == txtmklai.Text)
                {
                    string sql1 = "update dangnhap set password = @password where username = @username";
                    SqlCommand cmd1 = new SqlCommand(sql1, conn);
                    cmd1.Parameters.AddWithValue("@password",txtmkmoi.Text);
                    cmd1.Parameters.AddWithValue("@username", username);
                    if(cmd1.ExecuteNonQuery()>0)
                    {
                        MessageBox.Show("đổi mật khẩu thành công");
                        this.Close();
                    }    
                    else
                    {
                        MessageBox.Show("đổi mật khẩu thất bại");
                    }    
                }   
                else
                {
                    MessageBox.Show("mật khẩu không khớp");
                    txtmkmoi.Focus();
                }    
            }   
            else
            {
                MessageBox.Show("mật khẩu hiện tại không đúng");
                txtmkcu.Focus();
            }    
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
