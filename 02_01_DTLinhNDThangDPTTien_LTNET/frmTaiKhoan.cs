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
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=LAPTOP-F171DVDP\LINHTOT;Initial Catalog=qlsv_02_DTLinhNDThangDPTTien;Integrated Security=True");
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        string mod = "";
        string username;
        SqlConnection conn;
        SqlCommand cmd;

        private void loaddgv()
        {
            string sql = "select username,password,fullname,email, case when mod = 0 then 'Admin' else 'user' end as Mod from dangnhap";
            cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dgvDSTaiKhoan.DataSource = dt;
        }
        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            loaddgv();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql = "insert into dangnhap(username,password,fullname,email,mod) values(@username,@password,@fullname,@email,@mod)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", txtusername.Text);
            cmd.Parameters.AddWithValue("@password", txtpassword.Text);
            cmd.Parameters.AddWithValue("@fullname", txtfullname.Text);
            cmd.Parameters.AddWithValue("@email", txtemail.Text);
            cmd.Parameters.AddWithValue("@mod", txtmod.Text);
            if(cmd.ExecuteNonQuery()>0)
            {
                MessageBox.Show("thêm mới thành công");
                loaddgv();
            }    
            else
            {
                MessageBox.Show("thêm mới thất bại");
            }    

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int chondong = -1;
            chondong = dgvDSTaiKhoan.CurrentCell.RowIndex;
            string sql = "delete dangnhap where username= @username";
            cmd = new SqlCommand (sql, conn);
            cmd.Parameters.AddWithValue("@username", dgvDSTaiKhoan.Rows[chondong].Cells["username"].Value.ToString());
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Xóa thành công");
                loaddgv();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }

        }

        private void dgvDSTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {
            int chondong = -1;
            chondong = dgvDSTaiKhoan.CurrentCell.RowIndex;
            txtusername.Text = dgvDSTaiKhoan.Rows[chondong].Cells["username"].Value.ToString();
            txtpassword.Text = dgvDSTaiKhoan.Rows[chondong].Cells["password"].Value.ToString();
            txtfullname.Text = dgvDSTaiKhoan.Rows[chondong].Cells["fullname"].Value.ToString();
            txtemail.Text = dgvDSTaiKhoan.Rows[chondong].Cells["email"].Value.ToString();
            txtmod.Text = dgvDSTaiKhoan.Rows[chondong].Cells["mod"].Value.ToString();

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            int chondong = -1;
            chondong = dgvDSTaiKhoan.CurrentCell.RowIndex;
            string sql = "update dangnhap set password=@password ,fullname=@fullname,email=@email,mod=@mod where username=@username";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", dgvDSTaiKhoan.Rows[chondong].Cells["username"].Value.ToString());
            cmd.Parameters.AddWithValue("@password", txtpassword.Text);
            cmd.Parameters.AddWithValue("@fullname", txtfullname.Text);
            cmd.Parameters.AddWithValue("@email", txtemail.Text);
            if(txtmod.Text == "user")
            {
                cmd.Parameters.AddWithValue("@mod", "1");
            }    
            else
            {
                cmd.Parameters.AddWithValue("@mod", "0");
            }
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("sửa thành công");
                loaddgv();
            }
            else
            {
                MessageBox.Show("sửa thất bại");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
