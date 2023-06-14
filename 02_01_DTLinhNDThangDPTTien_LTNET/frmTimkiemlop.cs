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
    public partial class frmTimkiemlop : Form
    {
        public frmTimkiemlop()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=LAPTOP-F171DVDP\LINHTOT;Initial Catalog=qlsv_02_DTLinhNDThangDPTTien;Integrated Security=True");
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        SqlConnection conn;
        SqlCommand cmd;

        private void Timkiemlop_Load(object sender, EventArgs e)
        {
            string sql = "select * from lop";
            cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dgv_lop.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from lop where tenlop =@tenlop";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@tenlop", txt_timkiem.Text);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dgv_lop.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
