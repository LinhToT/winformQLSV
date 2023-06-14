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
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
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

        private void frmTimKiem_Load(object sender, EventArgs e)
        {
            string sql = "select masv,hoten,ngaysinh,case when gioitinh = 1 then 'Nam' else N'Nữ' end as gioitinh,quequan,diemrl,l.tenlop from sinhvien s inner join lop l on l.malop = s.malop";
            cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dgv_sinhvien.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select masv,hoten,ngaysinh,case when gioitinh = 1 then 'Nam' else N'Nữ' end as gioitinh,quequan,diemrl,l.tenlop from sinhvien s inner join lop l on l.malop = s.malop where hoten =@hoten or quequan = @quequan";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@hoten", txt_timkiem.Text);
            cmd.Parameters.AddWithValue("@quequan", txt_timkiem.Text);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dgv_sinhvien.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
